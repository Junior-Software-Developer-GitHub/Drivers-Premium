namespace DriversPremium
{
    partial class CategoryProhibitionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryProhibitionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEXP = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerISS = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Forward_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EXP";
            // 
            // dateTimePickerEXP
            // 
            this.dateTimePickerEXP.Enabled = false;
            this.dateTimePickerEXP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEXP.Location = new System.Drawing.Point(87, 78);
            this.dateTimePickerEXP.Name = "dateTimePickerEXP";
            this.dateTimePickerEXP.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerEXP.TabIndex = 5;
            // 
            // dateTimePickerISS
            // 
            this.dateTimePickerISS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerISS.Location = new System.Drawing.Point(87, 50);
            this.dateTimePickerISS.Name = "dateTimePickerISS";
            this.dateTimePickerISS.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerISS.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "A",
            "A1",
            "A2",
            "AM",
            "B",
            "B1",
            "BE",
            "C",
            "C1",
            "C1E",
            "D",
            "D1",
            "D1E",
            "DE",
            "F",
            "M"});
            this.comboBoxCategory.Location = new System.Drawing.Point(87, 21);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategory.Sorted = true;
            this.comboBoxCategory.TabIndex = 3;
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(144, 114);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 23);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Forward_btn
            // 
            this.Forward_btn.Location = new System.Drawing.Point(48, 114);
            this.Forward_btn.Name = "Forward_btn";
            this.Forward_btn.Size = new System.Drawing.Size(75, 23);
            this.Forward_btn.TabIndex = 5;
            this.Forward_btn.Text = "Forward";
            this.Forward_btn.UseVisualStyleBackColor = true;
            this.Forward_btn.Click += new System.EventHandler(this.Forward_btn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 151);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Forward_btn);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.dateTimePickerEXP);
            this.Controls.Add(this.dateTimePickerISS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button Forward_btn;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerEXP;
        public System.Windows.Forms.DateTimePicker dateTimePickerISS;
    }
}