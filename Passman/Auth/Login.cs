using System;
using System.Collections.Generic;
using System.Text;

namespace Passman.Auth
{
    class Login
    {
        int badAttempt = 0;

        public bool AttemptLogin(String username,String password,String sessionid) {
            
            //Checks Username
            // Queries the database if username exists
            if (username.Equals("test"))
            {
                //Check Password
                // Queries the database if password exists
                if (password.Equals("test"))
                {
                    //successful login

                    // add bad attempt to database

                    // returns attempt
                    return true;
                }
                else
                {
                    // add bad attempt to database
                    return false;
                }
            }
            else 
            {
                // Bad Attempt Add One
                badAttempt = badAttempt + 1;
                return false;
            }
        }

        public int getLoginAttempts() {
            return badAttempt;
        }
    }
}
