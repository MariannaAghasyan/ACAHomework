using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP
{
    /// <summary>
    /// Enviroment where users can login/logout, storing login log
    /// </summary>
    public class Environment
    {
        /// <summary>
        /// Predetermined list of userս
        /// </summary>
        public static Dictionary<String, User> users = new Dictionary<string, User>();

        /// <summary>
        /// Authorization actions log.
        /// </summary>
        public static String log = "\t\t Log \r\n";


        /// <summary>
        /// User's commands
        /// </summary>
        public struct Commands
        {
            /// <summary>
            /// print message
            /// </summary>
            public const String Print = "Print";

            /// <summary>
            /// logout user
            /// </summary>
            public const String Exit = "Exit";

        }
    }
}
