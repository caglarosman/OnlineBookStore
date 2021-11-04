using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
*  @author  : Osman Çağlar
*  @number  : 152120181033
*  @mail    : cglrr.osman@gmail.com
*  @date    : 28.05.2021
*  @brief   : The purpose of this class is to establish the connection to the data source (MSSQL), to open or close the connection.
*/
namespace Online_Book_Store
{
    class DBConnection : IDatabaseConnection
    {
        private SqlConnection connection;
        public SqlConnection Connection { get => connection; set => connection = value; }

        /// <summary>
        /// The task of this constructor function is to define the link text.  
        /// </summary>
        public void Connect()
        {
            var connectionString = @"Data Source=sql5097.site4now.net;Initial Catalog=db_a74d9f_oop2database;Persist Security Info=True;User ID=db_a74d9f_oop2database_admin;Password=oop2database";
            connection = new SqlConnection(connectionString);
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
