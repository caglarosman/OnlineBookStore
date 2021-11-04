using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
*  @author  : Osman Çağlar
*  @number  : 152120181033
*  @mail    : cglrr.osman@gmail.com
*  @date    : 01.06.2021
*  @brief   : The purpose of this class is to perform all operations (add, remove, update) related to the data source.
*/
namespace Online_Book_Store
{
    public class DBOperation
    {
        private DBConnection dBConnection;
        //private List<User> userList;

        /// <summary>
        /// The purpose of this constructor function is to use the DBConnection class to connect to the 
        /// database before performing operations on the database.
        /// </summary>
        public DBOperation()
        {
            dBConnection = new DBConnection();
            dBConnection.Connect();
        }

        /// <summary>
        /// It is the function that enables adding new users to our database.
        /// <param name="user"> Stores the user information to be added to the database.</param>
        /// </summary>
        public bool AddUser(User user)
        {
            dBConnection.Open();
            SqlCommand command = new SqlCommand("Insert into Table_Users(fullname,username,mail,password,address,isadmin)values (@fullname,@username,@mail,@password,@address,@isadmin)", dBConnection.Connection);

            command.Parameters.AddWithValue("@fullname", user.FullName);
            command.Parameters.AddWithValue("@username", user.UserName);
            command.Parameters.AddWithValue("@mail", user.EMail);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@address", user.Address);
            command.Parameters.AddWithValue("@isadmin", false);
            command.ExecuteNonQuery();
            dBConnection.Close();

            return true;
        }

        /// <summary>
        /// This is the function used when logging into the system. It checks the user's 
        /// information in the system (username and password) and the information they are trying to log in.
        /// <param name="username> Username entered during login to the system.</param>
        /// <param name="password> Password entered during login to the system.</param>
        /// <returns>This function returns User if the entered information is correct.</returns>
        /// </summary>
        public User CheckUser(string username, string password)
        {
            dBConnection.Open();
            SqlCommand command = new SqlCommand("Select * From Table_Users where username = @username and password = @password", dBConnection.Connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                User user = new User(Convert.ToInt32(dr["id"]), dr["fullname"].ToString(), dr["address"].ToString(), dr["mail"].ToString(), dr["username"].ToString(), dr["password"].ToString(), Convert.ToBoolean(dr["isadmin"].ToString()));
                dBConnection.Close();
                return user;
            }
            else
            {
                dBConnection.Close();
                return null;

            }
        }

        private Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return result;
        }

        public static Bitmap stringToImage(byte[] inputString)
        {
            byte[] imageBytes = inputString;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return new Bitmap(ms);
            }
        }
        protected static Bitmap ByteArrayToBitmap(byte[] blob)
        {
            using (var mStream = new MemoryStream())
            {
                mStream.Write(blob, 0, blob.Length);
                mStream.Position = 0;
                var bm = new Bitmap(mStream);
                return bm;
            }
        }
        private System.Drawing.Image ObjToImg(byte[] obj)
        {
            if (obj == null)
                return null;
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream(obj))
                {
                    return (System.Drawing.Image)bf.Deserialize(ms);
                }
            }
        }
        public static System.Drawing.Image ByteArrayToImage(byte[] _bArray)
        {
            string authorName = "0x433A5C496D616765735C64656E656D656B69746170312E706E67";
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;
            // Convert unicode string into a byte array.  
            byte[] bArray = unicode.GetBytes(authorName);
            if (bArray == null)
                return null;

            System.Drawing.Image newImage;

            try
            {
                using (MemoryStream ms = new MemoryStream(bArray, 0, bArray.Length))
                {
                    ms.Write(bArray, 0, bArray.Length);
                    newImage = System.Drawing.Image.FromStream(ms, true);
                }
            }
            catch (Exception ex)
            {
                newImage = null;

                //Log an error here
            }

            return newImage;
        }

        /// <summary>
        /// Retrieves all book type objects in the database and creates a list.
        /// <returns>This function returns List<Book> containing all book type objects in the database.</returns>
        /// </summary>
        public List<Book> GetBooksFromDatabase()
        {
            dBConnection.Connect();
            dBConnection.Open();

            List<Book> booksFromDatabase = new List<Book>();
            SqlCommand command = new SqlCommand("Select * From Table_Books", dBConnection.Connection);
            SqlDataReader dr = command.ExecuteReader();

            Book book;
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"]);
                string name = dr["name"].ToString();
                float price = (float)Convert.ToDouble(dr["price"]);

                string image = dr["image"].ToString();

                var request = WebRequest.Create(image);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.Image = Bitmap.FromStream(stream);

                    string isbnNumber = dr["isbn"].ToString();
                    string author = dr["author"].ToString();
                    string publisher = dr["publisher"].ToString();
                    string description = dr["description"].ToString();
                    int page = Convert.ToInt32(dr["page"]);
                    book = new Book(/*id, */name, price, pictureBox1.Image, isbnNumber, author, publisher, page, description);
                    booksFromDatabase.Add(book);
                }
            }

            dBConnection.Close();
            return booksFromDatabase;

        }

        /// <summary>
        /// Retrieves all magazine type objects in the database and creates a list.
        /// <returns>This function returns List<Magazine> containing all magazine type objects in the database.</returns>
        /// </summary>
        public List<Magazine> GetMagazinesFromDatabase()
        {
            dBConnection.Connect();
            dBConnection.Open();

            List<Magazine> magazinesFromDatabase = new List<Magazine>();
            SqlCommand command = new SqlCommand("Select * From Table_Magazines", dBConnection.Connection);
            SqlDataReader dr = command.ExecuteReader();

            Magazine magazine;
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"]);
                string name = dr["name"].ToString();
                float price = (float)Convert.ToDouble(dr["price"]);

                string image = dr["image"].ToString();

                var request = WebRequest.Create(image);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.Image = Bitmap.FromStream(stream);

                    string issue = dr["issue"].ToString();
                    string strType = dr["type"].ToString();

                    Magazine.Types type;
                    switch (strType)
                    {
                        case "Actual":
                            type = Magazine.Types.Actual; break;
                        case "News":
                            type = Magazine.Types.News; break;
                        case "Sport":
                            type = Magazine.Types.Sport; break;
                        case "Computer":
                            type = Magazine.Types.Computer; break;
                        case "Technology":
                            type = Magazine.Types.Technology; break;
                        default:
                            type = Magazine.Types.Actual; break;
                    }

                    string description = dr["description"].ToString();


                    magazine = new Magazine(name, price, pictureBox1.Image, issue, type, description);
                    magazinesFromDatabase.Add(magazine);
                }
            }

            dBConnection.Close();
            return magazinesFromDatabase;

        }

        /// <summary>
        /// Retrieves all music-cd type objects in the database and creates a list.
        /// <returns>This function returns List<MusicCD> containing all music-cd type objects in the database.</returns>
        /// </summary>
        public List<MusicCD> GetMusicCDsFromDatabase()
        {
            dBConnection.Connect();
            dBConnection.Open();

            List<MusicCD> musicCDsFromDatabase = new List<MusicCD>();
            SqlCommand command = new SqlCommand("Select * From Table_MusicCDs", dBConnection.Connection);
            SqlDataReader dr = command.ExecuteReader();

            MusicCD musicCD;
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"]);
                string name = dr["name"].ToString();
                float price = (float)Convert.ToDouble(dr["price"]);

                string image = dr["image"].ToString();

                var request = WebRequest.Create(image);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.Image = Bitmap.FromStream(stream);

                    string singer = dr["singer"].ToString();
                    string strType = dr["type"].ToString();

                    MusicCD.Types type;
                    switch (strType)
                    {
                        case "Romance":
                            type = MusicCD.Types.Romance; break;
                        case "Hard Rock":
                            type = MusicCD.Types.HardRock; break;
                        case "Country":
                            type = MusicCD.Types.Country; break;
                        case "Pop":
                            type = MusicCD.Types.Pop; break;
                        case "Heavy Metal":
                            type = MusicCD.Types.HeavyMetal; break;
                        case "Rap":
                            type = MusicCD.Types.Rap; break;
                        default:
                            type = MusicCD.Types.Romance; break;
                    }

                    string description = dr["description"].ToString();


                    musicCD = new MusicCD(name, price, pictureBox1.Image, singer, type, description);
                    musicCDsFromDatabase.Add(musicCD);
                }
            }

            dBConnection.Close();
            return musicCDsFromDatabase;

        }

        /// <summary>
        /// It is a function that allows adding a new book type object to the database.
        /// This function is prepared to be used for the admin panel.
        /// <param name="book"> It is the object that holds the information of the book to be added.</param>
        /// <param name="imageURL">It is the text that holds the address of the website where the cover image of the book to be added.</param>
        /// </summary>
        public void AddBookToDatabase(Book book, string imageURL)
        {
            DBConnection dBConnection = new DBConnection();

            dBConnection.Connect();
            dBConnection.Open();

            List<Book> books = new List<Book>();
            books = GetBooksFromDatabase();

            foreach (var item in books)
            {
                if (item.Name == book.Name)
                {
                    MessageBox.Show("You cannot add a second book with the same name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                Product.ID++;
                SqlCommand command2 = new SqlCommand("UPDATE dbo.Table_Settings SET totalid = @lastid WHERE num = 'totalproduct'; ", dBConnection.Connection);
                command2.Parameters.AddWithValue("@lastid", Product.ID);
                command2.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("Insert into Table_Books(id, name, price, image, description, isbn, author, publisher, page) values(@id, @name, @price, @image, @description, @isbn, @author, @publisher, @page)", dBConnection.Connection);
                command.Parameters.AddWithValue("@id", Product.ID);
                command.Parameters.AddWithValue("@name", book.Name);
                command.Parameters.AddWithValue("@image", imageURL);
                command.Parameters.AddWithValue("@price", book.Price);
                command.Parameters.AddWithValue("@description", book.Description);
                command.Parameters.AddWithValue("@isbn", book.IsbnNumber);
                command.Parameters.AddWithValue("@author", book.Author);
                command.Parameters.AddWithValue("@publisher", book.Publisher);
                command.Parameters.AddWithValue("@page", book.Page);
                command.ExecuteNonQuery();

                MessageBox.Show("Registration successful, please click the BOOKS BUTTON to reload products.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dBConnection.Close();
        }

        /// <summary>
        /// This function allows an existing book object in the database to be updated with new values.
        /// This function is prepared to be used for the admin panel.
        /// <param name="book"> It is the object that holds the information of the book to be updated.</param>
        /// <param name="imageURL">It is the text that holds the address of the website where the cover image of the book to be updated.</param>
        /// </summary>
        public void UpdateBookToDatabase(Book book, string imageURL)
        {
            DBConnection dBConnection = new DBConnection();

            dBConnection.Connect();
            dBConnection.Open();


            try
            {
                if (book.Name.Length <= 0)
                {
                    MessageBox.Show("Name must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("Update Table_Books set name=@name,price=@price,image=@image,description=@description,isbn=@isbn,author=@author,publisher=@publisher,page=@page where name=@name", dBConnection.Connection);

                    //command.Parameters.AddWithValue("@id", Product.ID);
                    command.Parameters.AddWithValue("@name", book.Name);
                    command.Parameters.AddWithValue("@image", imageURL);
                    command.Parameters.AddWithValue("@price", book.Price);
                    command.Parameters.AddWithValue("@description", book.Description);
                    command.Parameters.AddWithValue("@isbn", book.IsbnNumber);
                    command.Parameters.AddWithValue("@author", book.Author);
                    command.Parameters.AddWithValue("@publisher", book.Publisher);
                    command.Parameters.AddWithValue("@page", book.Page);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Update successful, please click the BOOKS BUTTON to reload products.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dBConnection.Close();
        }

        /// <summary>
        /// This function allows deletion of the book type object given as a parameter from the database.
        /// This function is prepared to be used for the admin panel.
        /// <param name="book"> It is the object that holds the information of the book to be deleted.</param>
        /// </summary>
        public void DeleteBookToDatabase(Book book)
        {
            DBConnection dBConnection = new DBConnection();

            dBConnection.Connect();
            dBConnection.Open();

            try
            {
                if (book.Name.Length <= 0)
                {
                    MessageBox.Show("Name must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("Delete from Table_Books where name=@name", dBConnection.Connection);
                    command.Parameters.AddWithValue("@name", book.Name);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dBConnection.Close();
        }
        /////////////////////////////////////////////////////
        
        /// <summary>
        /// It is a function that allows adding a new magazine type object to the database.
        /// This function is prepared to be used for the admin panel.
        /// <param name="magazine"> It is the object that holds the information of the magazine to be added.</param>
        /// <param name="imageURL">It is the text that holds the address of the website where the cover image of the magazine to be added.</param>
        /// </summary>
        public void AddMagazineToDatabase(Magazine magazine, string imageURL)
        {
            DBConnection dBConnection = new DBConnection();

            dBConnection.Connect();
            dBConnection.Open();

            List<Magazine> magazines = new List<Magazine>();
            magazines = GetMagazinesFromDatabase();

            foreach (var item in magazines)
            {
                if (item.Name == magazine.Name)
                {
                    MessageBox.Show("You cannot add a second magazine with the same name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                Product.ID++;
                SqlCommand command2 = new SqlCommand("UPDATE dbo.Table_Settings SET totalid = @lastid WHERE num = 'totalproduct'; ", dBConnection.Connection);
                command2.Parameters.AddWithValue("@lastid", Product.ID);
                command2.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("Insert into Table_Magazines(id, name, price, image, description, issue, type) values(@id, @name, @price, @image, @description, @issue, @type)", dBConnection.Connection);
                command.Parameters.AddWithValue("@id", Product.ID);
                command.Parameters.AddWithValue("@name", magazine.Name);
                command.Parameters.AddWithValue("@image", imageURL);
                command.Parameters.AddWithValue("@price", magazine.Price);
                command.Parameters.AddWithValue("@description", magazine.Description);
                command.Parameters.AddWithValue("@issue", magazine.Issue);

                string type;

                switch (magazine.Type)
                {
                    case Magazine.Types.Actual:
                        type = "Actual"; break;
                    case Magazine.Types.News:
                        type = "News"; break;
                    case Magazine.Types.Sport:
                        type = "Sport"; break;
                    case Magazine.Types.Computer:
                        type = "Computer"; break;
                    case Magazine.Types.Technology:
                        type = "Technology"; break;
                    default:
                        type = "Actual"; break;
                }
                command.Parameters.AddWithValue("@type", type);

                command.ExecuteNonQuery();

                MessageBox.Show("Registration successful, please click the MAGAZINES BUTTON to reload products.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dBConnection.Close();
        }

        /// <summary>
        /// This function allows an existing magazine object in the database to be updated with new values.
        /// This function is prepared to be used for the admin panel.
        /// <param name="magazine"> It is the object that holds the information of the magazine to be updated.</param>
        /// <param name="imageURL">It is the text that holds the address of the website where the cover image of the magazine to be updated.</param>
        /// </summary>
        public void UpdateMagazineToDatabase(Magazine magazine, string imageURL)
        {
            DBConnection dBConnection = new DBConnection();

            dBConnection.Connect();
            dBConnection.Open();


            try
            {
                if (magazine.Name.Length <= 0)
                {
                    MessageBox.Show("Name must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("Update Table_Magazines set name=@name,price=@price,image=@image,description=@description,issue=@issue,type=@type where name=@name", dBConnection.Connection);

                    //command.Parameters.AddWithValue("@id", Product.ID);
                    command.Parameters.AddWithValue("@name", magazine.Name);
                    command.Parameters.AddWithValue("@image", imageURL);
                    command.Parameters.AddWithValue("@price", magazine.Price);
                    command.Parameters.AddWithValue("@description", magazine.Description);
                    command.Parameters.AddWithValue("@issue", magazine.Issue);

                    string type;
                    switch (magazine.Type)
                    {
                        case Magazine.Types.Actual:
                            type = "Actual"; break;
                        case Magazine.Types.News:
                            type = "News"; break;
                        case Magazine.Types.Sport:
                            type = "Sport"; break;
                        case Magazine.Types.Computer:
                            type = "Computer"; break;
                        case Magazine.Types.Technology:
                            type = "Technology"; break;
                        default:
                            type = "Actual"; break;
                    }
                    command.Parameters.AddWithValue("@type", type);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Update successful, please click the MAGAZINES BUTTON to reload products.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dBConnection.Close();
        }

        /// <summary>
        /// This function allows deletion of the magazine type object given as a parameter from the database.
        /// This function is prepared to be used for the admin panel.
        /// <param name="magazine"> It is the object that holds the information of the magazine to be deleted.</param>
        /// </summary>
        public void DeleteMagazineToDatabase(Magazine magazine)
        {
            DBConnection dBConnection = new DBConnection();

            dBConnection.Connect();
            dBConnection.Open();

            try
            {
                if (magazine.Name.Length <= 0)
                {
                    MessageBox.Show("Name must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("Delete from Table_Magazines where name=@name", dBConnection.Connection);
                    command.Parameters.AddWithValue("@name", magazine.Name);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete successful, please click the MAGAZINES BUTTON to reload products.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dBConnection.Close();
        }

        /////////////////////////////////////////////////////

        /// <summary>
        /// It is a function that allows adding a new music-cd type object to the database.
        /// This function is prepared to be used for the admin panel.
        /// <param name="musicCD"> It is the object that holds the information of the music-cd to be added.</param>
        /// <param name="imageURL">It is the text that holds the address of the website where the cover image of the music-cd to be added.</param>
        /// </summary>
        public void AddMusicCDToDatabase(MusicCD musicCD, string imageURL)
        {
            DBConnection dBConnection = new DBConnection();

            dBConnection.Connect();
            dBConnection.Open();

            List<MusicCD> musicCDs = new List<MusicCD>();
            musicCDs = GetMusicCDsFromDatabase();

            foreach (var item in musicCDs)
            {
                if (item.Name == musicCD.Name)
                {
                    MessageBox.Show("You cannot add a second music cd with the same name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                Product.ID++;
                SqlCommand command2 = new SqlCommand("UPDATE dbo.Table_Settings SET totalid = @lastid WHERE num = 'totalproduct'; ", dBConnection.Connection);
                command2.Parameters.AddWithValue("@lastid", Product.ID);
                command2.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("Insert into Table_MusicCDs(id, name, price, image, description, singer, type) values(@id, @name, @price, @image, @description, @singer, @type)", dBConnection.Connection);
                command.Parameters.AddWithValue("@id", Product.ID);
                command.Parameters.AddWithValue("@name", musicCD.Name);
                command.Parameters.AddWithValue("@image", imageURL);
                command.Parameters.AddWithValue("@price", musicCD.Price);
                command.Parameters.AddWithValue("@description", musicCD.Description);
                command.Parameters.AddWithValue("@singer", musicCD.Singer);

                string type;

                switch (musicCD.Type)
                {
                    case MusicCD.Types.Country:
                        type = "Country"; break;
                    case MusicCD.Types.HardRock:
                        type = "Hard Rock"; break;
                    case MusicCD.Types.HeavyMetal:
                        type = "Heavy Metal"; break;
                    case MusicCD.Types.Pop:
                        type = "Pop"; break;
                    case MusicCD.Types.Rap:
                        type = "Rap"; break;
                    case MusicCD.Types.Romance:
                        type = "Romance"; break;
                    default:
                        type = "Country"; break;
                }
                command.Parameters.AddWithValue("@type", type);

                command.ExecuteNonQuery();

                MessageBox.Show("Registration successful, please click the MUSIC CD BUTTON to reload products.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dBConnection.Close();
        }

        /// <summary>
        /// This function allows an existing music-cd object in the database to be updated with new values.
        /// This function is prepared to be used for the admin panel.
        /// <param name="musicCD"> It is the object that holds the information of the music-cd to be updated.</param>
        /// <param name="imageURL">It is the text that holds the address of the website where the cover image of the music-cd to be updated.</param>
        /// </summary>
        public void UpdateMusicCDToDatabase(MusicCD musicCD, string imageURL)
        {
            DBConnection dBConnection = new DBConnection();

            dBConnection.Connect();
            dBConnection.Open();


            try
            {
                if (musicCD.Name.Length <= 0)
                {
                    MessageBox.Show("Name must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("Update Table_MusicCDs set name=@name,price=@price,image=@image,description=@description,singer=@singer,type=@type where name=@name", dBConnection.Connection);

                    //command.Parameters.AddWithValue("@id", Product.ID);
                    command.Parameters.AddWithValue("@name", musicCD.Name);
                    command.Parameters.AddWithValue("@image", imageURL);
                    command.Parameters.AddWithValue("@price", musicCD.Price);
                    command.Parameters.AddWithValue("@description", musicCD.Description);
                    command.Parameters.AddWithValue("@singer", musicCD.Singer);

                    string type;
                    switch (musicCD.Type)
                    {
                        case MusicCD.Types.Country:
                            type = "Country"; break;
                        case MusicCD.Types.HardRock:
                            type = "Hard Rock"; break;
                        case MusicCD.Types.HeavyMetal:
                            type = "Heavy Metal"; break;
                        case MusicCD.Types.Pop:
                            type = "Pop"; break;
                        case MusicCD.Types.Rap:
                            type = "Rap"; break;
                        case MusicCD.Types.Romance:
                            type = "Romance"; break;
                        default:
                            type = "Country"; break;
                    }
                    command.Parameters.AddWithValue("@type", type);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Update successful, please click the MUSIC CD BUTTON to reload products.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dBConnection.Close();
        }

        /// <summary>
        /// This function allows deletion of the music-cd type object given as a parameter from the database.
        /// This function is prepared to be used for the admin panel.
        /// <param name="musicCD"> It is the object that holds the information of the music-cd to be deleted.</param>
        /// </summary>
        public void DeleteMusicCDToDatabase(MusicCD musicCD)
        {
            DBConnection dBConnection = new DBConnection();

            dBConnection.Connect();
            dBConnection.Open();

            try
            {
                if (musicCD.Name.Length <= 0)
                {
                    MessageBox.Show("Name must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("Delete from Table_MusicCDs where name=@name", dBConnection.Connection);
                    command.Parameters.AddWithValue("@name", musicCD.Name);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete successful, please click the MUSIC CD BUTTON to reload products.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dBConnection.Close();
        }
    }
}
