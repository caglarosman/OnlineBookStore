using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
*  @author  : Furkan Taşkın
*  @number  : 152120181029
*  @mail    : danyaljet13@gmail.com
*  @date    : 02.06.2021
*  @brief   : The purpose of this form is to provide the user with a page where they can sign up with their information.
*/

namespace Online_Book_Store
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If the user doesn't have an active account, he or she can join the application by clicking this picture. When he/she clicks this picture, his/her information is added to the database.
        /// </summary>
        private void pctSignup_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text.Length > 0 && txtUsername.Text.Length > 0)
            {
                if (txtPassword.Text == txtConfirmPassword.Text) 
                {
                    User user = new User(User.ID, txtFullname.Text, txtAddress.Text, txtMail.Text, txtUsername.Text, txtPassword.Text, false);

                    DBOperation dBOperation = new DBOperation();

                    if (dBOperation.AddUser(user))
                    {
                        notify = new NotifyIcon();
                        notify.BalloonTipText = "Registration Successful!";
                        notify.BalloonTipTitle = "SUCCESS";
                        notify.Visible = true;
                        notify.Icon = SystemIcons.Information;
                        notify.BalloonTipIcon = ToolTipIcon.Info;
                        notify.ShowBalloonTip(1500);
                    }
                }
                else // if passwords doesn't match
                {
                    MessageBox.Show("Passwords did not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else // if username and fullname don't bigger than zero.
            {
                MessageBox.Show("Username or full name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Close();
            Application.OpenForms["LoginForm"].Show();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Functions that delete the words "Full Name", "Username", "Mail" "Password", "Re-Password" and "Address" written in the textboxes when the user enters on the textboxes.
        /// </summary>
        private void txtFullname_Enter(object sender, EventArgs e)
        {
            if (txtFullname.Text == "Full Name")
            {
                txtFullname.Text = "";
                txtFullname.ForeColor = Color.White;
            }
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }
        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Mail")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.White;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.PasswordChar = '*';
            }
        }
        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Re-Password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = Color.White;
                txtConfirmPassword.PasswordChar = '*';
            }
        }
        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Functions that bring back the words "Full Name", "Username", "Mail" "Password", "Re-Password" and "Address" written in the textboxes when the user leaves the textboxes.
        /// </summary>
        private void txtFullname_Leave(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                txtFullname.Text = "Full Name";
                txtFullname.ForeColor = Color.Silver;
            }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Mail";
                txtMail.ForeColor = Color.Silver;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }
        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Text = "Re-Password";
                txtConfirmPassword.ForeColor = Color.Silver;
            }
        }
        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Address";
                txtAddress.ForeColor = Color.Silver;
            }
        }

        /// <summary>
        /// If the user wants to see his or her password without "*", by clicking on this picture he/she can make his/her password visible and turn it back. 
        /// </summary>
        private void pctPasswordShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
            else if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';

            }
        }
    }
}
