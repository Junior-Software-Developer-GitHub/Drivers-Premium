using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Persons;

namespace DriversPremium
{

    public partial class ShowDriversForm : Form
    {
        /* Attributes */
        private static bool addClicked;
        private static readonly DataTable dt = new DataTable();

        public ShowDriversForm() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) => timerTime.Start();

        /* Properties */
        public bool AddClicked
        {
            get => addClicked;
            set => addClicked = value;
        }

        public DataGridView DTGview
        {
            get => dataGridViewList;
            set => dataGridViewList = value;
        }

        public Button ChangeDriverBtn => ChangeDriver_btn; //getter

        public Button DeleteDriverBtn => DeleteDriver_btn; //getter

        /* TimerTick method */
        private void TimerTime_Tick(object sender, EventArgs e)
        {
            String str = DateTime.Now.ToString("HH:mm:ss dd:MM:yyyy.");
            labelTime.Text = str;
            labelTime.Font = new Font(labelTime.Font, FontStyle.Bold);
        }

        /* ButtonClick methods */
        private void AddDriver_btn_Click(object sender, EventArgs e)
        {
            MakeDriverForm fm2 = new MakeDriverForm();
            fm2.DriverLicenseNumberTextBox.Enabled = true;
            addClicked = true;
            this.Hide();
            fm2.Show();
        }
        private void Sort_btn_Click(object sender, EventArgs e)
        {
            if (comboBoxSort.SelectedIndex == -1) MessageBox.Show("Please select a sort method!");
            else if (dataGridViewList.Rows.Count == 0) MessageBox.Show("Empty table!");
            else
            {
                string s = comboBoxSort.SelectedItem.ToString();
                _ = comboBoxSort.SelectedIndex switch
                {
                    0 => Sort(s),
                    1 => Sort(s),
                    2 => Sort(s),
                    _ => -1
                }; //switch expression
            }
        }

        private void DeleteDriver_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridViewList.CurrentCell.RowIndex;
            string licenseNumber = (string)dataGridViewList.Rows[index].Cells[2].Value;
            _ = PersonsList.Instance.DeletePerson(PersonsList.Instance.GetPerson(licenseNumber));
            dataGridViewList.Rows.RemoveAt(index);
            LockDeleteButton();
        }

        private void ChangeDriver_btn_Click(object sender, EventArgs e)
        {
            addClicked = false;
            int rowIndex = dataGridViewList.CurrentCell.RowIndex;
            LoadData(PersonsList.Instance.GetPerson(GetLicense())); //load personal data into Form2
            dataGridViewList.Rows.RemoveAt(rowIndex);

            this.Hide();
        }

        /* Auxiliary methods */
        private int Sort(string s)
        {
            dataGridViewList.Sort(this.dataGridViewList.Columns[s], ListSortDirection.Ascending);
            return 0;
        }

        public void LockDeleteButton() => _ = (dataGridViewList.Rows.Count == 0) ? (DeleteDriver_btn.Enabled = ChangeDriver_btn.Enabled = false)
                : (DeleteDriver_btn.Enabled = ChangeDriver_btn.Enabled = true);
        public void LoadData(Person p)
        {
            MakeDriverForm fm2 = new MakeDriverForm();
            fm2.DriverLicenseNumberTextBox.Enabled = false;
            fm2.DeleteCategory.Enabled = true;

            _ = (dt.Columns.Count == 0) ? (dt.Columns.Add("Category"), dt.Columns.Add("ISS"),
                dt.Columns.Add("EXP")) : (null, null, null);

            CategoryProhibitionForm fm3 = new CategoryProhibitionForm();
            fm2.DeleteDuplicates(p);
            fm2.openFileDialog1.FileName = p.Picture;
            fm2.FirstName.Text = p.FirstName;
            fm2.LastName = p.LastName;
            fm2.DateOfBirth = p.DateOfBirth;
            fm2.ISS = p.Iss;
            fm2.EXP = p.Exp;
            fm2.Categories.DataSource = fm3.DT2;
            fm2.Prohibition.DataSource = fm3.DT1;
            fm2.PictureOfDriver.ImageLocation = p.Picture;
            fm2.DriverLicenseNumber = p.DriverLicenseNumber;
            fm2.PlaceOfIssue = p.PlaceOfIssue;
            fm2.Gender = p.Gender;
            if (p.Prohibition.Count > 0) fm2.DeleteProhibition.Enabled = true;

            foreach (string x in from string x in p.Categories
                                 where x != null
                                 select x)
            {
                fm3.DT2.Rows.Add(x, p.Iss, p.Exp);
            }

            for (int i = 0; i < p.Prohibition.Count; i++)
            {
                if (p.Prohibition.ElementAtOrDefault(i) != null)
                    fm3.DT1.Rows.Add(p.Prohibition.ElementAtOrDefault(i), p.IssOfProhibition.ElementAtOrDefault(i),
                        p.ExpOfProhibition.ElementAtOrDefault(i));
            }
            this.Hide();
            fm2.Show();
        }

        public String GetLicense()
        {
            int rowIndex = dataGridViewList.CurrentCell.RowIndex;
            return dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString();
        }

    }
}