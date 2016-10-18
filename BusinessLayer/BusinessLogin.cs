using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Entities;

namespace BusinessLayer
{
    public class BusinessLogin
    {
        Login log = new Login();
        LoginData data = new LoginData(); 
        public bool Login(string userId, string pass)
        {
            log.UserID = userId;
            log.Password = pass;


            if (data.CheckLogin(log) == true)
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
