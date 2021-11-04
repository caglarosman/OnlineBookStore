
namespace Online_Book_Store
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pctLogout = new System.Windows.Forms.PictureBox();
            this.btnMyCart = new System.Windows.Forms.Button();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pctAvatar = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pctSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.pnlRed3 = new System.Windows.Forms.Panel();
            this.pnlRed2 = new System.Windows.Forms.Panel();
            this.pnlRed1 = new System.Windows.Forms.Panel();
            this.flwPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.btnAdminPanel);
            this.panelLeft.Controls.Add(this.lblDate);
            this.panelLeft.Controls.Add(this.lblTime);
            this.panelLeft.Controls.Add(this.pctLogout);
            this.panelLeft.Controls.Add(this.btnMyCart);
            this.panelLeft.Controls.Add(this.panelUserInfo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(295, 748);
            this.panelLeft.TabIndex = 13;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnAdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminPanel.Image")));
            this.btnAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminPanel.Location = new System.Drawing.Point(0, 324);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(295, 66);
            this.btnAdminPanel.TabIndex = 7;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Visible = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.lblDate.Location = new System.Drawing.Point(120, 713);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 22);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "label1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.lblTime.Location = new System.Drawing.Point(120, 682);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 22);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "label1";
            // 
            // pctLogout
            // 
            this.pctLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLogout.Image = ((System.Drawing.Image)(resources.GetObject("pctLogout.Image")));
            this.pctLogout.Location = new System.Drawing.Point(7, 672);
            this.pctLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctLogout.Name = "pctLogout";
            this.pctLogout.Size = new System.Drawing.Size(95, 74);
            this.pctLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogout.TabIndex = 4;
            this.pctLogout.TabStop = false;
            this.pctLogout.Click += new System.EventHandler(this.pctLogout_Click);
            // 
            // btnMyCart
            // 
            this.btnMyCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnMyCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyCart.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMyCart.Image = ((System.Drawing.Image)(resources.GetObject("btnMyCart.Image")));
            this.btnMyCart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyCart.Location = new System.Drawing.Point(0, 258);
            this.btnMyCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMyCart.Name = "btnMyCart";
            this.btnMyCart.Size = new System.Drawing.Size(295, 66);
            this.btnMyCart.TabIndex = 3;
            this.btnMyCart.Text = "My Cart";
            this.btnMyCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyCart.UseVisualStyleBackColor = false;
            this.btnMyCart.Click += new System.EventHandler(this.btnMyCart_Click);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.labelName);
            this.panelUserInfo.Controls.Add(this.labelUsername);
            this.panelUserInfo.Controls.Add(this.lblName);
            this.panelUserInfo.Controls.Add(this.lblUsername);
            this.panelUserInfo.Controls.Add(this.pctAvatar);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(295, 258);
            this.panelUserInfo.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.labelName.Location = new System.Drawing.Point(109, 178);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 22);
            this.labelName.TabIndex = 4;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.labelUsername.Location = new System.Drawing.Point(109, 206);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 22);
            this.labelUsername.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.lblName.Location = new System.Drawing.Point(3, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 22);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.lblUsername.Location = new System.Drawing.Point(3, 206);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 22);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // pctAvatar
            // 
            this.pctAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pctAvatar.Image")));
            this.pctAvatar.Location = new System.Drawing.Point(76, 12);
            this.pctAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctAvatar.Name = "pctAvatar";
            this.pctAvatar.Size = new System.Drawing.Size(120, 120);
            this.pctAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctAvatar.TabIndex = 0;
            this.pctAvatar.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pctSearch);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblLine);
            this.panelTop.Controls.Add(this.pctExit);
            this.panelTop.Controls.Add(this.pctMinimize);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(295, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 103);
            this.panelTop.TabIndex = 14;
            // 
            // pctSearch
            // 
            this.pctSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSearch.Image = ((System.Drawing.Image)(resources.GetObject("pctSearch.Image")));
            this.pctSearch.Location = new System.Drawing.Point(193, 25);
            this.pctSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pctSearch.Name = "pctSearch";
            this.pctSearch.Size = new System.Drawing.Size(47, 43);
            this.pctSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSearch.TabIndex = 18;
            this.pctSearch.TabStop = false;
            this.pctSearch.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtSearch.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(260, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(505, 41);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Text = "Search";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.lblLine.Location = new System.Drawing.Point(0, 101);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(1100, 2);
            this.lblLine.TabIndex = 15;
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(1044, 8);
            this.pctExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(35, 35);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctExit.TabIndex = 15;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // pctMinimize
            // 
            this.pctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimize.Image")));
            this.pctMinimize.Location = new System.Drawing.Point(1003, 15);
            this.pctMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(35, 35);
            this.pctMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctMinimize.TabIndex = 16;
            this.pctMinimize.TabStop = false;
            this.pctMinimize.Click += new System.EventHandler(this.pctMinimize_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnBooks.FlatAppearance.BorderSize = 2;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnBooks.Location = new System.Drawing.Point(0, 0);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(355, 97);
            this.btnBooks.TabIndex = 7;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnMagazine
            // 
            this.btnMagazine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.btnMagazine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMagazine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnMagazine.FlatAppearance.BorderSize = 2;
            this.btnMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMagazine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnMagazine.Location = new System.Drawing.Point(0, 0);
            this.btnMagazine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(1100, 97);
            this.btnMagazine.TabIndex = 7;
            this.btnMagazine.Text = "Magazines";
            this.btnMagazine.UseVisualStyleBackColor = false;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.btnMusic.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMusic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnMusic.FlatAppearance.BorderSize = 2;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnMusic.Location = new System.Drawing.Point(745, 0);
            this.btnMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(355, 97);
            this.btnMusic.TabIndex = 7;
            this.btnMusic.Text = "Music/CD";
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.pnlRed3);
            this.panelButtons.Controls.Add(this.pnlRed2);
            this.panelButtons.Controls.Add(this.pnlRed1);
            this.panelButtons.Controls.Add(this.btnBooks);
            this.panelButtons.Controls.Add(this.btnMusic);
            this.panelButtons.Controls.Add(this.btnMagazine);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(295, 103);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1100, 97);
            this.panelButtons.TabIndex = 15;
            // 
            // pnlRed3
            // 
            this.pnlRed3.BackColor = System.Drawing.Color.Red;
            this.pnlRed3.Location = new System.Drawing.Point(745, 87);
            this.pnlRed3.Name = "pnlRed3";
            this.pnlRed3.Size = new System.Drawing.Size(355, 10);
            this.pnlRed3.TabIndex = 10;
            this.pnlRed3.Visible = false;
            // 
            // pnlRed2
            // 
            this.pnlRed2.BackColor = System.Drawing.Color.Red;
            this.pnlRed2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRed2.Location = new System.Drawing.Point(355, 87);
            this.pnlRed2.Name = "pnlRed2";
            this.pnlRed2.Size = new System.Drawing.Size(390, 10);
            this.pnlRed2.TabIndex = 10;
            this.pnlRed2.Visible = false;
            // 
            // pnlRed1
            // 
            this.pnlRed1.BackColor = System.Drawing.Color.Red;
            this.pnlRed1.Location = new System.Drawing.Point(3, 87);
            this.pnlRed1.Name = "pnlRed1";
            this.pnlRed1.Size = new System.Drawing.Size(352, 10);
            this.pnlRed1.TabIndex = 10;
            // 
            // flwPanelProducts
            // 
            this.flwPanelProducts.AutoScroll = true;
            this.flwPanelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwPanelProducts.Location = new System.Drawing.Point(295, 200);
            this.flwPanelProducts.Margin = new System.Windows.Forms.Padding(4);
            this.flwPanelProducts.Name = "flwPanelProducts";
            this.flwPanelProducts.Size = new System.Drawing.Size(1100, 548);
            this.flwPanelProducts.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1395, 748);
            this.Controls.Add(this.flwPanelProducts);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnMyCart;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pctAvatar;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pctLogout;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.PictureBox pctSearch;
        private System.Windows.Forms.RichTextBox txtSearch;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.FlowLayoutPanel flwPanelProducts;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Panel pnlRed3;
        private System.Windows.Forms.Panel pnlRed2;
        private System.Windows.Forms.Panel pnlRed1;
        private System.Windows.Forms.Button btnAdminPanel;
    }
}