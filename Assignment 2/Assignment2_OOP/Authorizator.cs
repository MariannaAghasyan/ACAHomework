using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP
{
    /// <summary>
    /// 
    /// </summary>
    public static class Authorizator
    {
        /// <summary>
        /// user's authorization
        /// </summary>
        /// <returns></returns>
        public static User Authorization ()
        {
            String userName = "";
            Console.WriteLine("Please input user name.");
            userName = Console.ReadLine();

            if (!Environment.users.ContainsKey(userName))
            {
                return null;
            }
            User currentUser = Environment.users[userName];
            User newUser = currentUser.IncompleteUser();
            newUser = newUser.Լրացում();

            if (currentUser == newUser)
            {
                Environment.log += AcceptLog(currentUser);     
                return currentUser;
            }

            Environment.log += RejectLog(newUser);
            return null;
        }

        /// <summary>
        /// Accept login information.
        /// </summary>
        /// <returns>accept log string. </returns>
        public static String AcceptLog (User user)
        {
            return DateTime.Now.ToString() + " : login accepted : " + user.ToString();
        }

        /// <summary>
        /// Reject login information.
        /// </summary>
        /// <returns> reject log string. </returns>
        public static String RejectLog (User user)
        {
            return DateTime.Now.ToString() + " : login rejected : " + user.ToString();
        }

        /// <summary>
        /// Logout information
        /// </summary>
        /// <param name="user"> user who logout.</param>
        /// <returns> logout log string. </returns>
        public static String Logout(User user)
        {
            return DateTime.Now.ToString() + " : logout : " + user.ToString();
        }

    }

}
