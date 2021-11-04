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
*  @brief   : The purpose of this class is to ensure the continuity of the program for different types of SQL 
              by applying the strategy design pattern.
*/
namespace Online_Book_Store
{
    public class SQLCreator
    {

        private IDatabaseConnection _IDataBaseConnection;

        /// <summary>
        /// It is the constructor function that determines the strategy to be used according to the SQL type.
        /// </summary>
        public SQLCreator(IDatabaseConnection chosenConnectionType)
        {
            _IDataBaseConnection = chosenConnectionType;
        }

        /// <summary>
        /// It is the function that creates the connection string and object.
        /// </summary>
        public void Connect()
        {
            _IDataBaseConnection.Connect();
        }

        /// <summary>
        /// It is the function that opens the connection according to the SQL type.
        /// </summary>
        public void Open()
        {
            _IDataBaseConnection.Open();

        }

        /// <summary>
        /// It is the function that closes the connection according to the SQL type.
        /// </summary>
        public void Close()
        {
            _IDataBaseConnection.Close();

        }

    }
}
