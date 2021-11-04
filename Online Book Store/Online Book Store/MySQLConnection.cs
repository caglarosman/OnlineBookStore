using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
*  @author  : Osman Çağlar
*  @number  : 152120181033
*  @mail    : cglrr.osman@gmail.com
*  @date    : 28.05.2021
*  @brief   : The purpose of this class is to establish the connection to the data source (MySQL), to open or close the connection.
*/
namespace Online_Book_Store
{
    public class MySQLConnection : IDatabaseConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;

        public MySQLConnection()
        {
            Initialize();
        }

        /// <summary>
        /// The task of this constructor function is to define the link text.  
        /// </summary>
        private void Initialize()
        {
            server = "localhost";
            database = "connectcsharptomysql";
            uid = "username";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

           
        }

        public void Connect()
        {
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// It is the function that opens the connection.
        /// </summary>
        public void Open()
        {
            connection.Open();
        }

        /// <summary>
        /// It is the function for closing the connection.
        /// </summary>
        public void Close()
        {
            connection.Close();
        }
    }
}
