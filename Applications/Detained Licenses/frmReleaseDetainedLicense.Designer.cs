namespace DVLD_Project.Detained_Licenses
{
    partial class frmReleaseDetainedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReleaseDetainedLicense));
            this.lb_ShowLicenceInfo = new System.Windows.Forms.LinkLabel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_ShowLicenceHistory = new System.Windows.Forms.LinkLabel();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_CreatedBy = new System.Windows.Forms.Label();
            this.cuc_LicenceDetails1 = new DVLD_Project.User_Controls.cuc_LicenceDetails();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lb_DetainDate = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lb_LicenceID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_DetainID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_SearchBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_FineFees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Filter = new System.Windows.Forms.GroupBox();
            this.lb_AppID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_AppFees = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_TotalFees = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_ReleaseDate = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_ReleasedBy = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gb_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ShowLicenceInfo
            // 
            this.lb_ShowLicenceInfo.AutoSize = true;
            this.lb_ShowLicenceInfo.Enabled = false;
            this.lb_ShowLicenceInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowLicenceInfo.Location = new System.Drawing.Point(169, 500);
            this.lb_ShowLicenceInfo.Name = "lb_ShowLicenceInfo";
            this.lb_ShowLicenceInfo.Size = new System.Drawing.Size(112, 16);
            this.lb_ShowLicenceInfo.TabIndex = 98;
            this.lb_ShowLicenceInfo.TabStop = true;
            this.lb_ShowLicenceInfo.Text = "Show Licence Info";
            this.lb_ShowLicenceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_ShowLicenceInfo_LinkClicked);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = global::DVLD_Project.Properties.Resources.diskette;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(780, 487);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 35);
            this.btn_Save.TabIndex = 95;
            this.btn_Save.Text = "        Release";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = global::DVLD_Project.Properties.Resources.close__2_;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(685, 487);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(91, 35);
            this.btn_Close.TabIndex = 96;
            this.btn_Close.Text = "        Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_ShowLicenceHistory
            // 
            this.lb_ShowLicenceHistory.AutoSize = true;
            this.lb_ShowLicenceHistory.Enabled = false;
            this.lb_ShowLicenceHistory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowLicenceHistory.Location = new System.Drawing.Point(12, 500);
            this.lb_ShowLicenceHistory.Name = "lb_ShowLicenceHistory";
            this.lb_ShowLicenceHistory.Size = new System.Drawing.Size(133, 16);
            this.lb_ShowLicenceHistory.TabIndex = 97;
            this.lb_ShowLicenceHistory.TabStop = true;
            this.lb_ShowLicenceHistory.Text = "Show Licence History";
            this.lb_ShowLicenceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_ShowLicenceHistory_LinkClicked);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(304, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 67;
            this.label19.Text = "Created By:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 16);
            this.label17.TabIndex = 64;
            this.label17.Text = "Detain Date:";
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.Location = new System.Drawing.Point(11, 85);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(73, 16);
            this.labl.TabIndex = 62;
            this.labl.Text = "Fine Fees:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD_Project.Properties.Resources.username;
            this.pictureBox9.Location = new System.Drawing.Point(388, 51);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(23, 22);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 76;
            this.pictureBox9.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(304, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "Licence ID:";
            // 
            // lb_CreatedBy
            // 
            this.lb_CreatedBy.AutoSize = true;
            this.lb_CreatedBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CreatedBy.Location = new System.Drawing.Point(417, 54);
            this.lb_CreatedBy.Name = "lb_CreatedBy";
            this.lb_CreatedBy.Size = new System.Drawing.Size(29, 16);
            this.lb_CreatedBy.TabIndex = 57;
            this.lb_CreatedBy.Text = "N/N";
            // 
            // cuc_LicenceDetails1
            // 
            this.cuc_LicenceDetails1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuc_LicenceDetails1.Location = new System.Drawing.Point(10, 86);
            this.cuc_LicenceDetails1.Name = "cuc_LicenceDetails1";
            this.cuc_LicenceDetails1.Size = new System.Drawing.Size(882, 264);
            this.cuc_LicenceDetails1.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Licence ID:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_Project.Properties.Resources.calendar_week__1_;
            this.pictureBox7.Location = new System.Drawing.Point(150, 54);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 22);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 72;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD_Project.Properties.Resources.currency_dollar_sign;
            this.pictureBox8.Location = new System.Drawing.Point(150, 82);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(23, 22);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 77;
            this.pictureBox8.TabStop = false;
            // 
            // lb_DetainDate
            // 
            this.lb_DetainDate.AutoSize = true;
            this.lb_DetainDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DetainDate.Location = new System.Drawing.Point(179, 57);
            this.lb_DetainDate.Name = "lb_DetainDate";
            this.lb_DetainDate.Size = new System.Drawing.Size(29, 16);
            this.lb_DetainDate.TabIndex = 56;
            this.lb_DetainDate.Text = "N/N";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox6.Location = new System.Drawing.Point(388, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 70;
            this.pictureBox6.TabStop = false;
            // 
            // lb_LicenceID
            // 
            this.lb_LicenceID.AutoSize = true;
            this.lb_LicenceID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LicenceID.Location = new System.Drawing.Point(417, 26);
            this.lb_LicenceID.Name = "lb_LicenceID";
            this.lb_LicenceID.Size = new System.Drawing.Size(29, 16);
            this.lb_LicenceID.TabIndex = 68;
            this.lb_LicenceID.Text = "N/N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Detain ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox2.Location = new System.Drawing.Point(150, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // lb_DetainID
            // 
            this.lb_DetainID.AutoSize = true;
            this.lb_DetainID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DetainID.Location = new System.Drawing.Point(179, 25);
            this.lb_DetainID.Name = "lb_DetainID";
            this.lb_DetainID.Size = new System.Drawing.Size(29, 16);
            this.lb_DetainID.TabIndex = 54;
            this.lb_DetainID.Text = "N/N";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = global::DVLD_Project.Properties.Resources.zoom;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(343, 16);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(105, 35);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "        Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_SearchBox
            // 
            this.tb_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchBox.Location = new System.Drawing.Point(101, 22);
            this.tb_SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SearchBox.Name = "tb_SearchBox";
            this.tb_SearchBox.Size = new System.Drawing.Size(228, 22);
            this.tb_SearchBox.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labl);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.lb_ReleasedBy);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lb_CreatedBy);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.lb_TotalFees);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lb_AppFees);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.lb_ReleaseDate);
            this.groupBox2.Controls.Add(this.lb_FineFees);
            this.groupBox2.Controls.Add(this.lb_DetainDate);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.lb_LicenceID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lb_AppID);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lb_DetainID);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 336);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(875, 143);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info";
            // 
            // lb_FineFees
            // 
            this.lb_FineFees.AutoSize = true;
            this.lb_FineFees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FineFees.Location = new System.Drawing.Point(179, 85);
            this.lb_FineFees.Name = "lb_FineFees";
            this.lb_FineFees.Size = new System.Drawing.Size(29, 16);
            this.lb_FineFees.TabIndex = 56;
            this.lb_FineFees.Text = "N/N";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(329, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Release Detain License";
            // 
            // gb_Filter
            // 
            this.gb_Filter.Controls.Add(this.btn_Search);
            this.gb_Filter.Controls.Add(this.tb_SearchBox);
            this.gb_Filter.Controls.Add(this.label2);
            this.gb_Filter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Filter.Location = new System.Drawing.Point(187, 33);
            this.gb_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Filter.Name = "gb_Filter";
            this.gb_Filter.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Filter.Size = new System.Drawing.Size(455, 61);
            this.gb_Filter.TabIndex = 93;
            this.gb_Filter.TabStop = false;
            this.gb_Filter.Text = "Filter";
            // 
            // lb_AppID
            // 
            this.lb_AppID.AutoSize = true;
            this.lb_AppID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppID.Location = new System.Drawing.Point(682, 29);
            this.lb_AppID.Name = "lb_AppID";
            this.lb_AppID.Size = new System.Drawing.Size(29, 16);
            this.lb_AppID.TabIndex = 54;
            this.lb_AppID.Text = "N/N";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox1.Location = new System.Drawing.Point(653, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Application ID:";
            // 
            // lb_AppFees
            // 
            this.lb_AppFees.AutoSize = true;
            this.lb_AppFees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppFees.Location = new System.Drawing.Point(417, 85);
            this.lb_AppFees.Name = "lb_AppFees";
            this.lb_AppFees.Size = new System.Drawing.Size(29, 16);
            this.lb_AppFees.TabIndex = 56;
            this.lb_AppFees.Text = "N/N";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.currency_dollar_sign;
            this.pictureBox3.Location = new System.Drawing.Point(388, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "App. Fees:";
            // 
            // lb_TotalFees
            // 
            this.lb_TotalFees.AutoSize = true;
            this.lb_TotalFees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalFees.Location = new System.Drawing.Point(682, 113);
            this.lb_TotalFees.Name = "lb_TotalFees";
            this.lb_TotalFees.Size = new System.Drawing.Size(29, 16);
            this.lb_TotalFees.TabIndex = 56;
            this.lb_TotalFees.Text = "N/N";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Project.Properties.Resources.currency_dollar_sign;
            this.pictureBox4.Location = new System.Drawing.Point(653, 110);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 77;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(547, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Total Fees:";
            // 
            // lb_ReleaseDate
            // 
            this.lb_ReleaseDate.AutoSize = true;
            this.lb_ReleaseDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ReleaseDate.Location = new System.Drawing.Point(682, 57);
            this.lb_ReleaseDate.Name = "lb_ReleaseDate";
            this.lb_ReleaseDate.Size = new System.Drawing.Size(29, 16);
            this.lb_ReleaseDate.TabIndex = 56;
            this.lb_ReleaseDate.Text = "N/N";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD_Project.Properties.Resources.calendar_week__1_;
            this.pictureBox10.Location = new System.Drawing.Point(653, 54);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(23, 22);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 72;
            this.pictureBox10.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(547, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 64;
            this.label10.Text = "Release Date:";
            // 
            // lb_ReleasedBy
            // 
            this.lb_ReleasedBy.AutoSize = true;
            this.lb_ReleasedBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ReleasedBy.Location = new System.Drawing.Point(682, 85);
            this.lb_ReleasedBy.Name = "lb_ReleasedBy";
            this.lb_ReleasedBy.Size = new System.Drawing.Size(29, 16);
            this.lb_ReleasedBy.TabIndex = 57;
            this.lb_ReleasedBy.Text = "N/N";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_Project.Properties.Resources.username;
            this.pictureBox5.Location = new System.Drawing.Point(653, 82);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 76;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "Released By:";
            // 
            // ReleaseDetainedLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 532);
            this.Controls.Add(this.gb_Filter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_ShowLicenceInfo);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lb_ShowLicenceHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuc_LicenceDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReleaseDetainedLicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Detained License";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_Filter.ResumeLayout(false);
            this.gb_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lb_ShowLicenceInfo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.LinkLabel lb_ShowLicenceHistory;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_CreatedBy;
        private User_Controls.cuc_LicenceDetails cuc_LicenceDetails1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lb_DetainDate;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lb_LicenceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_DetainID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_SearchBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Filter;
        private System.Windows.Forms.Label lb_FineFees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_TotalFees;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_AppFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_AppID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lb_ReleasedBy;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lb_ReleaseDate;
    }
}