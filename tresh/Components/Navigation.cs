using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tresh.Components
{
    internal class Navigation
    {
        public static bool isAuth = false;
        public static MainWindow main;
        public static User AuthUser = null;
        public static List<User> navs = new List<User>();
    }
}
