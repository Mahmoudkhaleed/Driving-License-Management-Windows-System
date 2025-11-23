namespace DVLD_Project
{
    partial class frmLocalDrivingLicenceApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDrivingLicenceApp));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SearchBox = new System.Windows.Forms.TextBox();
            this.btn_AddLocalLicenceApp = new System.Windows.Forms.Button();
            this.lb_totalApps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_LocalDrivingLicencesApps = new System.Windows.Forms.DataGridView();
            this.cms_HandleLocalApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SechduleTeststoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTesttoolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicencesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cob_Filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cob_IsAcive = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalDrivingLicencesApps)).BeginInit();
            this.cms_HandleLocalApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Local Driving Licence Applications";
            // 
            // tb_SearchBox
            // 
            this.tb_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchBox.Location = new System.Drawing.Point(224, 210);
            this.tb_SearchBox.Name = "tb_SearchBox";
            this.tb_SearchBox.Size = new System.Drawing.Size(148, 21);
            this.tb_SearchBox.TabIndex = 61;
            this.tb_SearchBox.Visible = false;
            this.tb_SearchBox.TextChanged += new System.EventHandler(this.tb_SearchBox_TextChanged);
            // 
            // btn_AddLocalLicenceApp
            // 
            this.btn_AddLocalLicenceApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddLocalLicenceApp.BackColor = System.Drawing.Color.White;
            this.btn_AddLocalLicenceApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddLocalLicenceApp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddLocalLicenceApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddLocalLicenceApp.Location = new System.Drawing.Point(709, 200);
            this.btn_AddLocalLicenceApp.Name = "btn_AddLocalLicenceApp";
            this.btn_AddLocalLicenceApp.Size = new System.Drawing.Size(212, 32);
            this.btn_AddLocalLicenceApp.TabIndex = 59;
            this.btn_AddLocalLicenceApp.Text = "        Add Local Licence App";
            this.btn_AddLocalLicenceApp.UseVisualStyleBackColor = false;
            this.btn_AddLocalLicenceApp.Click += new System.EventHandler(this.btn_AddLocalLicenceApp_Click);
            // 
            // lb_totalApps
            // 
            this.lb_totalApps.AutoSize = true;
            this.lb_totalApps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalApps.Location = new System.Drawing.Point(137, 465);
            this.lb_totalApps.Name = "lb_totalApps";
            this.lb_totalApps.Size = new System.Drawing.Size(31, 15);
            this.lb_totalApps.TabIndex = 54;
            this.lb_totalApps.Text = "N/N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 55;
            this.label3.Text = "Number of Users:\r\n";
            // 
            // dgv_LocalDrivingLicencesApps
            // 
            this.dgv_LocalDrivingLicencesApps.AllowUserToAddRows = false;
            this.dgv_LocalDrivingLicencesApps.AllowUserToDeleteRows = false;
            this.dgv_LocalDrivingLicencesApps.AllowUserToOrderColumns = true;
            this.dgv_LocalDrivingLicencesApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LocalDrivingLicencesApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_LocalDrivingLicencesApps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_LocalDrivingLicencesApps.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_LocalDrivingLicencesApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LocalDrivingLicencesApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LocalDrivingLicencesApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LocalDrivingLicencesApps.ContextMenuStrip = this.cms_HandleLocalApps;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LocalDrivingLicencesApps.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_LocalDrivingLicencesApps.EnableHeadersVisualStyles = false;
            this.dgv_LocalDrivingLicencesApps.Location = new System.Drawing.Point(12, 240);
            this.dgv_LocalDrivingLicencesApps.Name = "dgv_LocalDrivingLicencesApps";
            this.dgv_LocalDrivingLicencesApps.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LocalDrivingLicencesApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_LocalDrivingLicencesApps.Size = new System.Drawing.Size(909, 204);
            this.dgv_LocalDrivingLicencesApps.TabIndex = 58;
            this.dgv_LocalDrivingLicencesApps.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LocalDrivingLicencesApps_CellContextMenuStripChanged);
            // 
            // cms_HandleLocalApps
            // 
            this.cms_HandleLocalApps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editAppToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.CancelAppToolStripMenuItem,
            this.toolStripSeparator2,
            this.SechduleTeststoolStripMenuItem,
            this.toolStripMenuItem2,
            this.issueDrivingLicenceToolStripMenuItem,
            this.showLicenceToolStripMenuItem,
            this.toolStripMenuItem3,
            this.showPersonLicencesHistoryToolStripMenuItem});
            this.cms_HandleLocalApps.Name = "cms_HandlePerson";
            this.cms_HandleLocalApps.Size = new System.Drawing.Size(283, 338);
            this.cms_HandleLocalApps.Opening += new System.ComponentModel.CancelEventHandler(this.cms_HandleLocalApps_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.clipboard__1_;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(279, 6);
            // 
            // editAppToolStripMenuItem
            // 
            this.editAppToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAppToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.document__1_;
            this.editAppToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editAppToolStripMenuItem.Name = "editAppToolStripMenuItem";
            this.editAppToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.editAppToolStripMenuItem.Text = "Edit Application";
            this.editAppToolStripMenuItem.Click += new System.EventHandler(this.editAppToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.document__3_;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // CancelAppToolStripMenuItem
            // 
            this.CancelAppToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAppToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.document__2_;
            this.CancelAppToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelAppToolStripMenuItem.Name = "CancelAppToolStripMenuItem";
            this.CancelAppToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.CancelAppToolStripMenuItem.Text = "Cancel Application";
            this.CancelAppToolStripMenuItem.Click += new System.EventHandler(this.CancelAppToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
            // 
            // SechduleTeststoolStripMenuItem
            // 
            this.SechduleTeststoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTesttoolStripMenuItem4,
            this.sechduleWrittenTestToolStripMenuItem,
            this.sechduleStreetTestToolStripMenuItem});
            this.SechduleTeststoolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.SechduleTeststoolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.document__4_;
            this.SechduleTeststoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SechduleTeststoolStripMenuItem.Name = "SechduleTeststoolStripMenuItem";
            this.SechduleTeststoolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.SechduleTeststoolStripMenuItem.Text = "Sechdule Tests";
            // 
            // visionTesttoolStripMenuItem4
            // 
            this.visionTesttoolStripMenuItem4.Image = global::DVLD_Project.Properties.Resources.eye;
            this.visionTesttoolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visionTesttoolStripMenuItem4.Name = "visionTesttoolStripMenuItem4";
            this.visionTesttoolStripMenuItem4.Size = new System.Drawing.Size(218, 38);
            this.visionTesttoolStripMenuItem4.Text = "Sechdule Vision Test";
            this.visionTesttoolStripMenuItem4.Click += new System.EventHandler(this.visionTesttoolStripMenuItem4_Click);
            // 
            // sechduleWrittenTestToolStripMenuItem
            // 
            this.sechduleWrittenTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.list__1_;
            this.sechduleWrittenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sechduleWrittenTestToolStripMenuItem.Name = "sechduleWrittenTestToolStripMenuItem";
            this.sechduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.sechduleWrittenTestToolStripMenuItem.Text = "Sechdule Written Test";
            this.sechduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleWrittenTestToolStripMenuItem_Click);
            // 
            // sechduleStreetTestToolStripMenuItem
            // 
            this.sechduleStreetTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.off_road_racing;
            this.sechduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sechduleStreetTestToolStripMenuItem.Name = "sechduleStreetTestToolStripMenuItem";
            this.sechduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.sechduleStreetTestToolStripMenuItem.Text = "Sechdule Street Test";
            this.sechduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(279, 6);
            // 
            // issueDrivingLicenceToolStripMenuItem
            // 
            this.issueDrivingLicenceToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDrivingLicenceToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.id__1_;
            this.issueDrivingLicenceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueDrivingLicenceToolStripMenuItem.Name = "issueDrivingLicenceToolStripMenuItem";
            this.issueDrivingLicenceToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.issueDrivingLicenceToolStripMenuItem.Text = "Issue Driving Licence (First Time)";
            this.issueDrivingLicenceToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenceToolStripMenuItem_Click);
            // 
            // showLicenceToolStripMenuItem
            // 
            this.showLicenceToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLicenceToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.id__4_;
            this.showLicenceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenceToolStripMenuItem.Name = "showLicenceToolStripMenuItem";
            this.showLicenceToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.showLicenceToolStripMenuItem.Text = "Show Licence";
            this.showLicenceToolStripMenuItem.Click += new System.EventHandler(this.showLicenceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(279, 6);
            // 
            // showPersonLicencesHistoryToolStripMenuItem
            // 
            this.showPersonLicencesHistoryToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.showPersonLicencesHistoryToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.id__5_;
            this.showPersonLicencesHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicencesHistoryToolStripMenuItem.Name = "showPersonLicencesHistoryToolStripMenuItem";
            this.showPersonLicencesHistoryToolStripMenuItem.Size = new System.Drawing.Size(282, 38);
            this.showPersonLicencesHistoryToolStripMenuItem.Text = "Show Person Licences History";
            this.showPersonLicencesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicencesHistoryToolStripMenuItem_Click);
            // 
            // cob_Filter
            // 
            this.cob_Filter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_Filter.FormattingEnabled = true;
            this.cob_Filter.Items.AddRange(new object[] {
            "None",
            "L.D.L App ID",
            "National No",
            "Full Name",
            "Status"});
            this.cob_Filter.Location = new System.Drawing.Point(79, 208);
            this.cob_Filter.Name = "cob_Filter";
            this.cob_Filter.Size = new System.Drawing.Size(139, 24);
            this.cob_Filter.TabIndex = 57;
            this.cob_Filter.SelectedIndexChanged += new System.EventHandler(this.cob_Filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Filter By";
            // 
            // cob_IsAcive
            // 
            this.cob_IsAcive.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_IsAcive.FormattingEnabled = true;
            this.cob_IsAcive.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.cob_IsAcive.Location = new System.Drawing.Point(224, 178);
            this.cob_IsAcive.Name = "cob_IsAcive";
            this.cob_IsAcive.Size = new System.Drawing.Size(139, 24);
            this.cob_IsAcive.TabIndex = 57;
            this.cob_IsAcive.Visible = false;
            this.cob_IsAcive.SelectedIndexChanged += new System.EventHandler(this.cob_Statuses_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.home__1_;
            this.pictureBox3.Location = new System.Drawing.Point(713, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btn_AddLocalLicenceApp_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::DVLD_Project.Properties.Resources.close__1_;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(829, 456);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 32);
            this.btn_close.TabIndex = 60;
            this.btn_close.Text = "        Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.home__1_;
            this.pictureBox2.Location = new System.Drawing.Point(496, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Screenshot_2025_05_31_232423;
            this.pictureBox1.Location = new System.Drawing.Point(407, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // frmLocalDrivingLicenceApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 497);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tb_SearchBox);
            this.Controls.Add(this.btn_AddLocalLicenceApp);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_totalApps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_LocalDrivingLicencesApps);
            this.Controls.Add(this.cob_IsAcive);
            this.Controls.Add(this.cob_Filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLocalDrivingLicenceApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving Licence Applications";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalDrivingLicencesApps)).EndInit();
            this.cms_HandleLocalApps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_SearchBox;
        private System.Windows.Forms.Button btn_AddLocalLicenceApp;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_totalApps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_LocalDrivingLicencesApps;
        private System.Windows.Forms.ComboBox cob_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cob_IsAcive;
        private System.Windows.Forms.ContextMenuStrip cms_HandleLocalApps;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SechduleTeststoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicencesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTesttoolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sechduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleStreetTestToolStripMenuItem;
    }
}