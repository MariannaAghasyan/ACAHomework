using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP
{
    /// <summary>
    /// class Guest represents guest users. 
    /// </summary>
    public class Guest : User
    {
        /// <summary>
        /// Constructor. Contracts User by the given name.
        /// this is complete user.
        /// </summary>
        /// <param name="userName"> Guest name. </param>
        public Guest(String userName)
            : base(userName)
        {
            IsCompleted = true;
        }

        /// <summary>
        /// Constrcats new incomplete guestcuser.
        /// </summary>
        /// <param name="userName"> Guest name. </param>
        /// <returns> New user. </returns>
        public override User IncompleteUser()
        {
            return new Guest(UserName);
        }

        /// <summary>
        /// Լրացնում է օգտագործողին: 
        /// </summary>
        /// <returns> Օգտագործողը դառնում է ամբողջական: </returns>
        public override User Լրացում()
        {
            if (!IsCompleted)
            {
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
            if (!(obj is Guest))
            {
                return false;
            }

            return base.Equals((User)obj);
        }

        /// <summary>
        /// Calculate HashCode for User
        /// </summary>
        /// <returns> HashCode of User. </returns>
        public override Int32 GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// String representation of User.
        /// </summary>
        /// <returns> User Name and type name. </returns>
        public override String ToString()
        {
            return UserName.ToString() + " type of Guest. ";
        }

        
    }
}
