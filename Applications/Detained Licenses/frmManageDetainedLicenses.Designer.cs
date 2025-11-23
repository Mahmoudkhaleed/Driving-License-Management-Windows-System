namespace DVLD_Project.Detained_Licenses
{
    partial class frmManageDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicenses));
            this.cob_IsReleased = new System.Windows.Forms.ComboBox();
            this.cob_Filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SearchBox = new System.Windows.Forms.TextBox();
            this.btn_Detain = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_ManageDetained = new System.Windows.Forms.DataGridView();
            this.cmc_InternationalLApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Release = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageDetained)).BeginInit();
            this.cmc_InternationalLApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cob_IsReleased
            // 
            this.cob_IsReleased.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_IsReleased.FormattingEnabled = true;
            this.cob_IsReleased.Items.AddRange(new object[] {
            "All",
            "Released",
            "Not Released"});
            this.cob_IsReleased.Location = new System.Drawing.Point(224, 171);
            this.cob_IsReleased.Name = "cob_IsReleased";
            this.cob_IsReleased.Size = new System.Drawing.Size(139, 24);
            this.cob_IsReleased.TabIndex = 69;
            this.cob_IsReleased.Visible = false;
            this.cob_IsReleased.SelectedIndexChanged += new System.EventHandler(this.cob_IsReleased_SelectedIndexChanged);
            // 
            // cob_Filter
            // 
            this.cob_Filter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_Filter.FormattingEnabled = true;
            this.cob_Filter.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "License ID",
            "National No",
            "Is Released"});
            this.cob_Filter.Location = new System.Drawing.Point(79, 201);
            this.cob_Filter.Name = "cob_Filter";
            this.cob_Filter.Size = new System.Drawing.Size(139, 24);
            this.cob_Filter.TabIndex = 70;
            this.cob_Filter.SelectedIndexChanged += new System.EventHandler(this.cob_Filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 68;
            this.label2.Text = "Filter By";
            // 
            // tb_SearchBox
            // 
            this.tb_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchBox.Location = new System.Drawing.Point(224, 203);
            this.tb_SearchBox.Name = "tb_SearchBox";
            this.tb_SearchBox.Size = new System.Drawing.Size(148, 21);
            this.tb_SearchBox.TabIndex = 74;
            this.tb_SearchBox.Visible = false;
            this.tb_SearchBox.TextChanged += new System.EventHandler(this.tb_SearchBox_TextChanged);
            // 
            // btn_Detain
            // 
            this.btn_Detain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Detain.BackColor = System.Drawing.Color.White;
            this.btn_Detain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detain.Image = global::DVLD_Project.Properties.Resources.hand_open2;
            this.btn_Detain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Detain.Location = new System.Drawing.Point(689, 195);
            this.btn_Detain.Name = "btn_Detain";
            this.btn_Detain.Size = new System.Drawing.Size(113, 32);
            this.btn_Detain.TabIndex = 72;
            this.btn_Detain.Text = "        Detain";
            this.btn_Detain.UseVisualStyleBackColor = false;
            this.btn_Detain.Click += new System.EventHandler(this.btn_Detain_Click);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(83, 458);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(31, 15);
            this.lb_total.TabIndex = 66;
            this.lb_total.Text = "N/N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 67;
            this.label3.Text = "Records:\r\n";
            // 
            // dgv_ManageDetained
            // 
            this.dgv_ManageDetained.AllowUserToAddRows = false;
            this.dgv_ManageDetained.AllowUserToDeleteRows = false;
            this.dgv_ManageDetained.AllowUserToOrderColumns = true;
            this.dgv_ManageDetained.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ManageDetained.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ManageDetained.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ManageDetained.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_ManageDetained.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ManageDetained.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ManageDetained.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManageDetained.ContextMenuStrip = this.cmc_InternationalLApp;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ManageDetained.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ManageDetained.EnableHeadersVisualStyles = false;
            this.dgv_ManageDetained.Location = new System.Drawing.Point(12, 233);
            this.dgv_ManageDetained.Name = "dgv_ManageDetained";
            this.dgv_ManageDetained.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ManageDetained.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ManageDetained.Size = new System.Drawing.Size(909, 196);
            this.dgv_ManageDetained.TabIndex = 71;
            this.dgv_ManageDetained.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ManageDetained_CellFormatting);
            // 
            // cmc_InternationalLApp
            // 
            this.cmc_InternationalLApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personDetailsToolStripMenuItem,
            this.showLicenceDetailsToolStripMenuItem,
            this.showPersonLicenceHistoryToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.cmc_InternationalLApp.Name = "cms_HandlePerson";
            this.cmc_InternationalLApp.Size = new System.Drawing.Size(262, 156);
            // 
            // personDetailsToolStripMenuItem
            // 
            this.personDetailsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.username;
            this.personDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personDetailsToolStripMenuItem.Name = "personDetailsToolStripMenuItem";
            this.personDetailsToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.personDetailsToolStripMenuItem.Text = "Show Person Details";
            this.personDetailsToolStripMenuItem.Click += new System.EventHandler(this.personDetailsToolStripMenuItem_Click);
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
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.hand_share__1_;
            this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::DVLD_Project.Properties.Resources.close__1_;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(829, 449);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 32);
            this.btn_close.TabIndex = 73;
            this.btn_close.Text = "        Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.manageDetained;
            this.pictureBox1.Location = new System.Drawing.Point(369, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Release
            // 
            this.btn_Release.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Release.BackColor = System.Drawing.Color.White;
            this.btn_Release.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Release.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Release.Image = global::DVLD_Project.Properties.Resources.hand_share__1_;
            this.btn_Release.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Release.Location = new System.Drawing.Point(808, 195);
            this.btn_Release.Name = "btn_Release";
            this.btn_Release.Size = new System.Drawing.Size(113, 32);
            this.btn_Release.TabIndex = 72;
            this.btn_Release.Text = "        Release";
            this.btn_Release.UseVisualStyleBackColor = false;
            this.btn_Release.Click += new System.EventHandler(this.btn_Release_Click);
            // 
            // frmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 490);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cob_IsReleased);
            this.Controls.Add(this.cob_Filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_SearchBox);
            this.Controls.Add(this.btn_Release);
            this.Controls.Add(this.btn_Detain);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_ManageDetained);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManageDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detained Licenses";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageDetained)).EndInit();
            this.cmc_InternationalLApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cob_IsReleased;
        private System.Windows.Forms.ComboBox cob_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_SearchBox;
        private System.Windows.Forms.Button btn_Detain;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_ManageDetained;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Release;
        private System.Windows.Forms.ContextMenuStrip cmc_InternationalLApp;
        private System.Windows.Forms.ToolStripMenuItem personDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenceHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}