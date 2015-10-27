using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;

namespace Part_054
{
    /// <summary>
    /// Part 054 : Example of reflection.
    /// </summary>
    public partial class ReflectionDemo : Form
    {
        public ReflectionDemo()
        {
            InitializeComponent();
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            lstProperties.Items.Clear();
            lstMethods.Items.Clear();
            lstConstructors.Items.Clear();
            lblError.Visible = false;

            String typeName = txtType.Text;
            Type T = Type.GetType(typeName);

            if (T != null)
            {                
                MethodInfo[] methods = T.GetMethods();
                foreach (MethodInfo m in methods)
                {
                    lstMethods.Items.Add(String.Format("{0}, {1}", m.ReturnType.Name, m.Name));
                }

                PropertyInfo[] propertes = T.GetProperties();
                foreach (PropertyInfo p in propertes)
                {
                    lstProperties.Items.Add(String.Format("{0}, {1}", p.PropertyType.Name, p.Name));
                }

                ConstructorInfo[] constructors = T.GetConstructors();
                foreach (ConstructorInfo c in constructors)
                {
                    lstConstructors.Items.Add(c.ToString());
                }
            }
            else
            {
                lblError.Text = "Oops !!! No data found for \"" + txtType.Text + "\" type";
                lblError.Visible = true;
            }
        }
    }
}
