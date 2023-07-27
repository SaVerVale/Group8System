using Group8Sytem;
using System;
using System.Windows.Forms;

namespace Kape
{
    public static class SessionManager
    {
        public static string LoggedInUsername { get; private set; }

        public static void SetLoggedInUser(string username)
        {
            LoggedInUsername = username;
        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Show the login window and handle successful login
            using (LoginWindow loginWindow = new LoginWindow())
            {
                Application.Run(loginWindow);

                // After the login window is closed, check if the user successfully logged in
                if (loginWindow.LoginSuccessful)
                {
                    // Retrieve the logged-in user's information from the login window
                    string loggedInUser = loginWindow.LoggedInUsername;

                    // Set the logged-in user's information in the SessionManager
                    SessionManager.SetLoggedInUser(loggedInUser);

                    // Open the main application form (Form1)
                    Application.Run(new Form1());
                }
            }
        }
    }
}
