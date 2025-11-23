namespace DVLD_Project.Local_Driving_Licence
{
    partial class frmLicenceHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenceHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_LocalRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_LocalLicences = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Local = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_InterRecord = new System.Windows.Forms.Label();
            this.dgv_InternationalLicences = new System.Windows.Forms.DataGridView();
            this.cuc_PersonCard2 = new DVLD_Project.cuc_PersonCard();
            this.cmc_LocalLicenceDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LicenceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmc_InternLicenceDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InternLicencrDetailsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalLicences)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_Local.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternationalLicences)).BeginInit();
            this.cmc_LocalLicenceDetails.SuspendLayout();
            this.cmc_InternLicenceDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(313, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Licence History";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::DVLD_Project.Properties.Resources.close__1_;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(687, 527);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 32);
            this.btn_close.TabIndex = 79;
            this.btn_close.Text = "        Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_LocalRecords
            // 
            this.lb_LocalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_LocalRecords.AutoSize = true;
            this.lb_LocalRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LocalRecords.Location = new System.Drawing.Point(77, 150);
            this.lb_LocalRecords.Name = "lb_LocalRecords";
            this.lb_LocalRecords.Size = new System.Drawing.Size(31, 15);
            this.lb_LocalRecords.TabIndex = 76;
            this.lb_LocalRecords.Text = "N/N";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "Records:";
            // 
            // dgv_LocalLicences
            // 
            this.dgv_LocalLicences.AllowUserToAddRows = false;
            this.dgv_LocalLicences.AllowUserToDeleteRows = false;
            this.dgv_LocalLicences.AllowUserToOrderColumns = true;
            this.dgv_LocalLicences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LocalLicences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_LocalLicences.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_LocalLicences.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_LocalLicences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LocalLicences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LocalLicences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LocalLicences.ContextMenuStrip = this.cmc_LocalLicenceDetails;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LocalLicences.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_LocalLicences.EnableHeadersVisualStyles = false;
            this.dgv_LocalLicences.Location = new System.Drawing.Point(0, 0);
            this.dgv_LocalLicences.Name = "dgv_LocalLicences";
            this.dgv_LocalLicences.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LocalLicences.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_LocalLicences.Size = new System.Drawing.Size(760, 147);
            this.dgv_LocalLicences.TabIndex = 78;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tp_Local);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 322);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 199);
            this.tabControl1.TabIndex = 80;
            // 
            // tp_Local
            // 
            this.tp_Local.Controls.Add(this.dgv_LocalLicences);
            this.tp_Local.Controls.Add(this.label3);
            this.tp_Local.Controls.Add(this.lb_LocalRecords);
            this.tp_Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_Local.Location = new System.Drawing.Point(4, 25);
            this.tp_Local.Name = "tp_Local";
            this.tp_Local.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Local.Size = new System.Drawing.Size(763, 170);
            this.tp_Local.TabIndex = 0;
            this.tp_Local.Text = "Local";
            this.tp_Local.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lb_InterRecord);
            this.tabPage2.Controls.Add(this.dgv_InternationalLicences);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 170);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Records:";
            // 
            // lb_InterRecord
            // 
            this.lb_InterRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_InterRecord.AutoSize = true;
            this.lb_InterRecord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InterRecord.Location = new System.Drawing.Point(76, 148);
            this.lb_InterRecord.Name = "lb_InterRecord";
            this.lb_InterRecord.Size = new System.Drawing.Size(31, 15);
            this.lb_InterRecord.TabIndex = 80;
            this.lb_InterRecord.Text = "N/N";
            // 
            // dgv_InternationalLicences
            // 
            this.dgv_InternationalLicences.AllowUserToAddRows = false;
            this.dgv_InternationalLicences.AllowUserToDeleteRows = false;
            this.dgv_InternationalLicences.AllowUserToOrderColumns = true;
            this.dgv_InternationalLicences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_InternationalLicences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_InternationalLicences.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_InternationalLicences.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_InternationalLicences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_InternationalLicences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_InternationalLicences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InternationalLicences.ContextMenuStrip = this.cmc_InternLicenceDetails;
            this.dgv_InternationalLicences.EnableHeadersVisualStyles = false;
            this.dgv_InternationalLicences.Location = new System.Drawing.Point(0, 0);
            this.dgv_InternationalLicences.Name = "dgv_InternationalLicences";
            this.dgv_InternationalLicences.ReadOnly = true;
            this.dgv_InternationalLicences.Size = new System.Drawing.Size(763, 145);
            this.dgv_InternationalLicences.TabIndex = 79;
            // 
            // cuc_PersonCard2
            // 
            this.cuc_PersonCard2.BackColor = System.Drawing.Color.White;
            this.cuc_PersonCard2.Location = new System.Drawing.Point(12, 35);
            this.cuc_PersonCard2.Name = "cuc_PersonCard2";
            this.cuc_PersonCard2.Size = new System.Drawing.Size(771, 283);
            this.cuc_PersonCard2.TabIndex = 81;
            // 
            // cmc_LocalLicenceDetails
            // 
            this.cmc_LocalLicenceDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LicenceDetailsToolStripMenuItem});
            this.cmc_LocalLicenceDetails.Name = "cms_HandlePerson";
            this.cmc_LocalLicenceDetails.Size = new System.Drawing.Size(180, 42);
            // 
            // LicenceDetailsToolStripMenuItem
            // 
            this.LicenceDetailsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenceDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.id;
            this.LicenceDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LicenceDetailsToolStripMenuItem.Name = "LicenceDetailsToolStripMenuItem";
            this.LicenceDetailsToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.LicenceDetailsToolStripMenuItem.Text = "Licence Details";
            this.LicenceDetailsToolStripMenuItem.Click += new System.EventHandler(this.LicenceDetailsToolStripMenuItem_Click);
            // 
            // cmc_InternLicenceDetails
            // 
            this.cmc_InternLicenceDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InternLicencrDetailsStripMenuItem});
            this.cmc_InternLicenceDetails.Name = "cms_HandlePerson";
            this.cmc_InternLicenceDetails.Size = new System.Drawing.Size(197, 64);
            // 
            // InternLicencrDetailsStripMenuItem
            // 
            this.InternLicencrDetailsStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternLicencrDetailsStripMenuItem.Image = global::DVLD_Project.Properties.Resources.id;
            this.InternLicencrDetailsStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InternLicencrDetailsStripMenuItem.Name = "InternLicencrDetailsStripMenuItem";
            this.InternLicencrDetailsStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.InternLicencrDetailsStripMenuItem.Text = "Licence Details";
            this.InternLicencrDetailsStripMenuItem.Click += new System.EventHandler(this.InternLicencrDetailsStripMenuItem_Click);
            // 
            // LicenceHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuc_PersonCard2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LicenceHistoryForm";
            this.Text = "Licence History";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalLicences)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_Local.ResumeLayout(false);
            this.tp_Local.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternationalLicences)).EndInit();
            this.cmc_LocalLicenceDetails.ResumeLayout(false);
            this.cmc_InternLicenceDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_LocalRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_LocalLicences;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Local;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_InternationalLicences;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_InterRecord;
        private cuc_PersonCard cuc_PersonCard2;
        private System.Windows.Forms.ContextMenuStrip cmc_LocalLicenceDetails;
        private System.Windows.Forms.ToolStripMenuItem LicenceDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmc_InternLicenceDetails;
        private System.Windows.Forms.ToolStripMenuItem InternLicencrDetailsStripMenuItem;
    }
}