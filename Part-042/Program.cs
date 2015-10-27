using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.Serialization;

namespace Part_042
{
    /// <summary>
    /// Part 042 : Custom Exception.
    /// </summary>
    class Program
    {
        /*
         * 1. When do you usually go for creating your own custom exceptions ?
         * >> If none of the already exsisting dotnet exceptions adequately describes the prblem (Dot net ready made excetions list are at >> Ctrl + Alt + E).
         * 
         * Example of custom exception:
         * 1. I have an asp.net web aplication.
         * 2. The application should allow the user to have only one logged in session.
         * 3. If the user is already logged in, and if he opens another browser window and tries to login again, The application should throw an error stating he is already logged in another browser window.
         */
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in, no duplicate session allowed.");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }

    /// <summary>
    /// Custom Exception - Steps
    /// 
    /// 1. Create a class that derives from Sytem.Exception class. As a convention, end the class name with Exception suffix. 
    ///     All .NET exceptions end with, exception suffix.
    /// 2. Provide a public constructors, that takes in a string parameter. This constructor simply passes the string parameter, 
    ///     to the base exception class construtor.
    /// 3. Using InnerException, you can also track back the original exception. If you want to prvide this capability for your custom exception class, 
    ///     then overload the constructor accordingly.
    /// 4. If you want your exception class object to work across application domains, then the object must be serializable. 
    ///     To make your exception class serializable mark it with Serializable attribute and provide a constructor
    ///     that invokes the base Exception class constructor that takes in SerializationInfo and StreamingContext objects as parameters.
    /// NOTE ::
    ///     It is also possible to provide you own custom serialization.
    /// </summary>
    #region Custom Exception

    [Serializable]
    public class UserAlreadyLoggedInException : Exception // OR ApplicationException
    {
        public UserAlreadyLoggedInException()
            : base()
        {
        }
        public UserAlreadyLoggedInException(String message)
            : base(message)
        {
        }

        // This will help to track inner exception also while using our custom excetion class.
        public UserAlreadyLoggedInException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

        // This will help our class to work in different application domain.
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
    #endregion
}
