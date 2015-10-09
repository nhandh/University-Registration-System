/*****************************
 * Project name: University Registration System
 * Developer: Nhan Do
 * Database Manager: Kaitlyn Davis
 * Tester: Emilio Lopez
 * 
 * Purpose: For Object Oriented Programming and C# Learning
 * Date: 04/26/2015
 * 
 * Description: allow students registering for classes
 * 
 * ****************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginInterface());
        }
    }
}
