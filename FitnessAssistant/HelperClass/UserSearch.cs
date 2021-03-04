using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant.HelperClass
{
    
    public static class UserSearch
    {       
        public static bool GetUser(string login, string password) // 
        {
            var user = FitnessAssistant.EF.AppData.Context.Users.ToList().
               Where(i => i.Login == login && i.Password == password).
               FirstOrDefault();

            if (user!= null)
            {
                FitnessAssistant.EF.AppData.userData = user;
                return true;
            }
            else
            {
                return false;
            }            
        }

        public static bool GetUser(string login)
        {
            var user = FitnessAssistant.EF.AppData.Context.Users.ToList().
               Where(i => i.Login == login).
               FirstOrDefault();

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
