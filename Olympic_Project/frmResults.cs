using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Olympic_Project
{
    public partial class frmResults : Form
    {
        Discipline discipline;
        Event events;
        Results result;
        Athlete athlete;
        Olympics olympic;
        private string eventType = "I";
        public frmResults()
        {
            InitializeComponent();
        }

        public void HideAllPanels()
        {
            bool x = false;
            pnlAddMedalsI.Visible = x;
            pnlViewMedalWinners.Visible = x;
        }
        private void btnAddResult_Click(object sender, EventArgs e)
        {
            string medal = cmbAddMedal.Text, PB = txtAddResult.Text;
            bool validated = true;
            int year, eventNo, athleteNo, position;
             if (string.IsNullOrEmpty(cmbAddMedal.Text))
            {
                validated = false;
            }            
             if (string.IsNullOrEmpty(txtAddAthleteNo.Text))
            {
                validated = false;
                MessageBox.Show("Please select an athlete");
                txtAddAthleteNo.Focus();
            }
            if (string.IsNullOrEmpty(txtAddPosition.Text))
            {
                validated = false;
                MessageBox.Show("Please enter a position");
                txtAddPosition.Focus();
            }
            if (string.IsNullOrEmpty(txtAddResult.Text))
            {
                validated = false;
                MessageBox.Show("Please enter a time or distance");
                txtAddResult.Focus();
            }

            if (medal == "Gold")
                medal = "G";
            else if (medal == "Silver")
                medal = "S";
            else if (medal == "Bronze")
                medal = "B";
            else
                medal = "N";

            if (validated == true)
            {
                year = int.Parse(cmbAddOlympics.SelectedValue.ToString());
                eventNo = int.Parse(cmbAddEvent.SelectedValue.ToString());
                athleteNo = int.Parse(txtAddAthleteNo.Text);
                position = int.Parse(txtAddPosition.Text);
                if (MessageBox.Show("Are you sure you want to proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (eventType == "I")
                    {
                        AddIndividualMedal(medal, year, eventNo, athleteNo, PB, position);
                    }
                    else if (eventType == "T")
                    {
                        AddTeamMedal(medal, year, eventNo, PB, position);
                    }
                }
            }

        }

        private void btnAddMedals_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlAddMedalsI.Visible = true;

            if (MessageBox.Show("Do you want to add medals to a Team Event?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                eventType = "T";
                gbEvents.Text = "Team Events";
                lblCountry.Visible = true;
                cmbAddCountry.Visible = true;

                Country country = new Country();
                cmbAddCountry.DisplayMember = "countryName";
                cmbAddCountry.ValueMember = "countryID";
                cmbAddCountry.DataSource = country.getActiveCountries();
            }
            else
            {
                eventType = "I";
                gbEvents.Text = "Individual Events";
                lblCountry.Visible = false;
                cmbAddCountry.Visible = false;
            }
            SearchEvents();
        }
     
        private void btnViewMedalWinners_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlViewMedalWinners.Visible = true;                    

            olympic = new Olympics();
            cmbViewYear.DisplayMember = "olympicName";
            cmbViewYear.ValueMember = "olympicID";
            cmbViewYear.DataSource = olympic.getAllOlympics();     

        }

        private void cmbViewYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbViewEvents.DataSource = null;
            cmbViewDiscipline.DataSource = null;
            cmbViewEvents.Enabled = false;
            cmbViewDiscipline.Enabled = true;

            discipline = new Discipline();
            cmbViewDiscipline.DisplayMember = "disciplineName";
            cmbViewDiscipline.ValueMember = "disciplineNo";
            cmbViewDiscipline.DataSource = discipline.getAllDisciplines();
        }

        private void cmbViewDiscipline_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbViewEvents.Enabled = false;
            cmbViewEvents.DataSource = null;
            events = new Event();
            cmbViewEvents.Enabled = true;
            cmbViewEvents.DisplayMember = "eventName";
            cmbViewEvents.ValueMember = "eventNo";
            cmbViewEvents.DataSource = events.getOlympicEventsinDiscipline(int.Parse(cmbViewYear.SelectedValue.ToString()), int.Parse(cmbViewDiscipline.SelectedValue.ToString()));
        }

        private void btnViewEventWinners_Click(object sender, EventArgs e)
        {
            bool validated = true;
            if (string.IsNullOrEmpty(cmbViewYear.Text))
            {
                MessageBox.Show("Please select a year");
                cmbViewYear.Focus();
                validated = false;
            }
            if (string.IsNullOrEmpty(cmbViewDiscipline.Text) || string.IsNullOrEmpty(cmbViewEvents.Text))
            {
                MessageBox.Show("Your selection is invalid");
                cmbViewDiscipline.Focus();
                validated = false;
            }
           
            if (validated == true)
            {
                DisplayWinners();
            }
                
        }

        public void DisplayHeadings()
        {
            lstViewWinners.Items.Clear();
            lstViewWinners.Items.Add("Rank".PadRight(5) + "Athlete".PadRight(12) + "\tCountry".PadRight(5) + "\tResult");
        }

        public void DisplayWinners()
        {
            DisplayHeadings();
            result = new Results();
            SqlDataReader reader = result.getReaderforWinners(int.Parse(cmbViewEvents.SelectedValue.ToString()), int.Parse(cmbViewYear.SelectedValue.ToString()));
            Results aAthlete;
            while (reader.Read())
            {
                aAthlete = new Results(reader["medal"].ToString(), reader["firstName"].ToString(), reader["surname"].ToString(), reader["initials"].ToString(), reader["PB"].ToString(), int.Parse(reader["position"].ToString()));
                lstViewWinners.Items.Add(aAthlete.DisplayAthlete());
            }
            reader.Close();
        }

        public void SearchEvents()
        {          
            olympic = new Olympics();
            cmbAddOlympics.DisplayMember = "olympicName";
            cmbAddOlympics.ValueMember = "olympicID";
            cmbAddOlympics.DataSource = olympic.getAllOlympics();                          
        }      

        private void cmbAddOlympics_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbAddDiscipline.DataSource = null;
            cmbAddEvent.DataSource = null;

            discipline = new Discipline();
            cmbAddDiscipline.DisplayMember = "disciplineName";
            cmbAddDiscipline.ValueMember = "disciplineNo";
            cmbAddDiscipline.DataSource = discipline.getAllDisciplines();

            
        }

        private void cmbAddDiscipline_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            cmbAddEvent.DataSource = null;
            cmbAddEvent.Enabled = true;

            events = new Event();           
            cmbAddEvent.DisplayMember = "eventName";
            cmbAddEvent.ValueMember = "eventNo";
            cmbAddEvent.DataSource = events.getEventTypeinDiscipline(int.Parse(cmbAddOlympics.SelectedValue.ToString()), int.Parse(cmbAddDiscipline.SelectedValue.ToString()), eventType);
        }

        private void btnViewEvents_Click(object sender, EventArgs e) 
        {
            gbAthleteDetails.Visible = false;
            gbDelete.Visible = false;
            bool valid = true;
            if (string.IsNullOrEmpty(cmbAddDiscipline.Text))
            {
                valid = false;
                cmbAddDiscipline.Focus();
            }
            if (string.IsNullOrEmpty(cmbAddEvent.Text))
            {
                valid = false;
                cmbAddEvent.Focus();
            }
            if (valid == true)
            {
                if (eventType == "T")
                    ViewTeamEvents();
                else
                    ViewIndividualEvents();
            }           
        }

        private void dgvMedalist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvMedalist.SelectedCells[0].RowIndex;
            txtAddAthleteNo.Text = dgvMedalist["athleteNo", i].Value.ToString();
        }

        public void ViewTeamEvents()
        {
           // MessageBox.Show("Team");
            athlete = new Athlete();
            dgvMedalist.DataSource = athlete.getTeamMembers(int.Parse(cmbAddOlympics.SelectedValue.ToString()), int.Parse(cmbAddEvent.SelectedValue.ToString()), int.Parse(cmbAddCountry.SelectedValue.ToString()));

            if (dgvMedalist.RowCount > 1)
            {
                gbAthleteDetails.Visible = true;
                gbDelete.Visible = true;
            }
        }

        public void ViewIndividualEvents()
        {
            athlete = new Athlete();
            dgvMedalist.DataSource = athlete.getEventAthletes(int.Parse(cmbAddOlympics.SelectedValue.ToString()), int.Parse(cmbAddEvent.SelectedValue.ToString()));

            if (dgvMedalist.RowCount > 1)
            {
                gbAthleteDetails.Visible = true;
                gbDelete.Visible = true;
            }
        }

        public void AddIndividualMedal(string medal, int year,int eventNo, int athleteNo, string PB, int position)
        {
            result = new Results();
            int x = result.updateResults(athleteNo, year, eventNo, medal, position, PB);
            if (x > 0)
            {
                MessageBox.Show("The result has been recorded", "Success");
                ClearFields();                
            }
             else
                 MessageBox.Show("An error occured");
        }

        public void AddTeamMedal(string medal, int year, int eventNo, string PB, int position)
        {
            //goes to each record displayed in the grid and updates the record
            string athleteNo = " ";
            int count = 0;
           foreach(DataGridViewRow row in dgvMedalist.Rows)
            {
                if (dgvMedalist.Rows[count].Cells[0].Value != null)//the last row is null
                {
                    athleteNo = row.Cells[0].Value.ToString();
                    result = new Results();
                    int x = result.updateResults(int.Parse(athleteNo), year, eventNo, medal, position, PB);
                    if (x > 0)
                        count++;
                }              
            }

            if (count == dgvMedalist.RowCount - 1)
            {
                MessageBox.Show("All medals have been assigned");
                ClearFields();
            }
            else
                MessageBox.Show("Some or no medals were assigned");
        }

        public void ClearFields()
        {
            gbAthleteDetails.Visible = false;
            gbDelete.Visible = false;
            txtAddAthleteNo.Text = "";
            txtAddPosition.Text = "";
            txtAddResult.Text = "";

            cmbAddEvent.DataSource = null;
            cmbAddDiscipline.DataSource = null;
            cmbAddEvent.DataSource = null;
            cmbAddOlympics.DataSource = null;
            dgvMedalist.DataSource = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool validated = true;
            if (string.IsNullOrEmpty(txtAddAthleteNo.Text))
            {
                validated = false;
                MessageBox.Show("Please select an athlete");
                txtAddAthleteNo.Focus();
            }
            int x = -1;
            if (validated == true)
            {
                if (MessageBox.Show("Are you sure you want to delete medals(s)?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (eventType == "I")
                    {
                        x = DeleteIndividualMedal();
                    }
                    else if (eventType == "T")
                    {
                        x = DeleteTeamMedal();
                    }
                }
                if (x > 0)
                {
                    MessageBox.Show("medal has been deleted");
                    ClearFields();
                    btnAddMedals_Click(sender, e);
                }
            }
        }

        private int DeleteIndividualMedal()
        {
            result = new Results();
            return result.deleteMedal(int.Parse(txtAddAthleteNo.Text));
        }

        private int DeleteTeamMedal()
        {
            int count = 0;
            int x = 0;
            foreach(DataGridViewRow row in dgvMedalist.Rows)
            {
                if (dgvMedalist.Rows[count].Cells[0].Value != null)//checks if there is a value in the cell
                {
                    result = new Results();                    
                    try
                    {
                        x = result.deleteMedal(int.Parse(row.Cells[0].Value.ToString()));
                    }
                    catch (System.NullReferenceException)//still gets the last row which is null 
                    {
                        x = 1;
                    }
                }
            }
            return x;
        }
    }
}
