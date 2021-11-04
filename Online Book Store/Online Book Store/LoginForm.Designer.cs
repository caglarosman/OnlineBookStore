
namespace Online_Book_Store
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctLogin = new System.Windows.Forms.PictureBox();
            this.lblSignup = new System.Windows.Forms.Label();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblLine = new System.Windows.Forms.Label();
            this.pctPasswordShow = new System.Windows.Forms.PictureBox();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.lblCENG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPasswordShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.txtUsername.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(425, 166);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 29);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(425, 202);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(118, 104);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(175, 160);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 4;
            this.pctLogo.TabStop = false;
            // 
            // pctLogin
            // 
            this.pctLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLogin.Image = ((System.Drawing.Image)(resources.GetObject("pctLogin.Image")));
            this.pctLogin.Location = new System.Drawing.Point(425, 237);
            this.pctLogin.Name = "pctLogin";
            this.pctLogin.Size = new System.Drawing.Size(253, 59);
            this.pctLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogin.TabIndex = 6;
            this.pctLogin.TabStop = false;
            this.pctLogin.Click += new System.EventHandler(this.pctLogin_Click);
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignup.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignup.ForeColor = System.Drawing.Color.White;
            this.lblSignup.Location = new System.Drawing.Point(479, 299);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(162, 20);
            this.lblSignup.TabIndex = 0;
            this.lblSignup.Text = "Create an account";
            this.lblSignup.Click += new System.EventHandler(this.lblSignup_Click);
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(702, 9);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(35, 35);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctExit.TabIndex = 7;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // pctMinimize
            // 
            this.pctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimize.Image")));
            this.pctMinimize.Location = new System.Drawing.Point(661, 17);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(35, 35);
            this.pctMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctMinimize.TabIndex = 8;
            this.pctMinimize.TabStop = false;
            this.pctMinimize.Click += new System.EventHandler(this.pctMinimize_Click);
            // 
            // notify
            // 
            this.notify.Text = "notifyIcon1";
            this.notify.Visible = true;
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine.Location = new System.Drawing.Point(351, 113);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(2, 225);
            this.lblLine.TabIndex = 9;
            // 
            // pctPasswordShow
            // 
            this.pctPasswordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctPasswordShow.Image = ((System.Drawing.Image)(resources.GetObject("pctPasswordShow.Image")));
            this.pctPasswordShow.Location = new System.Drawing.Point(684, 202);
            this.pctPasswordShow.Name = "pctPasswordShow";
            this.pctPasswordShow.Size = new System.Drawing.Size(28, 24);
            this.pctPasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPasswordShow.TabIndex = 10;
            this.pctPasswordShow.TabStop = false;
            this.pctPasswordShow.Click += new System.EventHandler(this.pctPasswordShow_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.FlatAppearance.BorderSize = 0;
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.Location = new System.Drawing.Point(597, 237);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(44, 27);
            this.btnEmpty.TabIndex = 1;
            this.btnEmpty.UseVisualStyleBackColor = true;
            // 
            // lblCENG
            // 
            this.lblCENG.AutoSize = true;
            this.lblCENG.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCENG.ForeColor = System.Drawing.Color.White;
            this.lblCENG.Location = new System.Drawing.Point(150, 277);
            this.lblCENG.Name = "lblCENG";
            this.lblCENG.Size = new System.Drawing.Size(150, 66);
            this.lblCENG.TabIndex = 11;
            this.lblCENG.Text = "  CENG\r\nBookstore";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(746, 490);
            this.Controls.Add(this.lblCENG);
            this.Controls.Add(this.pctPasswordShow);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.pctMinimize);
            this.Controls.Add(this.pctExit);
            this.Controls.Add(this.lblSignup);
            this.Controls.Add(this.pctLogin);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnEmpty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPasswordShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctLogin;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.PictureBox pctPasswordShow;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Label lblCENG;
    }
}

