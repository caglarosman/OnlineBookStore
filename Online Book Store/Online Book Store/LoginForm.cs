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
*  @brief   : The purpose of this form is to provide the user with a page where they can log in with their information.
*/

namespace Online_Book_Store
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If the user does not have an active account, he or she can open a new account by clicking this label. 
        /// </summary>
        private void lblSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
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
        /// If the user have an active account, he or she can acces the main menu by clicking this picture. 
        /// </summary>
        private void pctLogin_Click(object sender, EventArgs e)
        {
            DBOperation dBOperation = new DBOperation();
            User user = dBOperation.CheckUser(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                this.Hide();
                notify = new NotifyIcon();
                notify.BalloonTipText = "Login Successful!";
                notify.BalloonTipTitle = "SUCCESS";
                notify.Visible = true;
                notify.Icon = SystemIcons.Information;
                notify.BalloonTipIcon = ToolTipIcon.Info;
                notify.ShowBalloonTip(1500);

                MainForm mainForm = new MainForm(user);
                mainForm.Show();

                if(user.IsAdmin)
                    Application.OpenForms["MainForm"].Controls["panelLeft"].Controls["btnAdminPanel"].Visible=true;
                else
                    Application.OpenForms["MainForm"].Controls["panelLeft"].Controls["btnAdminPanel"].Visible = false;

            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Functions that delete the words "Username" and "Password" written in the textboxes when the user enters on the textboxes.
        /// </summary>
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
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

        /// <summary>
        /// Functions that bring back the words "Username" and "Password" written in the textboxes when the user leaves the textboxes.
        /// </summary>
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
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

        /// <summary>
        /// If the user wants to see his or her password without "*", by clicking on this picture he/she can make his/her password visible and turn it back. 
        /// </summary>
        private void pctPasswordShow_Click(object sender, EventArgs e)
        {

            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
            }
            else if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
        }
    }
}
