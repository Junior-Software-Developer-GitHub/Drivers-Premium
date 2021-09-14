using DriversPremium.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace DriversPremium
{
    public partial class CategoryProhibitionForm : Form, ICategoryProhibition
    { 
        /* Attributes */
        private static DataTable dt1 = new DataTable();
        private static DataTable dt2 = new DataTable();
      
        public CategoryProhibitionForm()
        {
            InitializeComponent();
        }

        /* Properties */
        public DataTable DT1
        {
            get => dt1;
            set => dt1 = value;
        }

        public DataTable DT2
        {
            get => dt2;
            set => dt2 = value;
        }

        public ComboBox Category
        {
            get => comboBoxCategory;
            set => comboBoxCategory = value;
        }

        public DateTimePicker ISS
        {
            get => dateTimePickerISS;
            set => dateTimePickerISS = value;
        }

        public DateTimePicker EXP
        {
            get => dateTimePickerEXP;
            set => dateTimePickerISS = value;
        }

        /* ButtonClick methods */
        private void Forward_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MakeDriverForm fm2 = (MakeDriverForm)Application.OpenForms["MakeDriverForm"];
                fm2.AddAnewCategory.Enabled = fm2.AddAnewProhibition.Enabled = true;

                if (comboBoxCategory.SelectedItem != null)
                {
                    if (this.Text == "Prohibition")
                    {
                        MakeColumns(DT1);

                         _= DT1.Columns.Count > 0 ? fm2.DeleteProhibition.Enabled = true : fm2.DeleteProhibition.Enabled=false;
                         DT1.Rows.Add(comboBoxCategory.SelectedItem, dateTimePickerISS.Value, dateTimePickerEXP.Value);
                         fm2.Prohibition.DataSource = DT1;
                    }
                    else
                    {
                        MakeColumns(DT2);

                        _ = DT2.Columns.Count > 0 ? fm2.DeleteCategory.Enabled = true : fm2.DeleteCategory.Enabled = false;
                        DT2.Rows.Add(comboBoxCategory.SelectedItem, dateTimePickerISS.Value, dateTimePickerEXP.Value);
                        fm2.Categories.DataSource = DT2;
                    }
                    fm2.Show();
                }
                else
                {
                    _ = MessageBox.Show("Fill in the category!");
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
             Close();
        }

        /* Helpers */
        public void MakeColumns(DataTable dt) => _ = (dt.Columns.Count == 0) ? (dt.Columns.Add("Category"), dt.Columns.Add("ISS"),
                  dt.Columns.Add("EXP")) : (null, null, null);
    }
}
