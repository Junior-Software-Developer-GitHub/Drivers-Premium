namespace DriversPremium
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sort_btn = new System.Windows.Forms.Button();
            this.ChangeDriver_btn = new System.Windows.Forms.Button();
            this.groupBoxDrivers = new System.Windows.Forms.GroupBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.DeleteDriver_btn = new System.Windows.Forms.Button();
            this.AddDriver_btn = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.groupBoxDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // Sort_btn
            // 
            this.Sort_btn.FlatAppearance.BorderSize = 0;
            this.Sort_btn.Location = new System.Drawing.Point(295, 18);
            this.Sort_btn.Name = "Sort_btn";
            this.Sort_btn.Size = new System.Drawing.Size(75, 23);
            this.Sort_btn.TabIndex = 2;
            this.Sort_btn.Text = "Sort";
            this.Sort_btn.UseVisualStyleBackColor = true;
            this.Sort_btn.Click += new System.EventHandler(this.Sort_btn_Click);
            // 
            // ChangeDriver_btn
            // 
            this.ChangeDriver_btn.Enabled = false;
            this.ChangeDriver_btn.Location = new System.Drawing.Point(150, 226);
            this.ChangeDriver_btn.Name = "ChangeDriver_btn";
            this.ChangeDriver_btn.Size = new System.Drawing.Size(79, 41);
            this.ChangeDriver_btn.TabIndex = 1;
            this.ChangeDriver_btn.Text = "Change driver";
            this.ChangeDriver_btn.UseVisualStyleBackColor = true;
            this.ChangeDriver_btn.Click += new System.EventHandler(this.ChangeDriver_btn_Click);
            // 
            // groupBoxDrivers
            // 
            this.groupBoxDrivers.Controls.Add(this.dataGridViewList);
            this.groupBoxDrivers.Controls.Add(this.ChangeDriver_btn);
            this.groupBoxDrivers.Controls.Add(this.DeleteDriver_btn);
            this.groupBoxDrivers.Controls.Add(this.AddDriver_btn);
            this.groupBoxDrivers.Location = new System.Drawing.Point(12, 50);
            this.groupBoxDrivers.Name = "groupBoxDrivers";
            this.groupBoxDrivers.Size = new System.Drawing.Size(507, 274);
            this.groupBoxDrivers.TabIndex = 1;
            this.groupBoxDrivers.TabStop = false;
            this.groupBoxDrivers.Text = "Drivers list";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            this.dataGridViewList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.Size = new System.Drawing.Size(495, 201);
            this.dataGridViewList.TabIndex = 3;
            // 
            // DeleteDriver_btn
            // 
            this.DeleteDriver_btn.Enabled = false;
            this.DeleteDriver_btn.Image = global::DriversPremium.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.DeleteDriver_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteDriver_btn.Location = new System.Drawing.Point(388, 227);
            this.DeleteDriver_btn.Name = "DeleteDriver_btn";
            this.DeleteDriver_btn.Size = new System.Drawing.Size(113, 41);
            this.DeleteDriver_btn.TabIndex = 2;
            this.DeleteDriver_btn.Text = "Delete driver";
            this.DeleteDriver_btn.UseVisualStyleBackColor = true;
            this.DeleteDriver_btn.Click += new System.EventHandler(this.DeleteDriver_btn_Click);
            // 
            // AddDriver_btn
            // 
            this.AddDriver_btn.Image = global::DriversPremium.Properties.Resources.plus_icon_icons_com_70890;
            this.AddDriver_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDriver_btn.Location = new System.Drawing.Point(6, 226);
            this.AddDriver_btn.Name = "AddDriver_btn";
            this.AddDriver_btn.Size = new System.Drawing.Size(115, 41);
            this.AddDriver_btn.TabIndex = 0;
            this.AddDriver_btn.Text = "Add a driver";
            this.AddDriver_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddDriver_btn.UseVisualStyleBackColor = true;
            this.AddDriver_btn.Click += new System.EventHandler(this.AddDriver_btn_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(9, 21);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(117, 13);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "HH:mm:ss dd.MM.yyyy.";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DisplayMember = "0";
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Driver\'s license number",
            "First name",
            "Last name"});
            this.comboBoxSort.Location = new System.Drawing.Point(380, 18);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(133, 21);
            this.comboBoxSort.Sorted = true;
            this.comboBoxSort.TabIndex = 3;
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 336);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.groupBoxDrivers);
            this.Controls.Add(this.Sort_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddDriver_btn;
        private System.Windows.Forms.GroupBox groupBoxDrivers;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button Sort_btn;
        private System.Windows.Forms.Button ChangeDriver_btn;
        private System.Windows.Forms.Button DeleteDriver_btn;
    }
}

