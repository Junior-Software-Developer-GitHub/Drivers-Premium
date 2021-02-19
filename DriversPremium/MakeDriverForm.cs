using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Persons;

namespace DriversPremium
{
    public partial class MakeDriverForm : Form
    {
        /* Attribute */
        private static readonly DataTable dt = new DataTable();

        public MakeDriverForm()
        {
            this.AutoScroll = true;
            InitializeComponent();
            ShowDriversForm fm1 = new ShowDriversForm();
            if (!fm1.AddClicked)
            {
                dateTimePickerISS.Format = DateTimePickerFormat.Custom;
                dateTimePickerISS.CustomFormat = " ";
                dateTimePickerEXP.Format = DateTimePickerFormat.Custom;
                dateTimePickerEXP.CustomFormat = " ";
            }      
        }

        /* Properties */
        public TextBox FirstName
        {
            get => firstName_txt;
            set => firstName_txt = value;
        }
        public String LastName
        {
            get => lastName_txt.Text;
            set => lastName_txt.Text = value;
        }
        public DateTime DateOfBirth
        {
            get => dateTimePickerDateOfBirth.Value;
            set => dateTimePickerDateOfBirth.Value = value;
        }
        public DateTime ISS
        {
            get => dateTimePickerISS.Value;
            set => dateTimePickerISS.Value = value;
        }
        public DateTime EXP
        {
            get => dateTimePickerEXP.Value;
            set => dateTimePickerEXP.Value = value;
        }
        public String DriverLicenseNumber
        {
            get => numberOfLicense_txt.Text;
            set => numberOfLicense_txt.Text = value;
        }
        public TextBox DriverLicenseNumberTextBox
        {
            get => numberOfLicense_txt;
            set => numberOfLicense_txt = value;
        }
        public String PlaceOfIssue
        {
            get => placeOfIssue_txt.Text;
            set => placeOfIssue_txt.Text = value;
        }
        public String Gender
        {
            get => gender_comboBox.SelectedItem.ToString();
            set => gender_comboBox.SelectedItem = value;
        }
        public PictureBox PictureOfDriver
        {
            get => pictureBoxSlikaVozaca;
            set => pictureBoxSlikaVozaca = value;
        }
        
        public DataGridView Categories => dataGridViewCategories;
        
        public DataGridView Prohibition => dataGridViewProhibition;

        public Button DeleteCategory
        {
            get => DeleteAcategory_btn;
            set => DeleteAcategory_btn = value;
        }
        public Button DeleteProhibition
        {
            get => DeleteAprohibition_btn;
            set => DeleteAprohibition_btn = value;
        }
        public Button AddAnewCategory
        {
            get => AddAnewCategory_btn;
            set => AddAnewCategory_btn = value;
        }
        public Button AddAnewProhibition
        {
            get => AddAnewProhibition_btn;
            set => AddAnewProhibition_btn = value;
        }

        /* ButtonClick methods */
        private void AddPicture_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxSlikaVozaca.ImageLocation = openFileDialog1.FileName;
        }

        private void AddAnewCategory_btn_Click(object sender, EventArgs e)
        {
            CategoryProhibitionForm fm3 = new CategoryProhibitionForm();
            fm3.ISS.Enabled = fm3.EXP.Enabled = false;
            fm3.ISS.Value = dateTimePickerISS.Value;
            fm3.EXP.Value = dateTimePickerEXP.Value;
            fm3.Show();
        }

        private void DeleteAcategory_btn_Click(object sender, EventArgs e)
        {
            int index = Categories.CurrentCell.RowIndex;
       
                for (int i = 0; i < Prohibition.Rows.Count; i++)
                {
                    if (Prohibition.Rows[i].Cells[0].Value.ToString() == Categories.Rows[index].Cells[0].Value.ToString())
                        Prohibition.Rows.RemoveAt(i);
                }
                
            Categories.Rows.RemoveAt(index);
            EnableOrDisableButtons();
        }


        private void AddAnewProhibition_btn_Click(object sender, EventArgs e)
        {
            CategoryProhibitionForm fm3 = new CategoryProhibitionForm();
            fm3.Category.Items.Clear();
            fm3.ISS.Enabled = fm3.EXP.Enabled = true;

            foreach (DataGridViewRow dr in dataGridViewCategories.Rows)
                fm3.Category.Items.Add(dr.Cells["Category"].Value);

            fm3.ISS.Enabled = fm3.EXP.Enabled = true;
            fm3.Text = "Prohibition";

            fm3.ISS.MinDate = new DateTime(ISS.Year, ISS.Month, ISS.Day);
            fm3.ISS.MaxDate = new DateTime(EXP.Year, EXP.Month, ISS.Day);
            fm3.ISS.Value = fm3.ISS.MinDate;

            fm3.EXP.MinDate = new DateTime(ISS.Year, ISS.Month + 3, ISS.Day);
            fm3.EXP.MaxDate = new DateTime(EXP.Year, EXP.Month, EXP.Day);
            fm3.Show();
        }

        private void DeleteAprohibition_btn_Click(object sender, EventArgs e)
        {
            int index = Prohibition.CurrentCell.RowIndex;
            ShowDriversForm fm1 = new ShowDriversForm();

            if (!fm1.AddClicked)
            {
                if (PersonsList.Instance.Exists(PersonsList.Instance.GetPerson(DriverLicenseNumber)))
                    PersonsList.Instance.GetPerson(DriverLicenseNumber).Prohibition.Remove(Prohibition.Rows[index].Cells[0].Value.ToString());

                Prohibition.Rows.RemoveAt(index);
            }
            else Prohibition.Rows.RemoveAt(index);
            _ = (Prohibition.Rows.Count == 0) ? DeleteAprohibition_btn.Enabled = false : DeleteAprohibition_btn.Enabled = true;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            ShowDriversForm fm1 = (ShowDriversForm)Application.OpenForms["Form1"];
            Close();
            fm1.ShowDialog();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
                ShowDriversForm fm1 = new ShowDriversForm();
            try
            {
                if (FieldOccupancy())
                {
                    List<string> categories = new List<string>();

                    foreach (DataGridViewRow dr in Categories.Rows)
                        categories.Add(dr.Cells[0].Value.ToString());

                    List<string> prohibitions = new List<string>();
                    List<string> prohibitionsISS = new List<string>();
                    List<string> prohibitionsEXP = new List<string>();
                    bool res;

                    foreach (DataGridViewRow dr in Prohibition.Rows)
                    {
                        prohibitions.Add(dr.Cells[0].Value.ToString());
                        prohibitionsISS.Add(dr.Cells[1].Value.ToString());
                        prohibitionsEXP.Add(dr.Cells[2].Value.ToString());
                    }

                    if (fm1.AddClicked)
                    {
                        res = PersonsList.Instance.AddPerson(new Person(FirstLetterCapital(firstName_txt.Text), FirstLetterCapital(lastName_txt.Text), dateTimePickerDateOfBirth.Value
                            , dateTimePickerISS.Value, dateTimePickerEXP.Value, numberOfLicense_txt.Text, placeOfIssue_txt.Text,
                            gender_comboBox.SelectedItem.ToString(), categories, prohibitions, prohibitionsISS, prohibitionsEXP, openFileDialog1.FileName));

                        if (!res)
                        {
                            MessageBox.Show("A driver's license with this number already exists!");
                            return;
                        }
                    }
                    else
                    {
                        Person p = PersonsList.Instance.GetPerson(DriverLicenseNumber);
                        PersonsList.Instance.DeletePerson(p);

                        p = new Person(FirstLetterCapital(firstName_txt.Text), FirstLetterCapital(lastName_txt.Text), dateTimePickerDateOfBirth.Value
                            , dateTimePickerISS.Value, dateTimePickerEXP.Value, numberOfLicense_txt.Text, placeOfIssue_txt.Text,
                            gender_comboBox.SelectedItem.ToString(), categories, prohibitions, prohibitionsISS, prohibitionsEXP, openFileDialog1.FileName);
                        _ = PersonsList.Instance.AddPerson(p);

                        DeleteDuplicates(p);
                    }
                    MakeColumns(dt);

                    using (CategoryProhibitionForm fm3 = new CategoryProhibitionForm())
                    {
                        fm3.DT1.Rows.Clear();
                        fm3.DT2.Rows.Clear();
                    }
                    dt.Rows.Add(FirstLetterCapital(FirstName.Text), FirstLetterCapital(LastName), DriverLicenseNumber);
                    fm1.DTGview.DataSource = dt;

                    _ = (dt.Rows.Count > 0) ? (fm1.DeleteDriverBtn.Enabled = fm1.ChangeDriverBtn.Enabled = true)
                        : (fm1.DeleteDriverBtn.Enabled = fm1.ChangeDriverBtn.Enabled = true);

                    this.Close();
                    fm1.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close application?",
                     "Exit", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }

        /* DateTimePicker_ValueChanged methods */
        private void DateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerISS.MinDate = new DateTime(dateTimePickerDateOfBirth.Value.Year + 17,
                dateTimePickerDateOfBirth.Value.Month, dateTimePickerDateOfBirth.Value.Day);

            dateTimePickerISS.MaxDate = new DateTime(2021, 1, 1);

            dateTimePickerDateOfBirth.Format = DateTimePickerFormat.Short;
            dateTimePickerISS.Format = DateTimePickerFormat.Short;

            dateTimePickerISS.Enabled = true;
        }
        
        private void DateTimePickerISS_ValueChanged(object sender, EventArgs e)
        {
            AddAnewCategory_btn.Enabled = true;
            dateTimePickerEXP.MinDate = new DateTime(dateTimePickerISS.Value.Year + 10,
                dateTimePickerISS.Value.Month, dateTimePickerISS.Value.Day);

            dateTimePickerEXP.Format = DateTimePickerFormat.Custom;
            dateTimePickerEXP.CustomFormat = dateTimePickerEXP.MinDate.ToShortDateString();
            dateTimePickerEXP.Value = dateTimePickerEXP.MinDate;

            using (CategoryProhibitionForm fm3 = new CategoryProhibitionForm())
            {
                fm3.DT1.Rows.Clear();
                fm3.DT2.Rows.Clear();
            }
            EnableOrDisableButtons();
        }

        /* KeyPress methods */
        private void FirstName_txt_KeyPress(object sender, KeyPressEventArgs e) 
            => e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        private void LastName_txt_KeyPress(object sender, KeyPressEventArgs e) 
            => e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
       
        private void NumberOfLicense_txt_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void PlaceOfIssue_txt_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);


        /* Auxiliary methods */
        String FirstLetterCapital(String s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public void DeleteDuplicates(Person p)
        {
            HashSet<String> hs = new HashSet<String>();
            foreach (string v in p.Categories)
                if (!hs.Add(v))
                    p.Categories.Remove(v);
            HashSet<String> hs1 = new HashSet<String>();
            foreach (string v1 in p.Prohibition)
                if (!hs1.Add(v1))
                    p.Prohibition.Remove(v1);
        }

        private bool FieldOccupancy()
        {
            if (String.IsNullOrEmpty(FirstName.Text) || String.IsNullOrEmpty(LastName) || DriverLicenseNumber.Length < 9
                || String.IsNullOrEmpty(PlaceOfIssue) || gender_comboBox.SelectedIndex == -1 ||
                dataGridViewCategories.Rows.Count == 0 || pictureBoxSlikaVozaca.Image == null)
            {
                MessageBox.Show("Fill in all fields!");
                return false;
            }
            return true;
        }

        private void EnableOrDisableButtons()
        {
            _ = (Categories.Rows.Count == 0) ? (DeleteAcategory_btn.Enabled = false, AddAnewProhibition.Enabled = false)
            : (DeleteAcategory_btn.Enabled = true, AddAnewProhibition.Enabled = true);

            _ = dataGridViewProhibition.Rows.Count == 0 ? DeleteAprohibition_btn.Enabled = false : DeleteAprohibition_btn.Enabled = true;
        }

        private void MakeColumns(DataTable dt) => _ = (dt.Columns.Count == 0) ? (dt.Columns.Add("First name"), dt.Columns.Add("Last name"),
               dt.Columns.Add("Driver's license number")) : (null, null, null);


    }
}
