using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class LoginData
    {
        private DataAccess _access = new DataAccess();

        public bool CheckLogin(Login obj)
        {
            
            string LoginCommand = "SELECT COUNT(*) FROM login WHERE UserID='" 
                + obj.UserID + "' AND password='" + obj.Password + "'";
            SqlCommand command = new SqlCommand(LoginCommand);
            if (_access.LoginExecute(command) == "1")
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
