using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <@autor>
/// Student No: 152120181097
/// Name Surname: Abdul Hannan Ayubi
/// Date: 29.05.2021
namespace Online_Book_Store
{

    public partial class AdminPanelForm : Form
    {
        /// <Admin panel form>
        ///  The user paramter is taken for showing user information in the admin panel...
        ///  Insidte The admin panel form we declare labels and inside labels we show the user 
        ///  information.
        /// </Admin panel form>
        public AdminPanelForm(User user)
        {
            InitializeComponent();

            this.labelName.Text = user.FullName; /// this is for showing user name.
            this.labelUsername.Text = user.UserName;/// this is for showing user is username.
        }
        /// <Time>
        /// This function is timer's default function and we declare time inside the admin 
        /// </Time>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm tt"); /// label of time
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy"); /// label of the Date
        }
        /// <Logut Picturebox function>
        /// This function is for logginout the from the admin panel.
        /// </Logut Picturebox function>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctLogout_Click(object sender, EventArgs e)
        {
            ///In here we show the our orginal login panel...
            Application.OpenForms["LoginForm"].Show();
            /// closing the our panel...
            this.Close();
        }
        /// <Add function for book item.>
        /// This function is button click function and with this we add the book item inside the SQL
        /// </Add function for book item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ///Condition for the Image URL of book.
            if (txtImageURL.Text.Length <= 0)
            {
                MessageBox.Show("URL must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /// using defined class of DBOperations.
            DBOperation dBOperation = new DBOperation();
            var request = WebRequest.Create(txtImageURL.Text);
            /// getting response from webrequest...
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Bitmap.FromStream(stream);
                Book book = new Book(txtBookName.Text, (float)Math.Round(Convert.ToDouble(txtPrice.Text), 2), pictureBox.Image,
                    txtISBN.Text, txtAuthor.Text, txtPublisher.Text, Convert.ToInt32(txtPage.Text), txtDescription.Text);

                dBOperation.AddBookToDatabase(book, txtImageURL.Text);
            }
        }
        /// <Clear function for book item.>
        /// This function is button click function and with this we clear the book item inside the SQL
        /// </Clear function for book item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAuthor.Text = string.Empty;
            txtBookName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtImageURL.Text = string.Empty;
            txtPage.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtPublisher.Text = string.Empty;
        }
        /// <Update function for book item.>
        /// This function is button click function and with this we update the book item inside the SQL
        /// </Update function for book item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ///Condition for the Image URL of book for updating the item the must condition is this one.
            if (txtImageURL.Text.Length <= 0)
            {
                MessageBox.Show("URL must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /// Default using class of DBoperations.
            DBOperation dBOperation = new DBOperation();
            var request = WebRequest.Create(txtImageURL.Text);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Bitmap.FromStream(stream);
                Book book = new Book(txtBookName.Text, (float)Convert.ToDouble(txtPrice.Text), pictureBox.Image,
                    txtISBN.Text, txtAuthor.Text, txtPublisher.Text, Convert.ToInt32(txtPage.Text), txtDescription.Text);

                dBOperation.UpdateBookToDatabase(book, txtImageURL.Text);
            }
        }
        /// <Delete function for book item.>
        /// This function is button click function and with this we delete the book item inside the SQL
        /// </Delete function for book item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBOperation dBOperation = new DBOperation();
            PictureBox pictureBox = new PictureBox();
            Book book = new Book(txtBookName.Text, 0, pictureBox.Image,
                " ", " ", " ", 0, " ");
            dBOperation.DeleteBookToDatabase(book); /// using default delete operation from DBOperation class.
        }
        /// <Returning to the main menu>
        /// The Click function provide to return back to the main menu.
        /// </Returning to the main menu>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["MainForm"].Show(); /// showing our form.
        }

        /// <Add function for Magaize item.>
        /// This function is button click function and with this we add the magazine item inside the SQL
        /// </Add function for book item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMagazineAdd_Click(object sender, EventArgs e)
        {
            ///Condition for the Image URL of Magazine.
            if (txtMagazineImageURL.Text.Length <= 0)
            {
                MessageBox.Show("URL must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBOperation dBOperation = new DBOperation();
            var request = WebRequest.Create(txtMagazineImageURL.Text);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Bitmap.FromStream(stream);
                Magazine magazine;
                switch (cmbMagazineType.SelectedItem.ToString()) /// using switch case because of the magazine types.
                {
                    case "Actual":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.Actual, txtMagazineDescription.Text);
                        dBOperation.AddMagazineToDatabase(magazine, txtMagazineImageURL.Text);
                        break;
                    case "News":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.News, txtMagazineDescription.Text);
                        dBOperation.AddMagazineToDatabase(magazine, txtMagazineImageURL.Text);
                        break;
                    case "Sport":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.Sport, txtMagazineDescription.Text);
                        dBOperation.AddMagazineToDatabase(magazine, txtMagazineImageURL.Text);
                        break;
                    case "Computer":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.Computer, txtMagazineDescription.Text);
                        dBOperation.AddMagazineToDatabase(magazine, txtMagazineImageURL.Text);
                        break;
                    case "Technology":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.Technology, txtMagazineDescription.Text);
                        dBOperation.AddMagazineToDatabase(magazine, txtMagazineImageURL.Text);
                        break;

                }

            }
        }
        /// <Delete function for Magazine item.>
        /// This function is button click function and with this we delete the book item inside the SQL
        /// </Delete function for Magazine item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMagazineDelete_Click(object sender, EventArgs e)
        {
            DBOperation dBOperation = new DBOperation(); /// creation new operations 

            PictureBox pictureBox = new PictureBox(); /// creating default picturebox to send it inside the magazine.

            Magazine magazine = new Magazine(txtMagazineName.Text, 0, pictureBox.Image,
                " ", Magazine.Types.Technology, " ");

            dBOperation.DeleteMagazineToDatabase(magazine); /// using default delete function from the magazine Database.
        }
        /// <Update function for Magazine item.>
        /// This function is button click function and with this we update the magazine item inside the SQL
        /// </Update function for Magazine item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMagazineUpdate_Click(object sender, EventArgs e)
        {
            ///default condition for getting image URL
            if (txtMagazineImageURL.Text.Length <= 0)
            {
                MessageBox.Show("URL must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBOperation dBOperation = new DBOperation();
            var request = WebRequest.Create(txtImageURL.Text);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Bitmap.FromStream(stream);
                Magazine magazine;
                switch (cmbMagazineType.SelectedItem.ToString())///using switch case for the different type of the magazine.
                {
                    case "Actual":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.Actual, txtMagazineDescription.Text);
                        dBOperation.UpdateMagazineToDatabase(magazine, txtImageURL.Text);
                        break;
                    case "News":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.News, txtMagazineDescription.Text);
                        dBOperation.UpdateMagazineToDatabase(magazine, txtImageURL.Text);
                        break;
                    case "Sport":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.Sport, txtMagazineDescription.Text);
                        dBOperation.UpdateMagazineToDatabase(magazine, txtImageURL.Text);
                        break;
                    case "Computer":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.Computer, txtMagazineDescription.Text);
                        dBOperation.UpdateMagazineToDatabase(magazine, txtImageURL.Text);
                        break;
                    case "Technology":
                        magazine = new Magazine(txtMagazineName.Text, (float)Math.Round(Convert.ToDouble(txtMagazinePrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMagazineIssue.Text, Magazine.Types.Technology, txtMagazineDescription.Text);
                        dBOperation.UpdateMagazineToDatabase(magazine, txtImageURL.Text);
                        break;

                }
            }
        }
        /// <Clear function for Magazine item.>
        /// This function is button click function and with this we clear the magazine item inside the SQL
        /// </Clear function for Magazine item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMagazineClear_Click(object sender, EventArgs e)
        {
            txtMagazineDescription.Text = string.Empty;
            txtMagazineImageURL.Text = string.Empty;
            txtMagazineIssue.Text = string.Empty;
            txtMagazineName.Text = string.Empty;
            txtMagazinePrice.Text = string.Empty;
        }
        /// <Add function for MusicCD item.>
        /// This function is button click function and with this we add the MusicCD item inside the SQL
        /// </Add function for MusicCD item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicCDAdd_Click(object sender, EventArgs e)
        {
            /// default textbox conditon to get the URL image.
            if (txtMusicCDImageURL.Text.Length <= 0)
            {
                MessageBox.Show("URL must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBOperation dBOperation = new DBOperation();
            var request = WebRequest.Create(txtMusicCDImageURL.Text);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Bitmap.FromStream(stream);
                MusicCD musicCD;
                switch (cmbMusicCDType.SelectedItem.ToString()) ///using switch case for the different type of the musicCD..
                {

                    case "Country":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.Country, txtMusicCDDescription.Text);
                        dBOperation.AddMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Hard Rock":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.HardRock, txtMusicCDDescription.Text);
                        dBOperation.AddMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Heavy Metal":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.HeavyMetal, txtMusicCDDescription.Text);
                        dBOperation.AddMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Pop":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.Pop, txtMusicCDDescription.Text);
                        dBOperation.AddMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Rap":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.Rap, txtMusicCDDescription.Text);
                        dBOperation.AddMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Romance":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.Romance, txtMusicCDDescription.Text);
                        dBOperation.AddMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;

                }
            }
        }
        /// <Update function for MusicCD item.>
        /// This function is button click function and with this we update the MusicCD item inside the SQL
        /// </Update function for MusicCD item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicCDUpdate_Click(object sender, EventArgs e)
        {
            if (txtMusicCDImageURL.Text.Length <= 0)
            {
                MessageBox.Show("URL must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBOperation dBOperation = new DBOperation();
            var request = WebRequest.Create(txtMusicCDImageURL.Text);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Bitmap.FromStream(stream);
                MusicCD musicCD;
                switch (cmbMusicCDType.SelectedItem.ToString()) /// using switch case for the different type of MusicCD.
                {
                    case "Country":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.Country, txtMusicCDDescription.Text);
                        dBOperation.UpdateMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Hard Rock":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.HardRock, txtMusicCDDescription.Text);
                        dBOperation.UpdateMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Heavy Metal":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.HeavyMetal, txtMusicCDDescription.Text);
                        dBOperation.UpdateMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Pop":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.Pop, txtMusicCDDescription.Text);
                        dBOperation.UpdateMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Rap":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.Rap, txtMusicCDDescription.Text);
                        dBOperation.UpdateMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                    case "Romance":
                        musicCD = new MusicCD(txtMusicCDName.Text, (float)Math.Round(Convert.ToDouble(txtMusicCDPrice.Text), 2/* * 100f*/) /*/ 100f*/, pictureBox.Image,
                    txtMusicCDSinger.Text, MusicCD.Types.Romance, txtMusicCDDescription.Text);
                        dBOperation.UpdateMusicCDToDatabase(musicCD, txtMusicCDImageURL.Text);
                        break;
                }
            }
        }
        /// <Clear function for MusicCD item.>
        /// This function is button click function and with this we clear the MusicCD item inside the SQL
        /// </Clear function for MusicCD item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicCDClear_Click(object sender, EventArgs e)
        {
            txtMusicCDDescription.Text = string.Empty;
            txtMusicCDImageURL.Text = string.Empty;
            txtMusicCDName.Text = string.Empty;
            txtMusicCDPrice.Text = string.Empty;
            txtMusicCDSinger.Text = string.Empty;
        }
        /// <Delete function for MusicCD item.>
        /// This function is button click function and with this we delete the MusicCD item inside the SQL
        /// </Delete function for MusicCD item.>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicCDDelete_Click(object sender, EventArgs e)
        {
            DBOperation dBOperation = new DBOperation();

            PictureBox pictureBox = new PictureBox();

            MusicCD musicCD = new MusicCD(txtMusicCDName.Text, 0, pictureBox.Image,
                    " ", MusicCD.Types.Romance, " ");

            dBOperation.DeleteMusicCDToDatabase(musicCD);
        }
    }
}
