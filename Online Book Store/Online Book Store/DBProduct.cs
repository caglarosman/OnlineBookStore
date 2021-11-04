using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
*  @author  : Osman Çağlar
*  @number  : 152120181033
*  @mail    : cglrr.osman@gmail.com
*  @date    : 01.06.2021
*  @brief   : The purpose of this class is to keep static lists. We used it as our virtual database in code.
*/
namespace Online_Book_Store
{
    public static class DBProduct
    {
        public static List<Book> bookList;
        public static List<Magazine> magazineList;
        public static List<MusicCD> musicCDList;

        /// <summary>
        /// The purpose of this static constructor function is to sample lists only once when the program runs.
        /// </summary>
        static DBProduct()
        {
            bookList = new List<Book>();
            magazineList = new List<Magazine>();
            musicCDList = new List<MusicCD>();
        }

        /// <summary>
        /// The purpose of this function is to get all the objects of type book from the data source with 
        /// the help of the DBOperation class and add them to a list.
        /// </summary>
        public static void UpdateBooksFromDatabase()
        {
            DBOperation dBOperation = new DBOperation();
            bookList = dBOperation.GetBooksFromDatabase();
        }

        /// <summary>
        /// The purpose of this function is to get all the objects of type magazine from the data source with 
        /// the help of the DBOperation class and add them to a list.
        /// </summary>
        public static void UpdateMagazinesFromDatabase()
        {
            DBOperation dBOperation = new DBOperation();
            magazineList = dBOperation.GetMagazinesFromDatabase();
        }

        /// <summary>
        /// The purpose of this function is to get all the objects of type music-cd from the data source with 
        /// the help of the DBOperation class and add them to a list.
        /// </summary>
        public static void UpdateMusicCDsFromDatabase()
        {
            DBOperation dBOperation = new DBOperation();
            musicCDList = dBOperation.GetMusicCDsFromDatabase();
        }
    }
}
