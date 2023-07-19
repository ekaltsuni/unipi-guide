using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unipi_guide
{
    internal static class Program
    {
        /* Global class for getting and setting whether user is logged in or not across program
         * to control visibility of items between visitors and registered users */
        public static class userStatus
        {
            private static Boolean _registeredUser;
            public static Boolean registeredUser
            {
                get { return _registeredUser; }
                set { _registeredUser = value; }
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new homepage_form());
        }
    }
}
