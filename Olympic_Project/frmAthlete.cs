using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olympic_Project
{
    public partial class frmAthlete : Form
    {
        Athlete athlete;
        Country country;
        Discipline discipline;
        public frmAthlete()
        {
            InitializeComponent();
        }

        public void HideAllPanels()
        {
            bool x = false;
            pnlAddAthlete.Visible = x;
            pnlUpdateAthlete.Visible = x;
            pnlViewAthlete.Visible = x;
            pnlRegisterAthlete.Visible = x;
            pnlDeleteAthlete.Visible = x;
        }

        public void ClearDataFields()
        {
            txtAddName.Clear();
            txtAddSurname.Clear();
            txtUpdateName.Clear();
            txtUpdateSurname.Clear();
            txtRegFirstName.Clear();
            txtRegPB.Clear();
            txtRegSurname.Clear();
            cmbRegEvents.Visible = false;
            lblRegPB.Visible = false;
            txtRegPB.Visible = false;
            txtRegYear.Visible = false;
            lstRegDetails.Visible = false;
            lstRegDetails.Items.Clear();
        }
      
        private void btnAthleteAdd_Click(object sender, EventArgs e)//need to check if the person already exists. Check name, surname, country, disciplineNo
        {
            lblNameError.Visible = false;
            lblSurnameError.Visible = false;
            bool valid = true;
            int disciplineNo = int.Parse(cmbAddDiscipline.SelectedValue.ToString());
            int countryId = int.Parse(cmbAddCountry.SelectedValue.ToString());
            string name = txtAddName.Text, surname = txtAddSurname.Text;
            string gender = "";
            string dob = dteDOB.Value.ToShortDateString().ToString();
            if (rbFemale.Checked)
                gender = "F";
            else
                gender = "M";

            if (string.IsNullOrEmpty(txtAddName.Text) )
            {
                MessageBox.Show("There is missing information");
                lblNameError.Visible = true;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtAddSurname.Text))
            {
                MessageBox.Show("There is missing information");
                lblSurnameError.Visible = true;
                valid = false;
            }

            if (valid == true)
            {
                athlete = new Athlete();
                int x = athlete.insertAthlete(countryId, disciplineNo, name, surname, gender, dob);
                if (x > 0)
                {
                    MessageBox.Show("Athlete has been added succesfully");
                    ClearDataFields();
                    btnAddAthlete_Click(sender, e);
                }
            }
        }

        private void btnAddAthlete_Click(object sender, EventArgs e)
        {
            lblNameError.Visible = false;
            lblSurnameError.Visible = false;
            HideAllPanels();
            pnlAddAthlete.Visible = true;
            country = new Country();
            cmbAddCountry.DataSource = country.getActiveCountries();
            cmbAddCountry.DisplayMember = "countryName";
            cmbAddCountry.ValueMember = "countryID";

            discipline = new Discipline();
            cmbAddDiscipline.DataSource = discipline.getAllDisciplines();
            cmbAddDiscipline.DisplayMember = "disciplineName";
            cmbAddDiscipline.ValueMember = "disciplineNo";
        }
       
        private void btnUpdateAthlete_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlUpdateAthlete.Visible = true;
            country = new Country();
            cmbUpdateCountry.DataSource = country.getActiveCountries();
            cmbUpdateCountry.DisplayMember = "countryName";
            cmbUpdateCountry.ValueMember = "countryID";

            athlete = new Athlete();
            cmbUpdateAthlete.DataSource = athlete.getAllAthletes();
            cmbUpdateAthlete.DisplayMember = "fullname";
            cmbUpdateAthlete.ValueMember = "athleteNo";
            btnAthleteUpdate.Enabled = false;
            txtUpdateName.Text = " ";
            txtUpdateSurname.Text = "";
        }

        private void btnUpdateDisplay_Click(object sender, EventArgs e)
        {
            athlete = new Athlete();
            athlete = athlete.getAAthlete(int.Parse(cmbUpdateAthlete.SelectedValue.ToString()));
            txtUpdateName.Text = athlete.Name;
            txtUpdateSurname.Text = athlete.Surname;
            cmbUpdateCountry.SelectedValue = athlete.CountryID;
            btnAthleteUpdate.Enabled = true;
        }

        private void btnAthleteUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wan to update this athlete?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                athlete = new Athlete();
                int athleteNo = int.Parse(cmbUpdateAthlete.SelectedValue.ToString());
                int countryId = int.Parse(cmbUpdateCountry.SelectedValue.ToString());
                string name = txtUpdateName.Text, surname = txtUpdateSurname.Text;
                int x = athlete.updateAthlete(athleteNo, countryId, name, surname);
                if (x > 0)
                {
                    MessageBox.Show("Athlete has been updated");
                    ClearDataFields();
                    btnUpdateAthlete_Click(sender, e);
                }
            }            
        }

        private void btnViewAthlete_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlViewAthlete.Visible = true;
            dgvViewAthletes.DataSource = null;

            country = new Country();
            cmbViewCountry.DisplayMember = "countryName";
            cmbViewCountry.ValueMember = "countryID";
            cmbViewCountry.DataSource = country.getActiveCountries();

            discipline = new Discipline();
            cmbViewDiscipline.DisplayMember = "disciplineName";
            cmbViewDiscipline.ValueMember = "disciplineNo";
            cmbViewDiscipline.DataSource = discipline.getAllDisciplines();
        }

        private void btnRegisterAthlete_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ClearDataFields();
            pnlRegisterAthlete.Visible = true;
            btnRegSave.Enabled = false;

        }
    
        private void btnRegSearchAthlete_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(txtRegFirstName.Text) && string.IsNullOrEmpty(txtRegSurname.Text))
            {
                valid = false;               
                MessageBox.Show("Please enter a name or sunrame");              
            }

            if (valid == true)
            { 
                cmbRegEvents.DataSource = null;
                btnRegSave.Enabled = true;
                lstRegDetails.Items.Clear();              
                cmbRegEvents.Visible = false;
                txtRegPB.Visible = false;
                lblRegPB.Visible = false;
                txtRegYear.Visible = false;

               string name = txtRegFirstName.Text, surname = txtRegSurname.Text, gender;
                ClearDataFields();
               int countryID, disciplineNo, athleteNo;
               athlete = new Athlete();
               try
               {
                    athlete = athlete.searchAthlete(name, surname);
                    athleteNo = athlete.AthleteNo;
                    name = athlete.Name;
                    surname = athlete.Surname;
                    countryID = athlete.CountryID;
                    disciplineNo = athlete.DisciplineNo;
                    gender = athlete.Gender;
                    lstRegDetails.Items.Add(athleteNo);
                    lstRegDetails.Items.Add("Name: " + name + "  Surname: " + surname);
                    lstRegDetails.Items.Add("Country: " + countryID);
                    lstRegDetails.Items.Add("Discipline: " + disciplineNo);
                    DisplayRegistration(disciplineNo, 2016, gender);
                    lstRegDetails.Visible = true;
                }
                catch (System.NullReferenceException)//if no records were found, so it returned null values
                {
                   MessageBox.Show("No persons found");
              }
           }   
        }

        public void DisplayRegistration(int disciplineNo, int year, string gender)
        {

            discipline = new Discipline();
            cmbRegEvents.DataSource = discipline.getGenderOlympicEventsinDiscipline(disciplineNo, year, gender);
            cmbRegEvents.DisplayMember = "eventName";
            cmbRegEvents.ValueMember = "eventNo";
            if (string.IsNullOrEmpty(cmbRegEvents.Text))//if no events were found for the discipline, empty combo box
            {
                btnRegSave.Enabled = false;
                MessageBox.Show("No events for this discipline have been added yet");
            }
            else
            {
                txtRegYear.Visible = true;
                txtRegYear.Text = "2016";
                cmbRegEvents.Visible = true;
                txtRegPB.Visible = true;
                lblRegPB.Visible = true;
            }


        }

        private void btnRegSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            int eventNo = int.Parse(cmbRegEvents.SelectedValue.ToString());
            int year = int.Parse(txtRegYear.Text); ;           
            int athleteNo = int.Parse(lstRegDetails.Items[0].ToString());
            string pb = "";

            if (string.IsNullOrEmpty(txtRegPB.Text))
            {
                valid = false;
                txtRegPB.Focus();
                MessageBox.Show("Please enter a personal best score");
            }
            else
                pb = txtRegPB.Text;

            if (valid == true)
            {
                athlete = new Athlete();
                int x = athlete.insertEventAthlete(athleteNo, eventNo, year, pb);
                if (x > 0)
                {
                    MessageBox.Show("Athlete has succeffully registered for this event");
                    ClearDataFields();
                }
                else
                {
                    MessageBox.Show("It appears that this athlete is already registered for this event in " + year.ToString(), "Error");
                    ClearDataFields();
                }
            }
        }             

        private void btnViewDiscCountry_Click(object sender, EventArgs e)
        {
            country = new Country();
            dgvViewAthletes.DataSource = country.getCountryAthletesinDiscipline(int.Parse(cmbViewCountry.SelectedValue.ToString()), int.Parse(cmbViewDiscipline.SelectedValue.ToString()));          
        }

        private void btnViewClear_Click(object sender, EventArgs e)
        {
            dgvViewAthletes.DataSource = null;
        }

        private void btnViewCountry_Click(object sender, EventArgs e)
        {
            country = new Country();
            dgvViewAthletes.DataSource = country.getCountryAthletes(int.Parse(cmbViewCountry.SelectedValue.ToString()));
        }

        private void btnViewDiscipline_Click(object sender, EventArgs e)
        {
            discipline = new Discipline();
            dgvViewAthletes.DataSource = discipline.getDisciplineAthletes(int.Parse(cmbViewDiscipline.SelectedValue.ToString()));
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            athlete = new Athlete();
            dgvViewAthletes.DataSource = athlete.getAllAthletes();
        }

        private void btnDeleteAthlete_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlDeleteAthlete.Visible = true;
            lstDeleteAthletes.DataSource = null;

            athlete = new Athlete();

            lstDeleteAthletes.DisplayMember = "fullName";
            lstDeleteAthletes.ValueMember = "athleteNo";
            lstDeleteAthletes.DataSource = athlete.getAllAthletes();
        }

        private void btnAthleteDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete athlete(s)", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int x = deleteAthlete();
                if (x > 0)
                {
                    MessageBox.Show("Athlete was removed");
                    btnDeleteAthlete_Click(sender, e);
                }
            }
        }

        private int deleteAthlete()
        {
            int x = -1;
            athlete = new Athlete();
            foreach(var i in lstDeleteAthletes.SelectedItems)
            {
                x = athlete.deleteAthlete(int.Parse(lstDeleteAthletes.SelectedValue.ToString()));
            }
            return x;
        }
    }
}
