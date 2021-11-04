
namespace Online_Book_Store
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pctLogout = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pctAvatar = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grpBookControl = new System.Windows.Forms.GroupBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.lblImageURL = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.grpMagazineControl = new System.Windows.Forms.GroupBox();
            this.cmbMagazineType = new System.Windows.Forms.ComboBox();
            this.btnMagazineClear = new System.Windows.Forms.Button();
            this.btnMagazineDelete = new System.Windows.Forms.Button();
            this.btnMagazineUpdate = new System.Windows.Forms.Button();
            this.btnMagazineAdd = new System.Windows.Forms.Button();
            this.lblMagazineDescription = new System.Windows.Forms.Label();
            this.txtMagazineIssue = new System.Windows.Forms.TextBox();
            this.lblMagazineType = new System.Windows.Forms.Label();
            this.lblMagazineIssue = new System.Windows.Forms.Label();
            this.txtMagazineDescription = new System.Windows.Forms.TextBox();
            this.txtMagazineImageURL = new System.Windows.Forms.TextBox();
            this.lblMagazineImageURL = new System.Windows.Forms.Label();
            this.txtMagazinePrice = new System.Windows.Forms.TextBox();
            this.lblMagazinePrice = new System.Windows.Forms.Label();
            this.txtMagazineName = new System.Windows.Forms.TextBox();
            this.lblMagazineName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMusicCDType = new System.Windows.Forms.ComboBox();
            this.btnMusicCDClear = new System.Windows.Forms.Button();
            this.btnMusicCDDelete = new System.Windows.Forms.Button();
            this.btnMusicCDUpdate = new System.Windows.Forms.Button();
            this.btnMusicCDAdd = new System.Windows.Forms.Button();
            this.lblMusicCDDescription = new System.Windows.Forms.Label();
            this.txtMusicCDSinger = new System.Windows.Forms.TextBox();
            this.lblMusicCDType = new System.Windows.Forms.Label();
            this.lblMusicCDSinger = new System.Windows.Forms.Label();
            this.txtMusicCDDescription = new System.Windows.Forms.TextBox();
            this.txtMusicCDImageURL = new System.Windows.Forms.TextBox();
            this.lblMusicCDImageURL = new System.Windows.Forms.Label();
            this.txtMusicCDPrice = new System.Windows.Forms.TextBox();
            this.lblMusicCDPrice = new System.Windows.Forms.Label();
            this.txtMusicCDName = new System.Windows.Forms.TextBox();
            this.lblMusicCDName = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).BeginInit();
            this.grpBookControl.SuspendLayout();
            this.grpMagazineControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.lblDate);
            this.panelLeft.Controls.Add(this.lblTime);
            this.panelLeft.Controls.Add(this.pctLogout);
            this.panelLeft.Controls.Add(this.btnMainMenu);
            this.panelLeft.Controls.Add(this.panelUserInfo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(170, 748);
            this.panelLeft.TabIndex = 22;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.lblDate.Location = new System.Drawing.Point(12, 638);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 22);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "label1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.lblTime.Location = new System.Drawing.Point(12, 607);
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
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.btnMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.Image")));
            this.btnMainMenu.Location = new System.Drawing.Point(0, 258);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(170, 66);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.labelName);
            this.panelUserInfo.Controls.Add(this.labelUsername);
            this.panelUserInfo.Controls.Add(this.pctAvatar);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(170, 258);
            this.panelUserInfo.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.labelName.Location = new System.Drawing.Point(17, 178);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 22);
            this.labelName.TabIndex = 4;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.labelUsername.Location = new System.Drawing.Point(17, 206);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 22);
            this.labelUsername.TabIndex = 3;
            // 
            // pctAvatar
            // 
            this.pctAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pctAvatar.Image")));
            this.pctAvatar.Location = new System.Drawing.Point(11, 11);
            this.pctAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctAvatar.Name = "pctAvatar";
            this.pctAvatar.Size = new System.Drawing.Size(120, 120);
            this.pctAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctAvatar.TabIndex = 0;
            this.pctAvatar.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // grpBookControl
            // 
            this.grpBookControl.Controls.Add(this.txtISBN);
            this.grpBookControl.Controls.Add(this.lblISBN);
            this.grpBookControl.Controls.Add(this.btnClear);
            this.grpBookControl.Controls.Add(this.btnDelete);
            this.grpBookControl.Controls.Add(this.btnUpdate);
            this.grpBookControl.Controls.Add(this.btnAdd);
            this.grpBookControl.Controls.Add(this.txtPage);
            this.grpBookControl.Controls.Add(this.lblPage);
            this.grpBookControl.Controls.Add(this.lblDescription);
            this.grpBookControl.Controls.Add(this.txtPublisher);
            this.grpBookControl.Controls.Add(this.txtAuthor);
            this.grpBookControl.Controls.Add(this.lblPublisher);
            this.grpBookControl.Controls.Add(this.lblAuthor);
            this.grpBookControl.Controls.Add(this.txtDescription);
            this.grpBookControl.Controls.Add(this.txtImageURL);
            this.grpBookControl.Controls.Add(this.lblImageURL);
            this.grpBookControl.Controls.Add(this.txtPrice);
            this.grpBookControl.Controls.Add(this.lblPrice);
            this.grpBookControl.Controls.Add(this.txtBookName);
            this.grpBookControl.Controls.Add(this.lblBookName);
            this.grpBookControl.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBookControl.ForeColor = System.Drawing.Color.White;
            this.grpBookControl.Location = new System.Drawing.Point(188, 32);
            this.grpBookControl.Name = "grpBookControl";
            this.grpBookControl.Size = new System.Drawing.Size(441, 529);
            this.grpBookControl.TabIndex = 23;
            this.grpBookControl.TabStop = false;
            this.grpBookControl.Text = "Book Control";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtISBN.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtISBN.ForeColor = System.Drawing.Color.White;
            this.txtISBN.Location = new System.Drawing.Point(147, 212);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(216, 27);
            this.txtISBN.TabIndex = 20;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblISBN.Location = new System.Drawing.Point(70, 215);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(54, 20);
            this.lblISBN.TabIndex = 19;
            this.lblISBN.Text = "ISBN:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(290, 436);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 39);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(290, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 39);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(147, 436);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 39);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(147, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 39);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPage
            // 
            this.txtPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtPage.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPage.ForeColor = System.Drawing.Color.White;
            this.txtPage.Location = new System.Drawing.Point(147, 249);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(216, 27);
            this.txtPage.TabIndex = 13;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPage.Location = new System.Drawing.Point(70, 252);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(54, 20);
            this.lblPage.TabIndex = 12;
            this.lblPage.Text = "Page:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(7, 285);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(117, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtPublisher.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPublisher.ForeColor = System.Drawing.Color.White;
            this.txtPublisher.Location = new System.Drawing.Point(147, 179);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(216, 27);
            this.txtPublisher.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtAuthor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAuthor.ForeColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(147, 146);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(216, 27);
            this.txtAuthor.TabIndex = 9;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublisher.Location = new System.Drawing.Point(25, 182);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(99, 20);
            this.lblPublisher.TabIndex = 10;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Location = new System.Drawing.Point(52, 149);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(72, 20);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Author:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtDescription.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(147, 282);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 103);
            this.txtDescription.TabIndex = 7;
            // 
            // txtImageURL
            // 
            this.txtImageURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtImageURL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImageURL.ForeColor = System.Drawing.Color.White;
            this.txtImageURL.Location = new System.Drawing.Point(147, 113);
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.Size = new System.Drawing.Size(216, 27);
            this.txtImageURL.TabIndex = 5;
            // 
            // lblImageURL
            // 
            this.lblImageURL.AutoSize = true;
            this.lblImageURL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImageURL.Location = new System.Drawing.Point(25, 116);
            this.lblImageURL.Name = "lblImageURL";
            this.lblImageURL.Size = new System.Drawing.Size(99, 20);
            this.lblImageURL.TabIndex = 4;
            this.lblImageURL.Text = "Image URL:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtPrice.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(147, 80);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(216, 27);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(61, 83);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtBookName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookName.ForeColor = System.Drawing.Color.White;
            this.txtBookName.Location = new System.Drawing.Point(147, 47);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(216, 27);
            this.txtBookName.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.Location = new System.Drawing.Point(70, 50);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(54, 20);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Name:";
            // 
            // grpMagazineControl
            // 
            this.grpMagazineControl.Controls.Add(this.cmbMagazineType);
            this.grpMagazineControl.Controls.Add(this.btnMagazineClear);
            this.grpMagazineControl.Controls.Add(this.btnMagazineDelete);
            this.grpMagazineControl.Controls.Add(this.btnMagazineUpdate);
            this.grpMagazineControl.Controls.Add(this.btnMagazineAdd);
            this.grpMagazineControl.Controls.Add(this.lblMagazineDescription);
            this.grpMagazineControl.Controls.Add(this.txtMagazineIssue);
            this.grpMagazineControl.Controls.Add(this.lblMagazineType);
            this.grpMagazineControl.Controls.Add(this.lblMagazineIssue);
            this.grpMagazineControl.Controls.Add(this.txtMagazineDescription);
            this.grpMagazineControl.Controls.Add(this.txtMagazineImageURL);
            this.grpMagazineControl.Controls.Add(this.lblMagazineImageURL);
            this.grpMagazineControl.Controls.Add(this.txtMagazinePrice);
            this.grpMagazineControl.Controls.Add(this.lblMagazinePrice);
            this.grpMagazineControl.Controls.Add(this.txtMagazineName);
            this.grpMagazineControl.Controls.Add(this.lblMagazineName);
            this.grpMagazineControl.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMagazineControl.ForeColor = System.Drawing.Color.White;
            this.grpMagazineControl.Location = new System.Drawing.Point(635, 32);
            this.grpMagazineControl.Name = "grpMagazineControl";
            this.grpMagazineControl.Size = new System.Drawing.Size(441, 529);
            this.grpMagazineControl.TabIndex = 24;
            this.grpMagazineControl.TabStop = false;
            this.grpMagazineControl.Text = "Magazine Control";
            // 
            // cmbMagazineType
            // 
            this.cmbMagazineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.cmbMagazineType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMagazineType.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbMagazineType.ForeColor = System.Drawing.Color.White;
            this.cmbMagazineType.FormattingEnabled = true;
            this.cmbMagazineType.Items.AddRange(new object[] {
            "Actual",
            "News",
            "Sport",
            "Computer",
            "Technology"});
            this.cmbMagazineType.Location = new System.Drawing.Point(147, 179);
            this.cmbMagazineType.Name = "cmbMagazineType";
            this.cmbMagazineType.Size = new System.Drawing.Size(216, 28);
            this.cmbMagazineType.TabIndex = 20;
            // 
            // btnMagazineClear
            // 
            this.btnMagazineClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazineClear.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMagazineClear.Location = new System.Drawing.Point(290, 436);
            this.btnMagazineClear.Name = "btnMagazineClear";
            this.btnMagazineClear.Size = new System.Drawing.Size(122, 39);
            this.btnMagazineClear.TabIndex = 18;
            this.btnMagazineClear.Text = "Clear";
            this.btnMagazineClear.UseVisualStyleBackColor = true;
            this.btnMagazineClear.Click += new System.EventHandler(this.btnMagazineClear_Click);
            // 
            // btnMagazineDelete
            // 
            this.btnMagazineDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazineDelete.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMagazineDelete.Location = new System.Drawing.Point(290, 391);
            this.btnMagazineDelete.Name = "btnMagazineDelete";
            this.btnMagazineDelete.Size = new System.Drawing.Size(122, 39);
            this.btnMagazineDelete.TabIndex = 17;
            this.btnMagazineDelete.Text = "Delete";
            this.btnMagazineDelete.UseVisualStyleBackColor = true;
            this.btnMagazineDelete.Click += new System.EventHandler(this.btnMagazineDelete_Click);
            // 
            // btnMagazineUpdate
            // 
            this.btnMagazineUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazineUpdate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMagazineUpdate.Location = new System.Drawing.Point(147, 436);
            this.btnMagazineUpdate.Name = "btnMagazineUpdate";
            this.btnMagazineUpdate.Size = new System.Drawing.Size(122, 39);
            this.btnMagazineUpdate.TabIndex = 16;
            this.btnMagazineUpdate.Text = "Update";
            this.btnMagazineUpdate.UseVisualStyleBackColor = true;
            this.btnMagazineUpdate.Click += new System.EventHandler(this.btnMagazineUpdate_Click);
            // 
            // btnMagazineAdd
            // 
            this.btnMagazineAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazineAdd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMagazineAdd.Location = new System.Drawing.Point(147, 391);
            this.btnMagazineAdd.Name = "btnMagazineAdd";
            this.btnMagazineAdd.Size = new System.Drawing.Size(122, 39);
            this.btnMagazineAdd.TabIndex = 14;
            this.btnMagazineAdd.Text = "Add";
            this.btnMagazineAdd.UseVisualStyleBackColor = true;
            this.btnMagazineAdd.Click += new System.EventHandler(this.btnMagazineAdd_Click);
            // 
            // lblMagazineDescription
            // 
            this.lblMagazineDescription.AutoSize = true;
            this.lblMagazineDescription.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineDescription.Location = new System.Drawing.Point(7, 285);
            this.lblMagazineDescription.Name = "lblMagazineDescription";
            this.lblMagazineDescription.Size = new System.Drawing.Size(117, 20);
            this.lblMagazineDescription.TabIndex = 6;
            this.lblMagazineDescription.Text = "Description:";
            // 
            // txtMagazineIssue
            // 
            this.txtMagazineIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMagazineIssue.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMagazineIssue.ForeColor = System.Drawing.Color.White;
            this.txtMagazineIssue.Location = new System.Drawing.Point(147, 146);
            this.txtMagazineIssue.Name = "txtMagazineIssue";
            this.txtMagazineIssue.Size = new System.Drawing.Size(216, 27);
            this.txtMagazineIssue.TabIndex = 9;
            // 
            // lblMagazineType
            // 
            this.lblMagazineType.AutoSize = true;
            this.lblMagazineType.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineType.Location = new System.Drawing.Point(70, 182);
            this.lblMagazineType.Name = "lblMagazineType";
            this.lblMagazineType.Size = new System.Drawing.Size(54, 20);
            this.lblMagazineType.TabIndex = 10;
            this.lblMagazineType.Text = "Type:";
            // 
            // lblMagazineIssue
            // 
            this.lblMagazineIssue.AutoSize = true;
            this.lblMagazineIssue.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineIssue.Location = new System.Drawing.Point(61, 149);
            this.lblMagazineIssue.Name = "lblMagazineIssue";
            this.lblMagazineIssue.Size = new System.Drawing.Size(63, 20);
            this.lblMagazineIssue.TabIndex = 8;
            this.lblMagazineIssue.Text = "Issue:";
            // 
            // txtMagazineDescription
            // 
            this.txtMagazineDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMagazineDescription.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMagazineDescription.ForeColor = System.Drawing.Color.White;
            this.txtMagazineDescription.Location = new System.Drawing.Point(147, 282);
            this.txtMagazineDescription.Multiline = true;
            this.txtMagazineDescription.Name = "txtMagazineDescription";
            this.txtMagazineDescription.Size = new System.Drawing.Size(265, 103);
            this.txtMagazineDescription.TabIndex = 7;
            // 
            // txtMagazineImageURL
            // 
            this.txtMagazineImageURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMagazineImageURL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMagazineImageURL.ForeColor = System.Drawing.Color.White;
            this.txtMagazineImageURL.Location = new System.Drawing.Point(147, 113);
            this.txtMagazineImageURL.Name = "txtMagazineImageURL";
            this.txtMagazineImageURL.Size = new System.Drawing.Size(216, 27);
            this.txtMagazineImageURL.TabIndex = 5;
            // 
            // lblMagazineImageURL
            // 
            this.lblMagazineImageURL.AutoSize = true;
            this.lblMagazineImageURL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineImageURL.Location = new System.Drawing.Point(25, 116);
            this.lblMagazineImageURL.Name = "lblMagazineImageURL";
            this.lblMagazineImageURL.Size = new System.Drawing.Size(99, 20);
            this.lblMagazineImageURL.TabIndex = 4;
            this.lblMagazineImageURL.Text = "Image URL:";
            // 
            // txtMagazinePrice
            // 
            this.txtMagazinePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMagazinePrice.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMagazinePrice.ForeColor = System.Drawing.Color.White;
            this.txtMagazinePrice.Location = new System.Drawing.Point(147, 80);
            this.txtMagazinePrice.Name = "txtMagazinePrice";
            this.txtMagazinePrice.Size = new System.Drawing.Size(216, 27);
            this.txtMagazinePrice.TabIndex = 3;
            // 
            // lblMagazinePrice
            // 
            this.lblMagazinePrice.AutoSize = true;
            this.lblMagazinePrice.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazinePrice.Location = new System.Drawing.Point(61, 83);
            this.lblMagazinePrice.Name = "lblMagazinePrice";
            this.lblMagazinePrice.Size = new System.Drawing.Size(63, 20);
            this.lblMagazinePrice.TabIndex = 2;
            this.lblMagazinePrice.Text = "Price:";
            // 
            // txtMagazineName
            // 
            this.txtMagazineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMagazineName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMagazineName.ForeColor = System.Drawing.Color.White;
            this.txtMagazineName.Location = new System.Drawing.Point(147, 47);
            this.txtMagazineName.Name = "txtMagazineName";
            this.txtMagazineName.Size = new System.Drawing.Size(216, 27);
            this.txtMagazineName.TabIndex = 1;
            // 
            // lblMagazineName
            // 
            this.lblMagazineName.AutoSize = true;
            this.lblMagazineName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineName.Location = new System.Drawing.Point(70, 50);
            this.lblMagazineName.Name = "lblMagazineName";
            this.lblMagazineName.Size = new System.Drawing.Size(54, 20);
            this.lblMagazineName.TabIndex = 0;
            this.lblMagazineName.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMusicCDType);
            this.groupBox2.Controls.Add(this.btnMusicCDClear);
            this.groupBox2.Controls.Add(this.btnMusicCDDelete);
            this.groupBox2.Controls.Add(this.btnMusicCDUpdate);
            this.groupBox2.Controls.Add(this.btnMusicCDAdd);
            this.groupBox2.Controls.Add(this.lblMusicCDDescription);
            this.groupBox2.Controls.Add(this.txtMusicCDSinger);
            this.groupBox2.Controls.Add(this.lblMusicCDType);
            this.groupBox2.Controls.Add(this.lblMusicCDSinger);
            this.groupBox2.Controls.Add(this.txtMusicCDDescription);
            this.groupBox2.Controls.Add(this.txtMusicCDImageURL);
            this.groupBox2.Controls.Add(this.lblMusicCDImageURL);
            this.groupBox2.Controls.Add(this.txtMusicCDPrice);
            this.groupBox2.Controls.Add(this.lblMusicCDPrice);
            this.groupBox2.Controls.Add(this.txtMusicCDName);
            this.groupBox2.Controls.Add(this.lblMusicCDName);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1082, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 529);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Music CD Control";
            // 
            // cmbMusicCDType
            // 
            this.cmbMusicCDType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.cmbMusicCDType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMusicCDType.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbMusicCDType.ForeColor = System.Drawing.Color.White;
            this.cmbMusicCDType.FormattingEnabled = true;
            this.cmbMusicCDType.Items.AddRange(new object[] {
            "Country",
            "Hard Rock",
            "Heavy Metal",
            "Pop",
            "Rap",
            "Romance"});
            this.cmbMusicCDType.Location = new System.Drawing.Point(147, 179);
            this.cmbMusicCDType.Name = "cmbMusicCDType";
            this.cmbMusicCDType.Size = new System.Drawing.Size(216, 28);
            this.cmbMusicCDType.TabIndex = 21;
            // 
            // btnMusicCDClear
            // 
            this.btnMusicCDClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCDClear.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusicCDClear.Location = new System.Drawing.Point(290, 436);
            this.btnMusicCDClear.Name = "btnMusicCDClear";
            this.btnMusicCDClear.Size = new System.Drawing.Size(122, 39);
            this.btnMusicCDClear.TabIndex = 18;
            this.btnMusicCDClear.Text = "Clear";
            this.btnMusicCDClear.UseVisualStyleBackColor = true;
            this.btnMusicCDClear.Click += new System.EventHandler(this.btnMusicCDClear_Click);
            // 
            // btnMusicCDDelete
            // 
            this.btnMusicCDDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCDDelete.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusicCDDelete.Location = new System.Drawing.Point(290, 391);
            this.btnMusicCDDelete.Name = "btnMusicCDDelete";
            this.btnMusicCDDelete.Size = new System.Drawing.Size(122, 39);
            this.btnMusicCDDelete.TabIndex = 17;
            this.btnMusicCDDelete.Text = "Delete";
            this.btnMusicCDDelete.UseVisualStyleBackColor = true;
            this.btnMusicCDDelete.Click += new System.EventHandler(this.btnMusicCDDelete_Click);
            // 
            // btnMusicCDUpdate
            // 
            this.btnMusicCDUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCDUpdate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusicCDUpdate.Location = new System.Drawing.Point(147, 436);
            this.btnMusicCDUpdate.Name = "btnMusicCDUpdate";
            this.btnMusicCDUpdate.Size = new System.Drawing.Size(122, 39);
            this.btnMusicCDUpdate.TabIndex = 16;
            this.btnMusicCDUpdate.Text = "Update";
            this.btnMusicCDUpdate.UseVisualStyleBackColor = true;
            this.btnMusicCDUpdate.Click += new System.EventHandler(this.btnMusicCDUpdate_Click);
            // 
            // btnMusicCDAdd
            // 
            this.btnMusicCDAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCDAdd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusicCDAdd.Location = new System.Drawing.Point(147, 391);
            this.btnMusicCDAdd.Name = "btnMusicCDAdd";
            this.btnMusicCDAdd.Size = new System.Drawing.Size(122, 39);
            this.btnMusicCDAdd.TabIndex = 14;
            this.btnMusicCDAdd.Text = "Add";
            this.btnMusicCDAdd.UseVisualStyleBackColor = true;
            this.btnMusicCDAdd.Click += new System.EventHandler(this.btnMusicCDAdd_Click);
            // 
            // lblMusicCDDescription
            // 
            this.lblMusicCDDescription.AutoSize = true;
            this.lblMusicCDDescription.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicCDDescription.Location = new System.Drawing.Point(7, 285);
            this.lblMusicCDDescription.Name = "lblMusicCDDescription";
            this.lblMusicCDDescription.Size = new System.Drawing.Size(117, 20);
            this.lblMusicCDDescription.TabIndex = 6;
            this.lblMusicCDDescription.Text = "Description:";
            // 
            // txtMusicCDSinger
            // 
            this.txtMusicCDSinger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMusicCDSinger.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusicCDSinger.ForeColor = System.Drawing.Color.White;
            this.txtMusicCDSinger.Location = new System.Drawing.Point(147, 146);
            this.txtMusicCDSinger.Name = "txtMusicCDSinger";
            this.txtMusicCDSinger.Size = new System.Drawing.Size(216, 27);
            this.txtMusicCDSinger.TabIndex = 9;
            // 
            // lblMusicCDType
            // 
            this.lblMusicCDType.AutoSize = true;
            this.lblMusicCDType.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicCDType.Location = new System.Drawing.Point(70, 182);
            this.lblMusicCDType.Name = "lblMusicCDType";
            this.lblMusicCDType.Size = new System.Drawing.Size(54, 20);
            this.lblMusicCDType.TabIndex = 10;
            this.lblMusicCDType.Text = "Type:";
            // 
            // lblMusicCDSinger
            // 
            this.lblMusicCDSinger.AutoSize = true;
            this.lblMusicCDSinger.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicCDSinger.Location = new System.Drawing.Point(52, 149);
            this.lblMusicCDSinger.Name = "lblMusicCDSinger";
            this.lblMusicCDSinger.Size = new System.Drawing.Size(72, 20);
            this.lblMusicCDSinger.TabIndex = 8;
            this.lblMusicCDSinger.Text = "Singer:";
            // 
            // txtMusicCDDescription
            // 
            this.txtMusicCDDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMusicCDDescription.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusicCDDescription.ForeColor = System.Drawing.Color.White;
            this.txtMusicCDDescription.Location = new System.Drawing.Point(147, 282);
            this.txtMusicCDDescription.Multiline = true;
            this.txtMusicCDDescription.Name = "txtMusicCDDescription";
            this.txtMusicCDDescription.Size = new System.Drawing.Size(265, 103);
            this.txtMusicCDDescription.TabIndex = 7;
            // 
            // txtMusicCDImageURL
            // 
            this.txtMusicCDImageURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMusicCDImageURL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusicCDImageURL.ForeColor = System.Drawing.Color.White;
            this.txtMusicCDImageURL.Location = new System.Drawing.Point(147, 113);
            this.txtMusicCDImageURL.Name = "txtMusicCDImageURL";
            this.txtMusicCDImageURL.Size = new System.Drawing.Size(216, 27);
            this.txtMusicCDImageURL.TabIndex = 5;
            // 
            // lblMusicCDImageURL
            // 
            this.lblMusicCDImageURL.AutoSize = true;
            this.lblMusicCDImageURL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicCDImageURL.Location = new System.Drawing.Point(25, 116);
            this.lblMusicCDImageURL.Name = "lblMusicCDImageURL";
            this.lblMusicCDImageURL.Size = new System.Drawing.Size(99, 20);
            this.lblMusicCDImageURL.TabIndex = 4;
            this.lblMusicCDImageURL.Text = "Image URL:";
            // 
            // txtMusicCDPrice
            // 
            this.txtMusicCDPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMusicCDPrice.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusicCDPrice.ForeColor = System.Drawing.Color.White;
            this.txtMusicCDPrice.Location = new System.Drawing.Point(147, 80);
            this.txtMusicCDPrice.Name = "txtMusicCDPrice";
            this.txtMusicCDPrice.Size = new System.Drawing.Size(216, 27);
            this.txtMusicCDPrice.TabIndex = 3;
            // 
            // lblMusicCDPrice
            // 
            this.lblMusicCDPrice.AutoSize = true;
            this.lblMusicCDPrice.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicCDPrice.Location = new System.Drawing.Point(61, 83);
            this.lblMusicCDPrice.Name = "lblMusicCDPrice";
            this.lblMusicCDPrice.Size = new System.Drawing.Size(63, 20);
            this.lblMusicCDPrice.TabIndex = 2;
            this.lblMusicCDPrice.Text = "Price:";
            // 
            // txtMusicCDName
            // 
            this.txtMusicCDName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMusicCDName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusicCDName.ForeColor = System.Drawing.Color.White;
            this.txtMusicCDName.Location = new System.Drawing.Point(147, 47);
            this.txtMusicCDName.Name = "txtMusicCDName";
            this.txtMusicCDName.Size = new System.Drawing.Size(216, 27);
            this.txtMusicCDName.TabIndex = 1;
            // 
            // lblMusicCDName
            // 
            this.lblMusicCDName.AutoSize = true;
            this.lblMusicCDName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicCDName.Location = new System.Drawing.Point(70, 50);
            this.lblMusicCDName.Name = "lblMusicCDName";
            this.lblMusicCDName.Size = new System.Drawing.Size(54, 20);
            this.lblMusicCDName.TabIndex = 0;
            this.lblMusicCDName.Text = "Name:";
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1674, 748);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpMagazineControl);
            this.Controls.Add(this.grpBookControl);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanelForm";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).EndInit();
            this.grpBookControl.ResumeLayout(false);
            this.grpBookControl.PerformLayout();
            this.grpMagazineControl.ResumeLayout(false);
            this.grpMagazineControl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pctLogout;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pctAvatar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox grpBookControl;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtImageURL;
        private System.Windows.Forms.Label lblImageURL;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.GroupBox grpMagazineControl;
        private System.Windows.Forms.Button btnMagazineClear;
        private System.Windows.Forms.Button btnMagazineDelete;
        private System.Windows.Forms.Button btnMagazineUpdate;
        private System.Windows.Forms.Button btnMagazineAdd;
        private System.Windows.Forms.Label lblMagazineDescription;
        private System.Windows.Forms.TextBox txtMagazineIssue;
        private System.Windows.Forms.Label lblMagazineType;
        private System.Windows.Forms.Label lblMagazineIssue;
        private System.Windows.Forms.TextBox txtMagazineDescription;
        private System.Windows.Forms.TextBox txtMagazineImageURL;
        private System.Windows.Forms.Label lblMagazineImageURL;
        private System.Windows.Forms.TextBox txtMagazinePrice;
        private System.Windows.Forms.Label lblMagazinePrice;
        private System.Windows.Forms.TextBox txtMagazineName;
        private System.Windows.Forms.Label lblMagazineName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMusicCDClear;
        private System.Windows.Forms.Button btnMusicCDDelete;
        private System.Windows.Forms.Button btnMusicCDUpdate;
        private System.Windows.Forms.Button btnMusicCDAdd;
        private System.Windows.Forms.Label lblMusicCDDescription;
        private System.Windows.Forms.TextBox txtMusicCDSinger;
        private System.Windows.Forms.Label lblMusicCDType;
        private System.Windows.Forms.Label lblMusicCDSinger;
        private System.Windows.Forms.TextBox txtMusicCDDescription;
        private System.Windows.Forms.TextBox txtMusicCDImageURL;
        private System.Windows.Forms.Label lblMusicCDImageURL;
        private System.Windows.Forms.TextBox txtMusicCDPrice;
        private System.Windows.Forms.Label lblMusicCDPrice;
        private System.Windows.Forms.TextBox txtMusicCDName;
        private System.Windows.Forms.Label lblMusicCDName;
        private System.Windows.Forms.ComboBox cmbMagazineType;
        private System.Windows.Forms.ComboBox cmbMusicCDType;
    }
}