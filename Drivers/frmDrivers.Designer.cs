namespace DVLD_Project
{
    partial class frmDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivers));
            this.lb_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Drivers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_SearchBox = new System.Windows.Forms.TextBox();
            this.cob_Filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmc_HandleDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAppTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmc_HandleDrivers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(132, 440);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(31, 15);
            this.lb_total.TabIndex = 72;
            this.lb_total.Text = "N/N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "Drivers Number:\r\n";
            // 
            // dgv_Drivers
            // 
            this.dgv_Drivers.AllowUserToAddRows = false;
            this.dgv_Drivers.AllowUserToDeleteRows = false;
            this.dgv_Drivers.AllowUserToOrderColumns = true;
            this.dgv_Drivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Drivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Drivers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Drivers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Drivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Drivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Drivers.ContextMenuStrip = this.cmc_HandleDrivers;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Drivers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Drivers.EnableHeadersVisualStyles = false;
            this.dgv_Drivers.Location = new System.Drawing.Point(12, 176);
            this.dgv_Drivers.Name = "dgv_Drivers";
            this.dgv_Drivers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Drivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Drivers.Size = new System.Drawing.Size(789, 249);
            this.dgv_Drivers.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Drivers";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::DVLD_Project.Properties.Resources.close__1_;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(709, 431);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 32);
            this.btn_close.TabIndex = 75;
            this.btn_close.Text = "        Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Driver;
            this.pictureBox1.Location = new System.Drawing.Point(341, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // tb_SearchBox
            // 
            this.tb_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchBox.Location = new System.Drawing.Point(224, 149);
            this.tb_SearchBox.Name = "tb_SearchBox";
            this.tb_SearchBox.Size = new System.Drawing.Size(148, 21);
            this.tb_SearchBox.TabIndex = 78;
            this.tb_SearchBox.Visible = false;
            this.tb_SearchBox.TextChanged += new System.EventHandler(this.tb_SearchBox_TextChanged);
            // 
            // cob_Filter
            // 
            this.cob_Filter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_Filter.FormattingEnabled = true;
            this.cob_Filter.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.cob_Filter.Location = new System.Drawing.Point(79, 149);
            this.cob_Filter.Name = "cob_Filter";
            this.cob_Filter.Size = new System.Drawing.Size(139, 24);
            this.cob_Filter.TabIndex = 77;
            this.cob_Filter.SelectedIndexChanged += new System.EventHandler(this.cob_Filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 76;
            this.label2.Text = "Filter By";
            // 
            // cmc_HandleDrivers
            // 
            this.cmc_HandleDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAppTypeToolStripMenuItem,
            this.showPersonLicenceHistoryToolStripMenuItem});
            this.cmc_HandleDrivers.Name = "cms_HandlePerson";
            this.cmc_HandleDrivers.Size = new System.Drawing.Size(262, 102);
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
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 468);
            this.Controls.Add(this.tb_SearchBox);
            this.Controls.Add(this.cob_Filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_Drivers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DriversForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmc_HandleDrivers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Drivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SearchBox;
        private System.Windows.Forms.ComboBox cob_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmc_HandleDrivers;
        private System.Windows.Forms.ToolStripMenuItem EditAppTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenceHistoryToolStripMenuItem;
    }
}