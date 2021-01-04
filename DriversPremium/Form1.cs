using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Persons;
using System.Linq;

namespace DriversPremium
{

    public partial class Form1 : Form
    {
        private static bool addClicked;
        public static readonly DataTable dt = new DataTable();

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) => timerTime.Start();

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            String str = DateTime.Now.ToString("HH:mm:ss dd:MM:yyyy.");
            labelTime.Text = str;
            labelTime.Font = new Font(labelTime.Font, FontStyle.Bold);
        }

        private void AddDriver_btn_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.DriverLicenseNumberTextBox.Enabled = true;
            addClicked = true;
            this.Hide();
            fm2.Show();
        }

        private void Sort_btn_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.Rows.Count > 0)
            {
                if (comboBoxSort.SelectedItem != null)
                {
                    if (comboBoxSort.SelectedItem.Equals("Driver's license number"))
                        dataGridViewList.Sort(this.dataGridViewList.Columns["Driver's license number"], ListSortDirection.Ascending);
                    else if (comboBoxSort.SelectedItem.Equals("First name"))
                        dataGridViewList.Sort(this.dataGridViewList.Columns["First name"], ListSortDirection.Ascending);
                    else if (comboBoxSort.SelectedItem.Equals("Last name"))
                        dataGridViewList.Sort(this.dataGridViewList.Columns["Last name"], ListSortDirection.Ascending);
                }
                else MessageBox.Show("Please select a sort method!");
            }
            else MessageBox.Show("Empty table!");
        }

        private void DeleteDriver_btn_Click(object sender, EventArgs e)
        {
            int index = dataGridViewList.CurrentCell.RowIndex;
            string licenseNumber = (string)dataGridViewList.Rows[index].Cells[2].Value;
            _ = PersonsList.Instance.DeletePerson(PersonsList.Instance.GetPerson(licenseNumber));
            dataGridViewList.Rows.RemoveAt(index);
            LockDeleteButton();
        }

        public void LockDeleteButton() => _ = (dataGridViewList.Rows.Count == 0) ? (DeleteDriver_btn.Enabled = ChangeDriver_btn.Enabled = false)
                : (DeleteDriver_btn.Enabled = ChangeDriver_btn.Enabled = true);

        private void ChangeDriver_btn_Click(object sender, EventArgs e)
        {
            addClicked = false;
            int rowIndex = dataGridViewList.CurrentCell.RowIndex;
            LoadData(PersonsList.Instance.GetPerson(GetLicense()));
            dataGridViewList.Rows.RemoveAt(rowIndex);

            this.Hide();
        }

        public void LoadData(Person p)
        {
            Form2 fm2 = new Form2();
            fm2.DriverLicenseNumberTextBox.Enabled = false;
            fm2.DeleteCategory.Enabled = fm2.DeleteProhibition.Enabled = true;

            _ = (dt.Columns.Count == 0) ? (dt.Columns.Add("Category"), dt.Columns.Add("ISS"),
                dt.Columns.Add("EXP")):(null,null,null);

            Form3 fm3 = new Form3();
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
            
            foreach (string x in from string x in p.Categories
                              where x != null
                              select x)
            {
                fm3.DT2.Rows.Add(x, p.Iss, p.Exp);
            }

            for (int i = 0; i < p.Prohibition.Count; i++)
            {
                if (p.Prohibition[i] != null) fm3.DT1.Rows.Add(p.Prohibition[i], p.IssOfProhibition[i], p.ExpOfProhibition[i]);
            }   
            this.Hide();
            fm2.Show();
        }

        public String GetLicense()
        {
            int rowIndex = dataGridViewList.CurrentCell.RowIndex;
            return dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString();
        }

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

        public Button ChangeDriverBtn => ChangeDriver_btn;

        public Button DeleteDriverBtn => DeleteDriver_btn;
    }
}