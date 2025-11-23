namespace DVLD_Project.User_Controls
{
    partial class cuc_SearchForPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cuc_PersonCard1 = new DVLD_Project.cuc_PersonCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddNewPerson = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_SearchBox = new System.Windows.Forms.TextBox();
            this.cob_Filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuc_PersonCard1
            // 
            this.cuc_PersonCard1.BackColor = System.Drawing.Color.White;
            this.cuc_PersonCard1.Location = new System.Drawing.Point(6, 60);
            this.cuc_PersonCard1.Name = "cuc_PersonCard1";
            this.cuc_PersonCard1.Size = new System.Drawing.Size(762, 268);
            this.cuc_PersonCard1.TabIndex = 0;
            this.cuc_PersonCard1.Load += new System.EventHandler(this.cuc_PersonCard1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddNewPerson);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.tb_SearchBox);
            this.groupBox1.Controls.Add(this.cob_Filter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(755, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btn_AddNewPerson
            // 
            this.btn_AddNewPerson.BackColor = System.Drawing.Color.White;
            this.btn_AddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewPerson.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewPerson.Image = global::DVLD_Project.Properties.Resources.user_add1;
            this.btn_AddNewPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddNewPerson.Location = new System.Drawing.Point(452, 16);
            this.btn_AddNewPerson.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddNewPerson.Name = "btn_AddNewPerson";
            this.btn_AddNewPerson.Size = new System.Drawing.Size(154, 35);
            this.btn_AddNewPerson.TabIndex = 17;
            this.btn_AddNewPerson.Text = "        Add New Person";
            this.btn_AddNewPerson.UseVisualStyleBackColor = false;
            this.btn_AddNewPerson.Click += new System.EventHandler(this.btn_AddNewPerson_Click);
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
            this.tb_SearchBox.Location = new System.Drawing.Point(206, 22);
            this.tb_SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SearchBox.Name = "tb_SearchBox";
            this.tb_SearchBox.Size = new System.Drawing.Size(123, 22);
            this.tb_SearchBox.TabIndex = 9;
            this.tb_SearchBox.TextChanged += new System.EventHandler(this.tb_SearchBox_TextChanged);
            this.tb_SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SearchBox_KeyDown);
            // 
            // cob_Filter
            // 
            this.cob_Filter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_Filter.FormattingEnabled = true;
            this.cob_Filter.Items.AddRange(new object[] {
            "Person ID",
            "National No."});
            this.cob_Filter.Location = new System.Drawing.Point(85, 21);
            this.cob_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.cob_Filter.Name = "cob_Filter";
            this.cob_Filter.Size = new System.Drawing.Size(116, 24);
            this.cob_Filter.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter By";
            // 
            // cuc_SearchForPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cuc_PersonCard1);
            this.Name = "cuc_SearchForPerson";
            this.Size = new System.Drawing.Size(771, 328);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private cuc_PersonCard cuc_PersonCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddNewPerson;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_SearchBox;
        private System.Windows.Forms.ComboBox cob_Filter;
        private System.Windows.Forms.Label label2;
    }
}
