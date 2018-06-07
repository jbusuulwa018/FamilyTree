namespace EntityFrmMSAccess
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imglst = new System.Windows.Forms.ImageList(this.components);
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddChildRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddNewRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchFstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearchFstName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSecionID = new System.Windows.Forms.Label();
            this.txtSectionID = new System.Windows.Forms.TextBox();
            this.lblPictName = new System.Windows.Forms.Label();
            this.cmbParent = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.bxPicture = new System.Windows.Forms.PictureBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.textDOB = new System.Windows.Forms.TextBox();
            this.lblDOD = new System.Windows.Forms.Label();
            this.textDOD = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.grgNote = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtResidence = new System.Windows.Forms.TextBox();
            this.lblResidence = new System.Windows.Forms.Label();
            this.btnAddNew1 = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bxPicture)).BeginInit();
            this.grgNote.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imglst
            // 
            this.imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst.ImageStream")));
            this.imglst.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst.Images.SetKeyName(0, "house_one.png");
            this.imglst.Images.SetKeyName(1, "group.png");
            this.imglst.Images.SetKeyName(2, "user_oldman_black.png");
            this.imglst.Images.SetKeyName(3, "user_oldwoman_black.png");
            this.imglst.Images.SetKeyName(4, "user.png");
            this.imglst.Images.SetKeyName(5, "user_female.png");
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(59, 640);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(630, 16);
            this.txtPath.TabIndex = 2;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(10, 640);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(43, 16);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddNew1);
            this.panel1.Controls.Add(this.btnSave1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.grgNote);
            this.panel1.Controls.Add(this.lblPath);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grpSearch);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(22, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 677);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(46, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 16);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Last Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(128, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 21);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddChildRootToolStripMenuItem,
            this.RenameToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 70);
            // 
            // AddChildRootToolStripMenuItem
            // 
            this.AddChildRootToolStripMenuItem.Name = "AddChildRootToolStripMenuItem";
            this.AddChildRootToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.AddChildRootToolStripMenuItem.Text = "Add Child node ";
            this.AddChildRootToolStripMenuItem.Click += new System.EventHandler(this.AddChildRootToolStripMenuItem_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.RenameToolStripMenuItem.Text = "Rename";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewRootToolStripMenuItem,
            this.RefreshToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(155, 48);
            // 
            // AddNewRootToolStripMenuItem
            // 
            this.AddNewRootToolStripMenuItem.Name = "AddNewRootToolStripMenuItem";
            this.AddNewRootToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddNewRootToolStripMenuItem.Text = "Add Root node";
            this.AddNewRootToolStripMenuItem.Click += new System.EventHandler(this.AddNewRootToolStripMenuItem_Click);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(402, 0);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl1.TabIndex = 7;
            this.metroUserControl1.UseSelectable = true;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(513, 60);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(286, 76);
            this.grpSearch.TabIndex = 32;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search by Last Name";
            // 
            // txtSearchFstName
            // 
            this.txtSearchFstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFstName.Location = new System.Drawing.Point(128, 30);
            this.txtSearchFstName.Name = "txtSearchFstName";
            this.txtSearchFstName.Size = new System.Drawing.Size(136, 21);
            this.txtSearchFstName.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchFstName);
            this.groupBox1.Controls.Add(this.lblSearchFstName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(513, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 76);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by First Name";
            // 
            // lblSearchFstName
            // 
            this.lblSearchFstName.AutoSize = true;
            this.lblSearchFstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFstName.Location = new System.Drawing.Point(46, 30);
            this.lblSearchFstName.Name = "lblSearchFstName";
            this.lblSearchFstName.Size = new System.Drawing.Size(76, 16);
            this.lblSearchFstName.TabIndex = 8;
            this.lblSearchFstName.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.lblDOD);
            this.groupBox2.Controls.Add(this.textDOD);
            this.groupBox2.Controls.Add(this.lblDOB);
            this.groupBox2.Controls.Add(this.textDOB);
            this.groupBox2.Controls.Add(this.lblSecionID);
            this.groupBox2.Controls.Add(this.txtSectionID);
            this.groupBox2.Controls.Add(this.lblPictName);
            this.groupBox2.Controls.Add(this.cmbParent);
            this.groupBox2.Controls.Add(this.cmbGender);
            this.groupBox2.Controls.Add(this.lblLastName);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.bxPicture);
            this.groupBox2.Controls.Add(this.lblParent);
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.lblFirstName);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(821, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 248);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Information";
            // 
            // lblSecionID
            // 
            this.lblSecionID.AutoSize = true;
            this.lblSecionID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSecionID.Location = new System.Drawing.Point(234, 30);
            this.lblSecionID.Name = "lblSecionID";
            this.lblSecionID.Size = new System.Drawing.Size(34, 16);
            this.lblSecionID.TabIndex = 44;
            this.lblSecionID.Text = "ID #:";
            // 
            // txtSectionID
            // 
            this.txtSectionID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSectionID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSectionID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSectionID.Location = new System.Drawing.Point(316, 32);
            this.txtSectionID.Name = "txtSectionID";
            this.txtSectionID.Size = new System.Drawing.Size(47, 14);
            this.txtSectionID.TabIndex = 43;
            this.txtSectionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPictName
            // 
            this.lblPictName.AutoSize = true;
            this.lblPictName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPictName.Location = new System.Drawing.Point(83, 214);
            this.lblPictName.Name = "lblPictName";
            this.lblPictName.Size = new System.Drawing.Size(41, 15);
            this.lblPictName.TabIndex = 41;
            this.lblPictName.Text = "Name";
            // 
            // cmbParent
            // 
            this.cmbParent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParent.FormattingEnabled = true;
            this.cmbParent.Location = new System.Drawing.Point(290, 144);
            this.cmbParent.Name = "cmbParent";
            this.cmbParent.Size = new System.Drawing.Size(157, 23);
            this.cmbParent.TabIndex = 40;
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(340, 117);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(107, 23);
            this.cmbGender.TabIndex = 39;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(234, 94);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 16);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(316, 91);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(131, 21);
            this.txtLastName.TabIndex = 37;
            // 
            // bxPicture
            // 
            this.bxPicture.Location = new System.Drawing.Point(26, 31);
            this.bxPicture.Name = "bxPicture";
            this.bxPicture.Size = new System.Drawing.Size(180, 180);
            this.bxPicture.TabIndex = 36;
            this.bxPicture.TabStop = false;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(234, 144);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(50, 16);
            this.lblParent.TabIndex = 35;
            this.lblParent.Text = "Parent:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(234, 117);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 34;
            this.lblGender.Text = "Gender:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(234, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 16);
            this.lblFirstName.TabIndex = 33;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(316, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 21);
            this.txtFirstName.TabIndex = 32;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(234, 180);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(83, 16);
            this.lblDOB.TabIndex = 49;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // textDOB
            // 
            this.textDOB.Location = new System.Drawing.Point(339, 175);
            this.textDOB.Name = "textDOB";
            this.textDOB.Size = new System.Drawing.Size(89, 21);
            this.textDOB.TabIndex = 48;
            // 
            // lblDOD
            // 
            this.lblDOD.AutoSize = true;
            this.lblDOD.Location = new System.Drawing.Point(235, 207);
            this.lblDOD.Name = "lblDOD";
            this.lblDOD.Size = new System.Drawing.Size(96, 16);
            this.lblDOD.TabIndex = 53;
            this.lblDOD.Text = "Deceaded On:";
            // 
            // textDOD
            // 
            this.textDOD.Location = new System.Drawing.Point(341, 202);
            this.textDOD.Name = "textDOD";
            this.textDOD.Size = new System.Drawing.Size(89, 21);
            this.textDOD.TabIndex = 52;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(434, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(12, 21);
            this.dateTimePicker1.TabIndex = 58;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(435, 202);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(12, 21);
            this.dateTimePicker2.TabIndex = 59;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // grgNote
            // 
            this.grgNote.Controls.Add(this.richTextBox1);
            this.grgNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.grgNote.Location = new System.Drawing.Point(821, 426);
            this.grgNote.Name = "grgNote";
            this.grgNote.Size = new System.Drawing.Size(465, 201);
            this.grgNote.TabIndex = 35;
            this.grgNote.TabStop = false;
            this.grgNote.Text = "Life Story";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(19, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(428, 150);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDistrict);
            this.groupBox3.Controls.Add(this.txtDistrict);
            this.groupBox3.Controls.Add(this.lblCounty);
            this.groupBox3.Controls.Add(this.txtCounty);
            this.groupBox3.Controls.Add(this.txtResidence);
            this.groupBox3.Controls.Add(this.lblResidence);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.groupBox3.Location = new System.Drawing.Point(821, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 106);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Place of Residence";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(16, 76);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(51, 16);
            this.lblDistrict.TabIndex = 65;
            this.lblDistrict.Text = "District:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(238, 73);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(202, 21);
            this.txtDistrict.TabIndex = 64;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(235, 28);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(124, 16);
            this.lblCounty.TabIndex = 63;
            this.lblCounty.Text = "County/Sub County:";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(238, 47);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(202, 21);
            this.txtCounty.TabIndex = 62;
            // 
            // txtResidence
            // 
            this.txtResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidence.Location = new System.Drawing.Point(19, 48);
            this.txtResidence.Name = "txtResidence";
            this.txtResidence.Size = new System.Drawing.Size(187, 21);
            this.txtResidence.TabIndex = 61;
            // 
            // lblResidence
            // 
            this.lblResidence.AutoSize = true;
            this.lblResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidence.Location = new System.Drawing.Point(16, 25);
            this.lblResidence.Name = "lblResidence";
            this.lblResidence.Size = new System.Drawing.Size(94, 16);
            this.lblResidence.TabIndex = 60;
            this.lblResidence.Text = "Town(Village):";
            // 
            // btnAddNew1
            // 
            this.btnAddNew1.Location = new System.Drawing.Point(1059, 633);
            this.btnAddNew1.Name = "btnAddNew1";
            this.btnAddNew1.Size = new System.Drawing.Size(93, 23);
            this.btnAddNew1.TabIndex = 61;
            this.btnAddNew1.Text = "Add New";
            this.btnAddNew1.UseVisualStyleBackColor = true;
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(1180, 633);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(106, 23);
            this.btnSave1.TabIndex = 60;
            this.btnSave1.Text = "Update/Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imglst;
            this.treeView1.Location = new System.Drawing.Point(59, 60);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(422, 555);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(42, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 606);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lineage Family Tree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 763);
            this.Controls.Add(this.metroUserControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bxPicture)).EndInit();
            this.grgNote.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imglst;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem AddChildRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDOD;
        private System.Windows.Forms.TextBox textDOD;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox textDOB;
        private System.Windows.Forms.Label lblSecionID;
        private System.Windows.Forms.TextBox txtSectionID;
        private System.Windows.Forms.Label lblPictName;
        private System.Windows.Forms.ComboBox cmbParent;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.PictureBox bxPicture;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchFstName;
        private System.Windows.Forms.Label lblSearchFstName;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox grgNote;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAddNew1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtResidence;
        private System.Windows.Forms.Label lblResidence;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}