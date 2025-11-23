namespace DVLD_Project.International_Licence
{
    partial class frmHandleInternationalLicence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandleInternationalLicence));
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Filter = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_SearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_ShowLicenceHistory = new System.Windows.Forms.LinkLabel();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_CreatedBy = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lb_AppDate = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_Fees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_LocalLicenceID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_AppID = new System.Windows.Forms.Label();
            this.lb_IssueDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ExpirationDate = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_InternationalLicenceID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_ShowLicenceInfo = new System.Windows.Forms.LinkLabel();
            this.cuc_LicenceDetails1 = new DVLD_Project.User_Controls.cuc_LicenceDetails();
            this.gb_Filter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(264, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "International Licence Application";
            // 
            // gb_Filter
            // 
            this.gb_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Filter.Controls.Add(this.btn_Search);
            this.gb_Filter.Controls.Add(this.tb_SearchBox);
            this.gb_Filter.Controls.Add(this.label2);
            this.gb_Filter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Filter.Location = new System.Drawing.Point(14, 33);
            this.gb_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Filter.Name = "gb_Filter";
            this.gb_Filter.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Filter.Size = new System.Drawing.Size(844, 61);
            this.gb_Filter.TabIndex = 3;
            this.gb_Filter.TabStop = false;
            this.gb_Filter.Text = "Filter";
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lb_CreatedBy);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.lb_ExpirationDate);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.lb_IssueDate);
            this.groupBox2.Controls.Add(this.lb_AppDate);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lb_Fees);
            this.groupBox2.Controls.Add(this.lb_InternationalLicenceID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_LocalLicenceID);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lb_AppID);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 357);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(842, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info";
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
            this.btn_Save.Location = new System.Drawing.Point(757, 499);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 35);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "        Save";
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
            this.btn_Close.Location = new System.Drawing.Point(662, 499);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(91, 35);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "        Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_ShowLicenceHistory
            // 
            this.lb_ShowLicenceHistory.AutoSize = true;
            this.lb_ShowLicenceHistory.Enabled = false;
            this.lb_ShowLicenceHistory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowLicenceHistory.Location = new System.Drawing.Point(13, 506);
            this.lb_ShowLicenceHistory.Name = "lb_ShowLicenceHistory";
            this.lb_ShowLicenceHistory.Size = new System.Drawing.Size(133, 16);
            this.lb_ShowLicenceHistory.TabIndex = 78;
            this.lb_ShowLicenceHistory.TabStop = true;
            this.lb_ShowLicenceHistory.Text = "Show Licence History";
            this.lb_ShowLicenceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_ShowLicenceHistory_LinkClicked);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(396, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 67;
            this.label19.Text = "Created By:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 16);
            this.label17.TabIndex = 64;
            this.label17.Text = "Application Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Fees:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD_Project.Properties.Resources.username;
            this.pictureBox9.Location = new System.Drawing.Point(519, 103);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(23, 22);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 76;
            this.pictureBox9.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Local Licence ID:";
            // 
            // lb_CreatedBy
            // 
            this.lb_CreatedBy.AutoSize = true;
            this.lb_CreatedBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CreatedBy.Location = new System.Drawing.Point(548, 106);
            this.lb_CreatedBy.Name = "lb_CreatedBy";
            this.lb_CreatedBy.Size = new System.Drawing.Size(29, 16);
            this.lb_CreatedBy.TabIndex = 57;
            this.lb_CreatedBy.Text = "N/N";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_Project.Properties.Resources.calendar_week__1_;
            this.pictureBox7.Location = new System.Drawing.Point(144, 44);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 22);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 72;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Project.Properties.Resources.currency_dollar_sign;
            this.pictureBox4.Location = new System.Drawing.Point(144, 103);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 77;
            this.pictureBox4.TabStop = false;
            // 
            // lb_AppDate
            // 
            this.lb_AppDate.AutoSize = true;
            this.lb_AppDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppDate.Location = new System.Drawing.Point(173, 47);
            this.lb_AppDate.Name = "lb_AppDate";
            this.lb_AppDate.Size = new System.Drawing.Size(29, 16);
            this.lb_AppDate.TabIndex = 56;
            this.lb_AppDate.Text = "N/N";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox3.Location = new System.Drawing.Point(519, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // lb_Fees
            // 
            this.lb_Fees.AutoSize = true;
            this.lb_Fees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fees.Location = new System.Drawing.Point(173, 106);
            this.lb_Fees.Name = "lb_Fees";
            this.lb_Fees.Size = new System.Drawing.Size(29, 16);
            this.lb_Fees.TabIndex = 58;
            this.lb_Fees.Text = "N/N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "I.L.Application ID:";
            // 
            // lb_LocalLicenceID
            // 
            this.lb_LocalLicenceID.AutoSize = true;
            this.lb_LocalLicenceID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LocalLicenceID.Location = new System.Drawing.Point(548, 47);
            this.lb_LocalLicenceID.Name = "lb_LocalLicenceID";
            this.lb_LocalLicenceID.Size = new System.Drawing.Size(29, 16);
            this.lb_LocalLicenceID.TabIndex = 68;
            this.lb_LocalLicenceID.Text = "N/N";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox2.Location = new System.Drawing.Point(144, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // lb_AppID
            // 
            this.lb_AppID.AutoSize = true;
            this.lb_AppID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppID.Location = new System.Drawing.Point(173, 19);
            this.lb_AppID.Name = "lb_AppID";
            this.lb_AppID.Size = new System.Drawing.Size(29, 16);
            this.lb_AppID.TabIndex = 54;
            this.lb_AppID.Text = "N/N";
            // 
            // lb_IssueDate
            // 
            this.lb_IssueDate.AutoSize = true;
            this.lb_IssueDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IssueDate.Location = new System.Drawing.Point(173, 75);
            this.lb_IssueDate.Name = "lb_IssueDate";
            this.lb_IssueDate.Size = new System.Drawing.Size(29, 16);
            this.lb_IssueDate.TabIndex = 56;
            this.lb_IssueDate.Text = "N/N";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.calendar_week__1_;
            this.pictureBox1.Location = new System.Drawing.Point(144, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Issue Date:";
            // 
            // lb_ExpirationDate
            // 
            this.lb_ExpirationDate.AutoSize = true;
            this.lb_ExpirationDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ExpirationDate.Location = new System.Drawing.Point(548, 75);
            this.lb_ExpirationDate.Name = "lb_ExpirationDate";
            this.lb_ExpirationDate.Size = new System.Drawing.Size(29, 16);
            this.lb_ExpirationDate.TabIndex = 56;
            this.lb_ExpirationDate.Text = "N/N";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD_Project.Properties.Resources.calendar_week__1_;
            this.pictureBox10.Location = new System.Drawing.Point(519, 72);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(23, 22);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 72;
            this.pictureBox10.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "Expiration Date:";
            // 
            // lb_InternationalLicenceID
            // 
            this.lb_InternationalLicenceID.AutoSize = true;
            this.lb_InternationalLicenceID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InternationalLicenceID.Location = new System.Drawing.Point(548, 19);
            this.lb_InternationalLicenceID.Name = "lb_InternationalLicenceID";
            this.lb_InternationalLicenceID.Size = new System.Drawing.Size(29, 16);
            this.lb_InternationalLicenceID.TabIndex = 68;
            this.lb_InternationalLicenceID.Text = "N/N";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox6.Location = new System.Drawing.Point(519, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 70;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(396, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "I.L.Licence ID:";
            // 
            // lb_ShowLicenceInfo
            // 
            this.lb_ShowLicenceInfo.AutoSize = true;
            this.lb_ShowLicenceInfo.Enabled = false;
            this.lb_ShowLicenceInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowLicenceInfo.Location = new System.Drawing.Point(157, 506);
            this.lb_ShowLicenceInfo.Name = "lb_ShowLicenceInfo";
            this.lb_ShowLicenceInfo.Size = new System.Drawing.Size(112, 16);
            this.lb_ShowLicenceInfo.TabIndex = 78;
            this.lb_ShowLicenceInfo.TabStop = true;
            this.lb_ShowLicenceInfo.Text = "Show Licence Info";
            this.lb_ShowLicenceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_ShowLicenceInfo_LinkClicked);
            // 
            // cuc_LicenceDetails1
            // 
            this.cuc_LicenceDetails1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuc_LicenceDetails1.Location = new System.Drawing.Point(12, 95);
            this.cuc_LicenceDetails1.Name = "cuc_LicenceDetails1";
            this.cuc_LicenceDetails1.Size = new System.Drawing.Size(850, 264);
            this.cuc_LicenceDetails1.TabIndex = 1;
            // 
            // HandleInternationalLicenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 540);
            this.Controls.Add(this.lb_ShowLicenceInfo);
            this.Controls.Add(this.lb_ShowLicenceHistory);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_Filter);
            this.Controls.Add(this.cuc_LicenceDetails1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HandleInternationalLicenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding International Licence";
            this.gb_Filter.ResumeLayout(false);
            this.gb_Filter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private User_Controls.cuc_LicenceDetails cuc_LicenceDetails1;
        private System.Windows.Forms.GroupBox gb_Filter;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_SearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.LinkLabel lb_ShowLicenceHistory;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_CreatedBy;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_AppDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_Fees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_LocalLicenceID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_AppID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_ExpirationDate;
        private System.Windows.Forms.Label lb_IssueDate;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lb_InternationalLicenceID;
        private System.Windows.Forms.LinkLabel lb_ShowLicenceInfo;
    }
}