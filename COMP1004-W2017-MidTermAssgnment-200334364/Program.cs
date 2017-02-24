// App Name : Program Form
// Author's Name : Kinjal Patel 
// Student ID : 200334364
// App Creation Date : February 22, 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200334364
{
    static class Program
    {
        internal static Character character;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AbilityForm());
        }
    }
}
