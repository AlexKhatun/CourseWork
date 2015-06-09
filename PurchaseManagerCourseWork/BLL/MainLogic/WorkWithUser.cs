using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MainLogic
{
    public class WorkWithUser : BaseMainLogic
    {
        public bool CheckForUniqueUser(string email)
        {
            var users = objBs.UserBs.GetAll();
            return users.All(i => i.Email != email);
        }

        public static string GetPasswordHash(string password)
        {
            string passHash;
            int s = password.GetHashCode();
            passHash = s.ToString();
            return passHash;
        }
    }
}
