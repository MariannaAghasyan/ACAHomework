using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP
{
    /// <summary>
    /// class Admin represents admin users.
    /// </summary>
    public class Admin : Editor
    {
        /// <summary>
        /// Constructor. Contracts User by the given name.
        /// This is incomplete user.
        /// </summary>
        /// <param name="userName"> user's name. </param>
        protected Admin(String userName)
            : base(userName)
        {
            IsCompleted = false;
        }

        /// <summary>
        /// Constructor. Contracts User by the given name and password.
        /// this is complete user.
        /// </summary>
        /// <param name="userName"> user's name </param>
        /// <param name="password"> user's password </param>
        /// <param name="secretKey"> user's secret key </param>
        public Admin(String userName, String password, String secretKey)
            : base (userName,password)
        {
            SecretKey = secretKey;
            IsCompleted = true;
        }

        /// <summary>
        /// Admin's secret key
        /// </summary>
        public String SecretKey
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
            return new Admin(UserName);
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
                Console.WriteLine("Please input Secret Key for Admin.");
                Console.Write("Secret Key : ");
                SecretKey = Console.ReadLine();

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
            if (!(obj is Admin))
            {
                return false;
            }

            if (!base.Equals((Editor)obj))
            {
                return false;
            }

            if (SecretKey != ((Admin)obj).SecretKey)
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
            return base.GetHashCode() + SecretKey.GetHashCode();
        }

        /// <summary>
        /// String representation of User.
        /// </summary>
        /// <returns> User Name and type name. </returns>
        public override string ToString()
        {
            return UserName.ToString() + " type of Admin. ";
        }
    }
}
