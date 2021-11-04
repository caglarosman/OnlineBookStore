using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
*  @author  : Furkan Taşkın
*  @number  : 152120181029
*  @mail    : danyaljet13@gmail.com
*  @date    : 02.06.2021
*  @brief   : In this class, I created the user information the program needs.
*/

namespace Online_Book_Store
{
    public class User
    {
        /// <summary>
        /// Those ones are attributes. 
        /// </summary>
        private int userID;
        private string fullName;
        private string userName;
        private string eMail;
        private string password;
        private string address;
        private bool isAdmin;

        public static int ID = 1;

        /// <summary>
        /// Those ones are get and set methods. 
        /// </summary>
        public int UserID { get => userID; set => userID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public User()
        {

        }
        /// <summary>
        /// Parameter constructor. 
        /// </summary>
        public User(int id, string fullName, string address, string eMail, string userName, string password, bool isAdmin)
        {
            this.userID = id;
            this.FullName = fullName;
            this.Address = address;
            this.EMail = eMail;
            this.UserName = userName;
            this.Password = password;
            this.IsAdmin = isAdmin;
        }
    }
}
