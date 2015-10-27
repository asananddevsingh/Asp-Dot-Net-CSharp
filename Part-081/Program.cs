using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_081
{
    /// <summary>
    /// Part 81 : When to use a dictionary over list in c
    /// </summary>
    class Program
    {
        /*
         * Find() method of the list class loops thru each object in the list until a match found.
         *      So, if you want to lookup a value using a key dictionary is better for performance over list.
         *      So, use dictionary when you know the collection will be primarily used for lookups.
         */
        static void Main(string[] args)
        {
            Country country1 = new Country() { Code = "IND", Name = "India", Capital = "New delhi" };
            Country country2 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
            Country country3 = new Country() { Code = "USA", Name = "United States", Capital = "Washington" };
            Country country4 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };

            #region 1. Using List, which is not efficient.

            /* If you want to check the working with list, uncomment the below code. */

            //List<Country> listCountries = new List<Country>();

            //listCountries.Add(country1);
            //listCountries.Add(country2);
            //listCountries.Add(country3);
            //listCountries.Add(country4);

            //String strUserChoice = String.Empty;
            //do
            //{
            //    Console.WriteLine("Please enter country code");
            //    String strCountryCode = Console.ReadLine().ToUpper();

            //    Country resultCountry = listCountries.Find(c => c.Code == strCountryCode);
            //    if (resultCountry == null)
            //    {
            //        Console.WriteLine("Country code not valid.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
            //    }
            //    do
            //    {
            //        Console.WriteLine("Do you want to continue - YES/NO ?");
            //        strUserChoice = Console.ReadLine().ToUpper();
            //    } while (strUserChoice != "YES" && strUserChoice != "NO");
            //} while (strUserChoice == "YES"); 

            #endregion

            #region 2. Using Dictionary, which is efficient.

            Dictionary<String, Country> dictCountries = new Dictionary<String, Country>();
            dictCountries.Add(country1.Code, country1);
            dictCountries.Add(country2.Code, country2);
            dictCountries.Add(country3.Code, country3);
            dictCountries.Add(country4.Code, country4);
            String userChoice = String.Empty;

            do
            {
                Console.WriteLine("Please enter country code");
                String countryCode = Console.ReadLine().ToUpper();

                Country dResultCountry = dictCountries.ContainsKey(countryCode) ? dictCountries[countryCode] : null;
                if (dResultCountry == null)
                {
                    Console.WriteLine("Country code not valid.");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", dResultCountry.Name, dResultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue - YES/NO ?");
                    userChoice = Console.ReadLine().ToUpper();
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");

            #endregion
        }
    }

    public class Country
    {
        public String Name { get; set; }
        public String Code { get; set; }
        public String Capital { get; set; }
    }
}
