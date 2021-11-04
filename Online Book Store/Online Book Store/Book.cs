using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Eddy Ngabo Shami 
/// 152120181093
/// 25.05.2021
namespace Online_Book_Store
{
    public class Book : Product
    {
        /// Attributes for the book class.
        private string isbnNumber;
        private string author;
        private string publisher;
        private int page;
        /// <Getter and Setter of the define Attributes.>
        /// These function are the methods called getter and setter.
        /// </Getter and Setter of the define Attributes.>
        public string IsbnNumber { get => isbnNumber; set => isbnNumber = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int Page { get => page; set => page = value; }

        public Book()
        {
        }
        public Book(string name, float price, Image image, string isbnNumber, string author, string publisher, int page, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Image = image;
            this.IsbnNumber = isbnNumber;
            this.Author = author;
            this.Publisher = publisher;
            this.Page = page;
            this.Description = description;
        }
    }
}
