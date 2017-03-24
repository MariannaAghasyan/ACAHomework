using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP
{
    /// <summary>
    /// class Editor represents editor users.
    /// </summary>
    public class Editor : Guest
    {
        /// <summary>
        /// Constructor. Contracts User by the given name.
        /// This is incomplete user.
        /// </summary>
        /// <param name="userName"> user's name. </param>
        protected Editor (String userName)
            : base(userName)
        {
            IsCompleted = false;
        }

        /// <summary>
        /// Constructor. Contracts User by the given name and password.
        /// this is complete user.
        /// </summary>
        /// <param name="userName"> user's name. </param>
        /// <param name="password"> user's password. </param>
        public Editor(String userName, String password)
            : base(userName)
        {
            Password = password;
            IsCompleted = true;
        }

        /// <summary>
        /// User's password
        /// </summary>
        public String Password
        {
            get;
            private set;
        }

        /// <summary>
        /// Constrcats new incomplete editor user.
        /// </summary>
        /// <param name="userName"> user's name </param>
        /// <returns> new use r</returns>
        public override User IncompleteUser()
        {
            return new Editor (UserName);
        }

        /// <summary>
        /// Լրացնում է օգտագործողին: 
        /// </summary>
        /// <returns> Օգտագործողը դառնում է ամբողջական: </returns>
        public override User Լրացում()
        {
            if (!IsCompleted)
            {
                base.Լրացում();

                Console.WriteLine("Please input password for Editor.");
                Console.Write("Password : ");
                Password = Console.ReadLine();
                IsCompleted = true;
            }

            return this;
        }

        /// <summary>
        /// Checks the equality of the current user with the given one.
        /// </summary>
        /// <param name="obj"> User to check equality with.</param>
        /// <returns> True if all the corresponding elements are equal. </returns>
        public override Boolean Equals(object obj)
        {
            if (!(obj is Editor))
            {
                return false;
            }

            if (!base.Equals((Guest)obj))
            {
                return false;
            }

            if (Password != ((Editor)obj).Password)
            {
                return false;
            }
            
            return true;
        }

        /// <summary>
        /// Calculate HashCode for User
        /// </summary>
        /// <returns> HashCode of User. </returns>
        public override Int32 GetHashCode()
        {
            return base.GetHashCode() + Password.GetHashCode();
        }

        /// <summary>
        /// String representation of User.
        /// </summary>
        /// <returns> User Name and type name. </returns>
        public override string ToString()
        {
            return UserName.ToString() + " type of Editor. ";
        }

    }
}
