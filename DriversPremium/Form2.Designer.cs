namespace DriversPremium
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSlikaVozaca = new System.Windows.Forms.PictureBox();
            this.dateTimePickerEXP = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerISS = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.placeOfIssue_txt = new System.Windows.Forms.TextBox();
            this.numberOfLicense_txt = new System.Windows.Forms.TextBox();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.firstName_txt = new System.Windows.Forms.TextBox();
            this.AddPicture_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.DeleteAcategory_btn = new System.Windows.Forms.Button();
            this.AddAnewCategory_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProhibition = new System.Windows.Forms.DataGridView();
            this.DeleteAprohibition_btn = new System.Windows.Forms.Button();
            this.AddAnewProhibition_btn = new System.Windows.Forms.Button();
            this.Create_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaVozaca)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProhibition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EXP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of driver license:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Place of issue:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gender:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBoxSlikaVozaca);
            this.groupBox1.Controls.Add(this.dateTimePickerEXP);
            this.groupBox1.Controls.Add(this.dateTimePickerISS);
            this.groupBox1.Controls.Add(this.dateTimePickerDateOfBirth);
            this.groupBox1.Controls.Add(this.gender_comboBox);
            this.groupBox1.Controls.Add(this.placeOfIssue_txt);
            this.groupBox1.Controls.Add(this.numberOfLicense_txt);
            this.groupBox1.Controls.Add(this.lastName_txt);
            this.groupBox1.Controls.Add(this.firstName_txt);
            this.groupBox1.Controls.Add(this.AddPicture_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal informations";
            // 
            // pictureBoxSlikaVozaca
            // 
            this.pictureBoxSlikaVozaca.Location = new System.Drawing.Point(327, 24);
            this.pictureBoxSlikaVozaca.Name = "pictureBoxSlikaVozaca";
            this.pictureBoxSlikaVozaca.Size = new System.Drawing.Size(105, 119);
            this.pictureBoxSlikaVozaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlikaVozaca.TabIndex = 10;
            this.pictureBoxSlikaVozaca.TabStop = false;
            // 
            // dateTimePickerEXP
            // 
            this.dateTimePickerEXP.Enabled = false;
            this.dateTimePickerEXP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEXP.Location = new System.Drawing.Point(133, 124);
            this.dateTimePickerEXP.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEXP.Name = "dateTimePickerEXP";
            this.dateTimePickerEXP.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerEXP.TabIndex = 5;
            // 
            // dateTimePickerISS
            // 
            this.dateTimePickerISS.Enabled = false;
            this.dateTimePickerISS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerISS.Location = new System.Drawing.Point(133, 99);
            this.dateTimePickerISS.MaxDate = new System.DateTime(2109, 8, 16, 0, 0, 0, 0);
            this.dateTimePickerISS.MinDate = new System.DateTime(1768, 12, 25, 0, 0, 0, 0);
            this.dateTimePickerISS.Name = "dateTimePickerISS";
            this.dateTimePickerISS.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerISS.TabIndex = 4;
            this.dateTimePickerISS.ValueChanged += new System.EventHandler(this.DateTimePickerISS_ValueChanged);
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(133, 74);
            this.dateTimePickerDateOfBirth.MaxDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 3;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.ValueChanged += new System.EventHandler(this.DateTimePickerDateOfBirth_ValueChanged);
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.DisplayMember = "0";
            this.gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_comboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.gender_comboBox.Location = new System.Drawing.Point(133, 199);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(100, 21);
            this.gender_comboBox.Sorted = true;
            this.gender_comboBox.TabIndex = 8;
            // 
            // placeOfIssue_txt
            // 
            this.placeOfIssue_txt.Location = new System.Drawing.Point(133, 174);
            this.placeOfIssue_txt.Name = "placeOfIssue_txt";
            this.placeOfIssue_txt.Size = new System.Drawing.Size(100, 20);
            this.placeOfIssue_txt.TabIndex = 7;
            this.placeOfIssue_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlaceOfIssue_txt_KeyPress);
            // 
            // numberOfLicense_txt
            // 
            this.numberOfLicense_txt.Location = new System.Drawing.Point(133, 149);
            this.numberOfLicense_txt.MaxLength = 9;
            this.numberOfLicense_txt.Name = "numberOfLicense_txt";
            this.numberOfLicense_txt.Size = new System.Drawing.Size(100, 20);
            this.numberOfLicense_txt.TabIndex = 6;
            this.toolTip1.SetToolTip(this.numberOfLicense_txt, "Nine digits");
            this.numberOfLicense_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfLicense_txt_KeyPress);
            // 
            // lastName_txt
            // 
            this.lastName_txt.Location = new System.Drawing.Point(133, 49);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(100, 20);
            this.lastName_txt.TabIndex = 2;
            this.lastName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_txt_KeyPress);
            // 
            // firstName_txt
            // 
            this.firstName_txt.Location = new System.Drawing.Point(133, 24);
            this.firstName_txt.Name = "firstName_txt";
            this.firstName_txt.Size = new System.Drawing.Size(100, 20);
            this.firstName_txt.TabIndex = 1;
            this.firstName_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstName_txt_KeyPress);
            // 
            // AddPicture_btn
            // 
            this.AddPicture_btn.Location = new System.Drawing.Point(327, 152);
            this.AddPicture_btn.Name = "AddPicture_btn";
            this.AddPicture_btn.Size = new System.Drawing.Size(105, 23);
            this.AddPicture_btn.TabIndex = 9;
            this.AddPicture_btn.Text = "Add a picture";
            this.AddPicture_btn.UseVisualStyleBackColor = true;
            this.AddPicture_btn.Click += new System.EventHandler(this.AddPicture_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewCategories);
            this.groupBox2.Controls.Add(this.DeleteAcategory_btn);
            this.groupBox2.Controls.Add(this.AddAnewCategory_btn);
            this.groupBox2.Location = new System.Drawing.Point(13, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categories";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.Size = new System.Drawing.Size(434, 88);
            this.dataGridViewCategories.TabIndex = 0;
            // 
            // DeleteAcategory_btn
            // 
            this.DeleteAcategory_btn.Enabled = false;
            this.DeleteAcategory_btn.Image = global::DriversPremium.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.DeleteAcategory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteAcategory_btn.Location = new System.Drawing.Point(302, 116);
            this.DeleteAcategory_btn.Name = "DeleteAcategory_btn";
            this.DeleteAcategory_btn.Size = new System.Drawing.Size(138, 46);
            this.DeleteAcategory_btn.TabIndex = 2;
            this.DeleteAcategory_btn.Text = "Delete a category";
            this.DeleteAcategory_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteAcategory_btn.UseVisualStyleBackColor = true;
            this.DeleteAcategory_btn.Click += new System.EventHandler(this.DeleteAcategory_btn_Click);
            // 
            // AddAnewCategory_btn
            // 
            this.AddAnewCategory_btn.Image = global::DriversPremium.Properties.Resources.plus_icon_icons_com_70890;
            this.AddAnewCategory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddAnewCategory_btn.Location = new System.Drawing.Point(5, 113);
            this.AddAnewCategory_btn.Name = "AddAnewCategory_btn";
            this.AddAnewCategory_btn.Size = new System.Drawing.Size(121, 46);
            this.AddAnewCategory_btn.TabIndex = 1;
            this.AddAnewCategory_btn.Text = "Add a new category";
            this.AddAnewCategory_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddAnewCategory_btn.UseVisualStyleBackColor = true;
            this.AddAnewCategory_btn.Click += new System.EventHandler(this.AddAnewCategory_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewProhibition);
            this.groupBox3.Controls.Add(this.DeleteAprohibition_btn);
            this.groupBox3.Controls.Add(this.AddAnewProhibition_btn);
            this.groupBox3.Location = new System.Drawing.Point(13, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Driving ban";
            // 
            // dataGridViewProhibition
            // 
            this.dataGridViewProhibition.AllowUserToAddRows = false;
            this.dataGridViewProhibition.AllowUserToDeleteRows = false;
            this.dataGridViewProhibition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProhibition.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewProhibition.Name = "dataGridViewProhibition";
            this.dataGridViewProhibition.ReadOnly = true;
            this.dataGridViewProhibition.Size = new System.Drawing.Size(434, 88);
            this.dataGridViewProhibition.TabIndex = 0;
            // 
            // DeleteAprohibition_btn
            // 
            this.DeleteAprohibition_btn.Enabled = false;
            this.DeleteAprohibition_btn.Image = global::DriversPremium.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.DeleteAprohibition_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteAprohibition_btn.Location = new System.Drawing.Point(302, 113);
            this.DeleteAprohibition_btn.Name = "DeleteAprohibition_btn";
            this.DeleteAprohibition_btn.Size = new System.Drawing.Size(138, 46);
            this.DeleteAprohibition_btn.TabIndex = 2;
            this.DeleteAprohibition_btn.Text = "Delete a prohibition";
            this.DeleteAprohibition_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteAprohibition_btn.UseVisualStyleBackColor = true;
            this.DeleteAprohibition_btn.Click += new System.EventHandler(this.DeleteAprohibition_btn_Click);
            // 
            // AddAnewProhibition_btn
            // 
            this.AddAnewProhibition_btn.Image = global::DriversPremium.Properties.Resources.plus_icon_icons_com_70890;
            this.AddAnewProhibition_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddAnewProhibition_btn.Location = new System.Drawing.Point(5, 113);
            this.AddAnewProhibition_btn.Name = "AddAnewProhibition_btn";
            this.AddAnewProhibition_btn.Size = new System.Drawing.Size(121, 46);
            this.AddAnewProhibition_btn.TabIndex = 1;
            this.AddAnewProhibition_btn.Text = "Add a new prohibition";
            this.AddAnewProhibition_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddAnewProhibition_btn.UseVisualStyleBackColor = true;
            this.AddAnewProhibition_btn.Click += new System.EventHandler(this.AddAnewProhibition_btn_Click);
            // 
            // Create_btn
            // 
            this.Create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Create_btn.Location = new System.Drawing.Point(134, 595);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(88, 35);
            this.Create_btn.TabIndex = 3;
            this.Create_btn.Text = "Create";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close_btn.Location = new System.Drawing.Point(238, 595);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(88, 35);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 642);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaVozaca)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProhibition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddPicture_btn;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerEXP;
        private System.Windows.Forms.DateTimePicker dateTimePickerISS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.TextBox firstName_txt;
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.TextBox placeOfIssue_txt;
        private System.Windows.Forms.ComboBox gender_comboBox;
        public System.Windows.Forms.Button Create_btn;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox numberOfLicense_txt;
        private System.Windows.Forms.PictureBox pictureBoxSlikaVozaca;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.DataGridView dataGridViewProhibition;
        private System.Windows.Forms.Button AddAnewCategory_btn;
        private System.Windows.Forms.Button DeleteAcategory_btn;
        private System.Windows.Forms.Button DeleteAprohibition_btn;
        private System.Windows.Forms.Button AddAnewProhibition_btn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}