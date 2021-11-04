
namespace Online_Book_Store
{
    partial class MyCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCartForm));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pctLogout = new System.Windows.Forms.PictureBox();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pctAvatar = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.rdoBtnCart = new System.Windows.Forms.RadioButton();
            this.rdoBtnCash = new System.Windows.Forms.RadioButton();
            this.lblcartName = new System.Windows.Forms.Label();
            this.lblCartNumber = new System.Windows.Forms.Label();
            this.lblCartDate = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.txtCartName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.lblDifference = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.grpPaymentMethod.SuspendLayout();
            this.grpCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.btnMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.Image")));
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainMenu.Location = new System.Drawing.Point(0, 258);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(295, 66);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblInfo);
            this.panelTop.Controls.Add(this.lblLine);
            this.panelTop.Controls.Add(this.pctExit);
            this.panelTop.Controls.Add(this.pctMinimize);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(295, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1145, 103);
            this.panelTop.TabIndex = 22;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(5, 66);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(560, 23);
            this.lblInfo.TabIndex = 34;
            this.lblInfo.Text = "Note: Double click the product you want to remove.";
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.lblLine.Location = new System.Drawing.Point(0, 101);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(1145, 2);
            this.lblLine.TabIndex = 15;
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(1096, 2);
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
            this.pctMinimize.Location = new System.Drawing.Point(1053, 8);
            this.pctMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(35, 35);
            this.pctMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctMinimize.TabIndex = 16;
            this.pctMinimize.TabStop = false;
            this.pctMinimize.Click += new System.EventHandler(this.pctMinimize_Click);
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
            this.panelLeft.Size = new System.Drawing.Size(295, 748);
            this.panelLeft.TabIndex = 21;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // listViewProducts
            // 
            this.listViewProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.listViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProducts.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewProducts.ForeColor = System.Drawing.Color.White;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(301, 108);
            this.listViewProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(669, 575);
            this.listViewProducts.TabIndex = 23;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.DoubleClick += new System.EventHandler(this.listViewProducts_DoubleClick);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelOrder.Image")));
            this.btnCancelOrder.Location = new System.Drawing.Point(984, 603);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(157, 60);
            this.btnCancelOrder.TabIndex = 31;
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(977, 560);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(239, 36);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Total Price: $";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labelTotalPrice.Location = new System.Drawing.Point(1237, 560);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(31, 36);
            this.labelTotalPrice.TabIndex = 32;
            this.labelTotalPrice.Text = "0";
            // 
            // btnBuy
            // 
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Image = ((System.Drawing.Image)(resources.GetObject("btnBuy.Image")));
            this.btnBuy.Location = new System.Drawing.Point(1148, 603);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(157, 60);
            this.btnBuy.TabIndex = 33;
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.Controls.Add(this.rdoBtnCart);
            this.grpPaymentMethod.Controls.Add(this.rdoBtnCash);
            this.grpPaymentMethod.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.grpPaymentMethod.Location = new System.Drawing.Point(984, 110);
            this.grpPaymentMethod.Margin = new System.Windows.Forms.Padding(4);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.Padding = new System.Windows.Forms.Padding(4);
            this.grpPaymentMethod.Size = new System.Drawing.Size(440, 118);
            this.grpPaymentMethod.TabIndex = 34;
            this.grpPaymentMethod.TabStop = false;
            // 
            // rdoBtnCart
            // 
            this.rdoBtnCart.AutoSize = true;
            this.rdoBtnCart.Location = new System.Drawing.Point(260, 52);
            this.rdoBtnCart.Margin = new System.Windows.Forms.Padding(4);
            this.rdoBtnCart.Name = "rdoBtnCart";
            this.rdoBtnCart.Size = new System.Drawing.Size(141, 26);
            this.rdoBtnCart.TabIndex = 1;
            this.rdoBtnCart.Text = "Credit Card";
            this.rdoBtnCart.UseVisualStyleBackColor = true;
            this.rdoBtnCart.CheckedChanged += new System.EventHandler(this.rdoBtnCart_CheckedChanged);
            // 
            // rdoBtnCash
            // 
            this.rdoBtnCash.AutoSize = true;
            this.rdoBtnCash.Checked = true;
            this.rdoBtnCash.Location = new System.Drawing.Point(8, 52);
            this.rdoBtnCash.Margin = new System.Windows.Forms.Padding(4);
            this.rdoBtnCash.Name = "rdoBtnCash";
            this.rdoBtnCash.Size = new System.Drawing.Size(71, 26);
            this.rdoBtnCash.TabIndex = 0;
            this.rdoBtnCash.TabStop = true;
            this.rdoBtnCash.Text = "Cash";
            this.rdoBtnCash.UseVisualStyleBackColor = true;
            this.rdoBtnCash.CheckedChanged += new System.EventHandler(this.rdoBtnCash_CheckedChanged);
            // 
            // lblcartName
            // 
            this.lblcartName.AutoSize = true;
            this.lblcartName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcartName.ForeColor = System.Drawing.Color.White;
            this.lblcartName.Location = new System.Drawing.Point(4, 37);
            this.lblcartName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcartName.Name = "lblcartName";
            this.lblcartName.Size = new System.Drawing.Size(60, 22);
            this.lblcartName.TabIndex = 2;
            this.lblcartName.Text = "Name:";
            // 
            // lblCartNumber
            // 
            this.lblCartNumber.AutoSize = true;
            this.lblCartNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartNumber.ForeColor = System.Drawing.Color.White;
            this.lblCartNumber.Location = new System.Drawing.Point(3, 92);
            this.lblCartNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartNumber.Name = "lblCartNumber";
            this.lblCartNumber.Size = new System.Drawing.Size(142, 23);
            this.lblCartNumber.TabIndex = 35;
            this.lblCartNumber.Text = "Cart Number:";
            // 
            // lblCartDate
            // 
            this.lblCartDate.AutoSize = true;
            this.lblCartDate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartDate.ForeColor = System.Drawing.Color.White;
            this.lblCartDate.Location = new System.Drawing.Point(4, 145);
            this.lblCartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartDate.Name = "lblCartDate";
            this.lblCartDate.Size = new System.Drawing.Size(60, 22);
            this.lblCartDate.TabIndex = 36;
            this.lblCartDate.Text = "Date:";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVC.ForeColor = System.Drawing.Color.White;
            this.lblCVC.Location = new System.Drawing.Point(303, 143);
            this.lblCVC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(50, 22);
            this.lblCVC.TabIndex = 37;
            this.lblCVC.Text = "CVC:";
            // 
            // txtCartName
            // 
            this.txtCartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtCartName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCartName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartName.ForeColor = System.Drawing.Color.White;
            this.txtCartName.Location = new System.Drawing.Point(109, 36);
            this.txtCartName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCartName.Name = "txtCartName";
            this.txtCartName.Size = new System.Drawing.Size(316, 27);
            this.txtCartName.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(164, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 27);
            this.textBox1.TabIndex = 39;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.ForeColor = System.Drawing.Color.White;
            this.txtMonth.Location = new System.Drawing.Point(68, 144);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonth.MaxLength = 2;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(32, 27);
            this.txtMonth.TabIndex = 40;
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            // 
            // txtyear
            // 
            this.txtyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtyear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtyear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.ForeColor = System.Drawing.Color.White;
            this.txtyear.Location = new System.Drawing.Point(133, 144);
            this.txtyear.Margin = new System.Windows.Forms.Padding(4);
            this.txtyear.MaxLength = 2;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(32, 27);
            this.txtyear.TabIndex = 41;
            this.txtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyear_KeyPress);
            // 
            // txtCVC
            // 
            this.txtCVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtCVC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCVC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC.ForeColor = System.Drawing.Color.White;
            this.txtCVC.Location = new System.Drawing.Point(364, 138);
            this.txtCVC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVC.MaxLength = 3;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(56, 27);
            this.txtCVC.TabIndex = 42;
            this.txtCVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCVC_KeyPress);
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.lblDifference);
            this.grpCart.Controls.Add(this.txtCartName);
            this.grpCart.Controls.Add(this.txtCVC);
            this.grpCart.Controls.Add(this.lblcartName);
            this.grpCart.Controls.Add(this.txtyear);
            this.grpCart.Controls.Add(this.lblCartNumber);
            this.grpCart.Controls.Add(this.txtMonth);
            this.grpCart.Controls.Add(this.lblCartDate);
            this.grpCart.Controls.Add(this.textBox1);
            this.grpCart.Controls.Add(this.lblCVC);
            this.grpCart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCart.ForeColor = System.Drawing.Color.White;
            this.grpCart.Location = new System.Drawing.Point(984, 258);
            this.grpCart.Margin = new System.Windows.Forms.Padding(4);
            this.grpCart.Name = "grpCart";
            this.grpCart.Padding = new System.Windows.Forms.Padding(4);
            this.grpCart.Size = new System.Drawing.Size(440, 230);
            this.grpCart.TabIndex = 43;
            this.grpCart.TabStop = false;
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifference.Location = new System.Drawing.Point(105, 145);
            this.lblDifference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(25, 28);
            this.lblDifference.TabIndex = 43;
            this.lblDifference.Text = "/";
            // 
            // MyCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1440, 748);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpPaymentMethod);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCartForm";
            this.Load += new System.EventHandler(this.MyCartForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.grpPaymentMethod.ResumeLayout(false);
            this.grpPaymentMethod.PerformLayout();
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pctLogout;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pctAvatar;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpPaymentMethod;
        private System.Windows.Forms.RadioButton rdoBtnCart;
        private System.Windows.Forms.RadioButton rdoBtnCash;
        private System.Windows.Forms.Label lblcartName;
        private System.Windows.Forms.Label lblCartNumber;
        private System.Windows.Forms.Label lblCartDate;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.TextBox txtCartName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Label lblDifference;
    }
}