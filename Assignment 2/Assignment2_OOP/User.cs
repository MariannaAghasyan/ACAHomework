using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP
{
    /// <summary>
    /// class User represents users.
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// Constructor. Contracts User by the given name.
        /// </summary>
        /// <param name="userName">User's name</param>
        protected User(String userName)
        {
            UserName = userName;
            IsCompleted = false;
        }

        /// <summary>
        /// User's name. 
        /// </summary>
        public String UserName
        {
            get;
            private set;
        }

        /// <summary>
        /// User's completeness property
        /// </summary>
        protected Boolean IsCompleted
        {
            get;
            set;
        }

        /// <summary>
        /// Constrcats new incomplete user.
        /// User have only name.
        /// Should bew implimented in child.
        /// </summary>
        /// <returns> New user </returns>
        public abstract User IncompleteUser();

        /// <summary>
        /// Լրացնում է օգտագործողին: 
        /// Մանրամասն կիրականացվի ժառանգներում(ընդլայնումներում):
        /// </summary>
        /// <returns> Նոր ամբողջական օգագործող: </returns>
        public abstract User Լրացում();

        /// <summary>
        /// It's not correct check equality without override.
        /// Checks the equality of the current user with the given one.
        /// </summary>
        /// <param name="obj"> User to check equality with. </param>
        /// <returns> True if all the corresponding elements are equal. </returns>
        public override Boolean Equals(object obj)
        {
            if (!(obj is User))
            {
                return false;
            }

            if (UserName != ((User)obj).UserName)
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
            return base.GetHashCode() + UserName.GetHashCode();
        }

        /// <summary>
        /// String representation of User.
        /// </summary>
        /// <returns> User Name and type name. </returns>
        public override String ToString()
        {
            return UserName.ToString() + " type of User" ;
        }

        /// <summary>
        /// Equality of two users.
        /// </summary>
        /// <param name="userA"> First user </param>
        /// <param name="userB"> Second user </param>
        /// <returns> true if users are equal. </returns>
        public static Boolean operator == (User userA, User userB)
        {
            return userA.Equals(userB);
        }

        /// <summary>
        /// Non equality of users.
        /// </summary>
        /// <param name="userA"> First user </param>
        /// <param name="userB"> Second user </param>
        /// <returns> true if users aren't equal. </returns>
        public static Boolean operator != (User userA, User userB)
        {
            return !userA.Equals(userB);
            
        }
    }
}
