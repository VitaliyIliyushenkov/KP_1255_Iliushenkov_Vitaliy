using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_User
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        [Flags]
        public enum Permissions
        {
            None = 0,
            ViewUsers = 1,
            ViewAdmins = 2,
            EditSelf = 4,
            EditOther = 8,
            ViewPasswords = 16,


            Guest = ViewUsers,//1
            CommonUser = ViewAdmins | ViewUsers,//3
            ExtendedUser = CommonUser | EditSelf,
            Moderator = CommonUser | ViewPasswords,
            Admin = ExtendedUser | EditOther | ViewPasswords//31
        }
        public static int user_key;
        public static string user_name;
        public static List<Account> results = new List<Account>();
        public static string path_date = $@"{Environment.CurrentDirectory}\\Data.json";
        public static string path_password = $@"{Environment.CurrentDirectory}\\Password.json";
    }
}
