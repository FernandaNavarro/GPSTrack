namespace GPSTrack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMain = new FontAwesome.Sharp.IconButton();
            this.btnCrash = new FontAwesome.Sharp.IconButton();
            this.btnMessage = new FontAwesome.Sharp.IconButton();
            this.btnTravel = new FontAwesome.Sharp.IconButton();
            this.btnExt = new FontAwesome.Sharp.IconButton();
            this.btnExternal = new FontAwesome.Sharp.IconButton();
            this.btnKeep = new FontAwesome.Sharp.IconButton();
            this.btnAlert = new FontAwesome.Sharp.IconButton();
            this.btnStatus = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lbTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(102)))), ((int)(((byte)(146)))));
            this.panelMenu.Controls.Add(this.btnMain);
            this.panelMenu.Controls.Add(this.btnCrash);
            this.panelMenu.Controls.Add(this.btnMessage);
            this.panelMenu.Controls.Add(this.btnTravel);
            this.panelMenu.Controls.Add(this.btnExt);
            this.panelMenu.Controls.Add(this.btnExternal);
            this.panelMenu.Controls.Add(this.btnKeep);
            this.panelMenu.Controls.Add(this.btnAlert);
            this.panelMenu.Controls.Add(this.btnStatus);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 606);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMain.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnMain.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMain.IconSize = 32;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(0, 490);
            this.btnMain.Name = "btnMain";
            this.btnMain.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMain.Rotation = 0D;
            this.btnMain.Size = new System.Drawing.Size(220, 50);
            this.btnMain.TabIndex = 9;
            this.btnMain.Text = "MAINTENANCE REPORT";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnCrash
            // 
            this.btnCrash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrash.FlatAppearance.BorderSize = 0;
            this.btnCrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrash.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCrash.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrash.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnCrash.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCrash.IconSize = 32;
            this.btnCrash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrash.Location = new System.Drawing.Point(0, 440);
            this.btnCrash.Name = "btnCrash";
            this.btnCrash.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCrash.Rotation = 0D;
            this.btnCrash.Size = new System.Drawing.Size(220, 50);
            this.btnCrash.TabIndex = 8;
            this.btnCrash.Text = "CRASH RECONSTRUCTION REPORT";
            this.btnCrash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrash.UseVisualStyleBackColor = true;
            this.btnCrash.Click += new System.EventHandler(this.btnCrash_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMessage.FlatAppearance.BorderSize = 0;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMessage.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen;
            this.btnMessage.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMessage.IconSize = 32;
            this.btnMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessage.Location = new System.Drawing.Point(0, 390);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMessage.Rotation = 0D;
            this.btnMessage.Size = new System.Drawing.Size(220, 50);
            this.btnMessage.TabIndex = 7;
            this.btnMessage.Text = "ACKNOWLEDGMENT MESSAGE";
            this.btnMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnTravel
            // 
            this.btnTravel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTravel.FlatAppearance.BorderSize = 0;
            this.btnTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTravel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTravel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTravel.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnTravel.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTravel.IconSize = 32;
            this.btnTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTravel.Location = new System.Drawing.Point(0, 340);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTravel.Rotation = 0D;
            this.btnTravel.Size = new System.Drawing.Size(220, 50);
            this.btnTravel.TabIndex = 6;
            this.btnTravel.Text = "TRAVEL REPORT";
            this.btnTravel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTravel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTravel.UseVisualStyleBackColor = true;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // btnExt
            // 
            this.btnExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExt.FlatAppearance.BorderSize = 0;
            this.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExt.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnExt.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExt.IconSize = 32;
            this.btnExt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExt.Location = new System.Drawing.Point(0, 290);
            this.btnExt.Name = "btnExt";
            this.btnExt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExt.Rotation = 0D;
            this.btnExt.Size = new System.Drawing.Size(220, 50);
            this.btnExt.TabIndex = 5;
            this.btnExt.Text = "TRANSFER DATA TO EXTERNAL SERIAL";
            this.btnExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnExternal
            // 
            this.btnExternal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExternal.FlatAppearance.BorderSize = 0;
            this.btnExternal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExternal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExternal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExternal.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnExternal.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExternal.IconSize = 32;
            this.btnExternal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExternal.Location = new System.Drawing.Point(0, 240);
            this.btnExternal.Name = "btnExternal";
            this.btnExternal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExternal.Rotation = 0D;
            this.btnExternal.Size = new System.Drawing.Size(220, 50);
            this.btnExternal.TabIndex = 4;
            this.btnExternal.Text = "EXTERNAL SERIAL DEVICE DATA REPORT";
            this.btnExternal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExternal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExternal.UseVisualStyleBackColor = true;
            this.btnExternal.Click += new System.EventHandler(this.btnExternal_Click);
            // 
            // btnKeep
            // 
            this.btnKeep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKeep.FlatAppearance.BorderSize = 0;
            this.btnKeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeep.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnKeep.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKeep.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnKeep.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKeep.IconSize = 32;
            this.btnKeep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeep.Location = new System.Drawing.Point(0, 190);
            this.btnKeep.Name = "btnKeep";
            this.btnKeep.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKeep.Rotation = 0D;
            this.btnKeep.Size = new System.Drawing.Size(220, 50);
            this.btnKeep.TabIndex = 3;
            this.btnKeep.Text = "KEEP-ALIVE REPORT";
            this.btnKeep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKeep.UseVisualStyleBackColor = true;
            this.btnKeep.Click += new System.EventHandler(this.btnKeep_Click);
            // 
            // btnAlert
            // 
            this.btnAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlert.FlatAppearance.BorderSize = 0;
            this.btnAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlert.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAlert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlert.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.btnAlert.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAlert.IconSize = 32;
            this.btnAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlert.Location = new System.Drawing.Point(0, 140);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAlert.Rotation = 0D;
            this.btnAlert.Size = new System.Drawing.Size(220, 50);
            this.btnAlert.TabIndex = 2;
            this.btnAlert.Text = "ALERT REPORT";
            this.btnAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatus.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnStatus.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStatus.IconSize = 32;
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(0, 90);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStatus.Rotation = 0D;
            this.btnStatus.Size = new System.Drawing.Size(220, 50);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "STATUS REPORT";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(102)))), ((int)(((byte)(146)))));
            this.iconButton1.BackgroundImage = global::GPSTrack.Properties.Resources.logo;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(102)))), ((int)(((byte)(146)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(2, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(217, 84);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(102)))), ((int)(((byte)(146)))));
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnMax);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lbTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(779, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(102)))), ((int)(((byte)(146)))));
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMin.IconSize = 16;
            this.btnMin.Location = new System.Drawing.Point(698, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Rotation = 0D;
            this.btnMin.Size = new System.Drawing.Size(27, 34);
            this.btnMin.TabIndex = 4;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(102)))), ((int)(((byte)(146)))));
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.btnMax.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMax.IconSize = 16;
            this.btnMax.Location = new System.Drawing.Point(727, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Rotation = 0D;
            this.btnMax.Size = new System.Drawing.Size(27, 34);
            this.btnMax.TabIndex = 3;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(102)))), ((int)(((byte)(146)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconSize = 16;
            this.btnExit.Location = new System.Drawing.Point(749, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(27, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTitleChildForm
            // 
            this.lbTitleChildForm.AutoSize = true;
            this.lbTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lbTitleChildForm.Location = new System.Drawing.Point(54, 24);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.Size = new System.Drawing.Size(39, 13);
            this.lbTitleChildForm.TabIndex = 1;
            this.lbTitleChildForm.Text = "HOME";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(102)))), ((int)(((byte)(146)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconCurrentChildForm.IconSize = 41;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(41, 45);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(779, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Location = new System.Drawing.Point(220, 69);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(779, 537);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 64);
            this.label2.TabIndex = 2;
            this.label2.Text = "San Dionisio 140-A\r\nCol. Jardines de San Ignacio\r\nZapopan, Jal. México. 45040\r\nww" +
    "w.anxo.com.mx";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(460, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 80);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ofna: +52 (33) 3817 2700";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(999, 606);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnMain;
        private FontAwesome.Sharp.IconButton btnCrash;
        private FontAwesome.Sharp.IconButton btnMessage;
        private FontAwesome.Sharp.IconButton btnTravel;
        private FontAwesome.Sharp.IconButton btnExt;
        private FontAwesome.Sharp.IconButton btnExternal;
        private FontAwesome.Sharp.IconButton btnKeep;
        private FontAwesome.Sharp.IconButton btnAlert;
        private FontAwesome.Sharp.IconButton btnStatus;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lbTitleChildForm;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

