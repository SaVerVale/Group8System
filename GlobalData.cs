using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group8Sytem
{
    public static class GlobalData
    {
        // Static variable to store the username of the logged-in user
        private static string loggedInUsername;

        public static string LoggedInUsername
        {
            get => loggedInUsername;
            set => loggedInUsername = value;
        }
    }
}
