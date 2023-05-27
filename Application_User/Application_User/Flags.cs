using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_User
{
    internal struct Flags
    {
        [Flags]
        public enum Permissions
        {
            None = 0,
            ViewUsers = 1,
            ViewAdmins = 2,
            EditSelf = 4,
            EditOther = 8,
            ViewPasswords = 16,

            Guest = ViewUsers,  //1
            CommonUser = ViewAdmins | ViewUsers,    //3
            ExtendedUser = CommonUser | EditSelf,
            Moderator = CommonUser | ViewPasswords,
            Admin = ExtendedUser | EditOther | ViewPasswords    //31
        }
    }
}
