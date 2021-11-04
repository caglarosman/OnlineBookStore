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
*  @brief   : The purpose of this class is to prepare a common interface for connections to different types of SQL.
*/
namespace Online_Book_Store
{
    public interface IDatabaseConnection
    {
        void Connect();

        /// <summary>
        /// This will be used to open a connection to the data source.
        /// </summary>
        void Open();

        /// <summary>
        /// This will be used to close the connection.
        /// </summary>
        void Close();
    }
}
