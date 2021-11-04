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
    public class Magazine:Product
    {
        /// Attributes for the book class.

        private string issue;
        private Types type;
        private string author;
        /// <Getter and Setter of the define Attributes.>
        /// These function are the methods called getter and setter.
        /// </Getter and Setter of the define Attributes.>
        public string Issue { get => issue; set => issue = value; }
        public Types Type { get => type; set => type = value; }
        public string Author { get => author; set => author = value; }

        public enum Types{
            Actual,
            News, 
            Sport, 
            Computer, 
            Technology
        }
        /// <Default Consturctor>
        /// 
        /// </Default Constructor>
        public Magazine()
        {

        }
        /// <parametrized constructor>
        /// 
        /// </parametrized constructor>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="image"></param>
        /// <param name="issue"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        public Magazine(string name, float price, Image image, string issue, Types type, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Image = image;
            this.Issue = issue;
            this.Type = type;
            this.Description = description;
        }
    }
}
