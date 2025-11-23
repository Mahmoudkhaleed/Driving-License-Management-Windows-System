namespace DVLD_Project.International_Licence
{
    partial class frmInternationalLicences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalLicences));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tb_SearchBox = new System.Windows.Forms.TextBox();
            this.btn_AddInternLicenceApp = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_totalApps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_InternDrivingLicencesApps = new System.Windows.Forms.DataGridView();
            this.cob_IsActive = new System.Windows.Forms.ComboBox();
            this.cob_Filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmc_InternationalLApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAppTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternDrivingLicencesApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmc_InternationalLApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.world_africa__1_;
            this.pictureBox3.Location = new System.Drawing.Point(607, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btn_AddInternLicenceApp_Click);
            // 
            // tb_SearchBox
            // 
            this.tb_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchBox.Location = new System.Drawing.Point(224, 198);
            this.tb_SearchBox.Name = "tb_SearchBox";
            this.tb_SearchBox.Size = new System.Drawing.Size(148, 21);
            this.tb_SearchBox.TabIndex = 74;
            this.tb_SearchBox.Visible = false;
            this.tb_SearchBox.TextChanged += new System.EventHandler(this.tb_SearchBox_TextChanged);
            // 
            // btn_AddInternLicenceApp
            // 
            this.btn_AddInternLicenceApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddInternLicenceApp.BackColor = System.Drawing.Color.White;
            this.btn_AddInternLicenceApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddInternLicenceApp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddInternLicenceApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddInternLicenceApp.Location = new System.Drawing.Point(604, 190);
            this.btn_AddInternLicenceApp.Name = "btn_AddInternLicenceApp";
            this.btn_AddInternLicenceApp.Size = new System.Drawing.Size(245, 32);
            this.btn_AddInternLicenceApp.TabIndex = 72;
            this.btn_AddInternLicenceApp.Text = "        Add International Licence App";
            this.btn_AddInternLicenceApp.UseVisualStyleBackColor = false;
            this.btn_AddInternLicenceApp.Click += new System.EventHandler(this.btn_AddInternLicenceApp_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::DVLD_Project.Properties.Resources.close__1_;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(757, 446);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 32);
            this.btn_close.TabIndex = 73;
            this.btn_close.Text = "        Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_totalApps
            // 
            this.lb_totalApps.AutoSize = true;
            this.lb_totalApps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalApps.Location = new System.Drawing.Point(83, 455);
            this.lb_totalApps.Name = "lb_totalApps";
            this.lb_totalApps.Size = new System.Drawing.Size(31, 15);
            this.lb_totalApps.TabIndex = 66;
            this.lb_totalApps.Text = "N/N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 67;
            this.label3.Text = "Records:\r\n";
            // 
            // dgv_InternDrivingLicencesApps
            // 
            this.dgv_InternDrivingLicencesApps.AllowUserToAddRows = false;
            this.dgv_InternDrivingLicencesApps.AllowUserToDeleteRows = false;
            this.dgv_InternDrivingLicencesApps.AllowUserToOrderColumns = true;
            this.dgv_InternDrivingLicencesApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_InternDrivingLicencesApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_InternDrivingLicencesApps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_InternDrivingLicencesApps.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_InternDrivingLicencesApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_InternDrivingLicencesApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_InternDrivingLicencesApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InternDrivingLicencesApps.ContextMenuStrip = this.cmc_InternationalLApp;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_InternDrivingLicencesApps.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_InternDrivingLicencesApps.EnableHeadersVisualStyles = false;
            this.dgv_InternDrivingLicencesApps.Location = new System.Drawing.Point(12, 228);
            this.dgv_InternDrivingLicencesApps.Name = "dgv_InternDrivingLicencesApps";
            this.dgv_InternDrivingLicencesApps.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_InternDrivingLicencesApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_InternDrivingLicencesApps.Size = new System.Drawing.Size(837, 212);
            this.dgv_InternDrivingLicencesApps.TabIndex = 71;
            // 
            // cob_IsActive
            // 
            this.cob_IsActive.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_IsActive.FormattingEnabled = true;
            this.cob_IsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cob_IsActive.Location = new System.Drawing.Point(224, 166);
            this.cob_IsActive.Name = "cob_IsActive";
            this.cob_IsActive.Size = new System.Drawing.Size(139, 24);
            this.cob_IsActive.TabIndex = 69;
            this.cob_IsActive.Visible = false;
            this.cob_IsActive.SelectedIndexChanged += new System.EventHandler(this.cob_IsActive_SelectedIndexChanged);
            // 
            // cob_Filter
            // 
            this.cob_Filter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_Filter.FormattingEnabled = true;
            this.cob_Filter.Items.AddRange(new object[] {
            "None",
            "I.Licence ID",
            "Application ID",
            "Driver ID",
            "Using L.Licence ID",
            "Is Active"});
            this.cob_Filter.Location = new System.Drawing.Point(79, 196);
            this.cob_Filter.Name = "cob_Filter";
            this.cob_Filter.Size = new System.Drawing.Size(139, 24);
            this.cob_Filter.TabIndex = 70;
            this.cob_Filter.SelectedIndexChanged += new System.EventHandler(this.cob_Filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 68;
            this.label2.Text = "Filter By";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.world_africa__1_;
            this.pictureBox2.Location = new System.Drawing.Point(448, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Screenshot_2025_05_31_232423;
            this.pictureBox1.Location = new System.Drawing.Point(359, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "International Driving Licence Applications";
            // 
            // cmc_InternationalLApp
            // 
            this.cmc_InternationalLApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAppTypeToolStripMenuItem,
            this.showLicenceDetailsToolStripMenuItem,
            this.showPersonLicenceHistoryToolStripMenuItem});
            this.cmc_InternationalLApp.Name = "cms_HandlePerson";
            this.cmc_InternationalLApp.Size = new System.Drawing.Size(262, 118);
            // 
            // EditAppTypeToolStripMenuItem
            // 
            this.EditAppTypeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAppTypeToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.username;
            this.EditAppTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditAppTypeToolStripMenuItem.Name = "EditAppTypeToolStripMenuItem";
            this.EditAppTypeToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.EditAppTypeToolStripMenuItem.Text = "Show Person Details";
            this.EditAppTypeToolStripMenuItem.Click += new System.EventHandler(this.EditAppTypeToolStripMenuItem_Click);
            // 
            // showLicenceDetailsToolStripMenuItem
            // 
            this.showLicenceDetailsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.showLicenceDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.id;
            this.showLicenceDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenceDetailsToolStripMenuItem.Name = "showLicenceDetailsToolStripMenuItem";
            this.showLicenceDetailsToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.showLicenceDetailsToolStripMenuItem.Text = "Show Licence Details";
            this.showLicenceDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenceDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenceHistoryToolStripMenuItem
            // 
            this.showPersonLicenceHistoryToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.showPersonLicenceHistoryToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.id__5_;
            this.showPersonLicenceHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenceHistoryToolStripMenuItem.Name = "showPersonLicenceHistoryToolStripMenuItem";
            this.showPersonLicenceHistoryToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.showPersonLicenceHistoryToolStripMenuItem.Text = "Show Person Licence History";
            this.showPersonLicenceHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenceHistoryToolStripMenuItem_Click);
            // 
            // InternationalLicencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 490);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tb_SearchBox);
            this.Controls.Add(this.btn_AddInternLicenceApp);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_totalApps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_InternDrivingLicencesApps);
            this.Controls.Add(this.cob_IsActive);
            this.Controls.Add(this.cob_Filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InternationalLicencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Licences";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternDrivingLicencesApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmc_InternationalLApp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tb_SearchBox;
        private System.Windows.Forms.Button btn_AddInternLicenceApp;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_totalApps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_InternDrivingLicencesApps;
        private System.Windows.Forms.ComboBox cob_IsActive;
        private System.Windows.Forms.ComboBox cob_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmc_InternationalLApp;
        private System.Windows.Forms.ToolStripMenuItem EditAppTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenceHistoryToolStripMenuItem;
    }
}