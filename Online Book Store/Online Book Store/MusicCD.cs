using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Eddy Ngabo Shami 
/// 152120181093
/// 25.05.2021
namespace Online_Book_Store
{
    public class MusicCD : Product
    {
        /// Attributes for the book class.

        private string singer;
        private Types type;
        /// <Getter and Setter of the define Attributes.>
        /// These function are the methods called getter and setter.
        /// </Getter and Setter of the define Attributes.>
        public string Singer { get => singer; set => singer = value; }
        public Types Type { get => type; set => type = value; }
        public enum Types /// declaring the enum type for the different type of musics.
        {
            Romance,
            HardRock,
            Country,
            Pop,
            HeavyMetal,
            Rap
        }
        /// <parametrized constructor>
        /// 
        /// </parametrized constructor>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="image"></param>
        /// <param name="singer"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        public MusicCD(string name, float price, Image image, string singer, Types type, string description)
        {

            this.Name = name;
            this.Price = price;
            this.Image = image;
            this.Singer = singer;
            this.Type = type;
            this.Description = description;
        }
    }
}
