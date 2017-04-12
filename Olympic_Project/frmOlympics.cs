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
    public partial class frmOlympics : Form
    {
        Country country;
        Olympics olympic;
        public frmOlympics()
        {
            InitializeComponent();
        }

        public void HideAllPanels()
        {
            bool x = false;
            pnlAddOlympic.Visible = x;
            pnlChangeOlympics.Visible = x;
            pnlDeleteOlympics.Visible = x;
            pnlOlympicDetails.Visible = x;
        }

        private void btnAddOlympic_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlAddOlympic.Visible = true;
            country = new Country();
            cmbAddCountry.DataSource = country.getActiveCountries();
            cmbAddCountry.DisplayMember = "countryName";
            cmbAddCountry.ValueMember = "countryID";
        }

        private void btnActivateCountry_Click(object sender, EventArgs e)//btnAddOlympics
        {
            int countryID = int.Parse(cmbAddCountry.SelectedValue.ToString());
            int year = int.Parse(txtAddYear.Text);
            string city = txtAddCity.Text;
            string startDate = dteAddStart.Value.ToShortDateString();
            string endDate = dteAddEnd.Value.ToShortDateString();
            olympic = new Olympics();
            if (city != null || city != " ")
            {
                if (olympic.isProductOf4(year))
                {
                    int x = olympic.insertOlympics(year, countryID, startDate, endDate, city, city + " " + year.ToString());
                    if (x > 0)
                        MessageBox.Show("A new olympics was added");
                    else
                        MessageBox.Show("Olympics could not be added");
                }
                else
                    MessageBox.Show("Olympics is every 4 years", "Error");
            }
            else
                MessageBox.Show("Enter a city name");
        }

        private void btnChangeOlympics_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlChangeOlympics.Visible = true;
            olympic = new Olympics();
            cmbChangeYear.DataSource = olympic.getAllOlympics();
            cmbChangeYear.DisplayMember = "olympicID";
            cmbChangeYear.ValueMember = "city"; //value member is city so that we can display the city name in the text box

            cmbChangeYear.SelectedIndex = 0;
            txtChangeCity.Text = cmbChangeYear.SelectedValue.ToString();
         
        }

        private void cmbChangeYear_SelectedIndexChanged(object sender, EventArgs e)//when they select an olympics the city name must change to whats in there
        {
            txtChangeCity.Text = cmbChangeYear.SelectedValue.ToString();
        }

        private void btnUpdateOlympics_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChangeCity.Text))
            {
                MessageBox.Show("Please select an Olympic and change the hosting city");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update the olympics?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    olympic = new Olympics();
                    int x = olympic.updateOlympic(int.Parse(cmbChangeYear.Text), txtChangeCity.Text);
                    if (x > 0)
                    {
                        MessageBox.Show("Olympics has been updated");
                    }
                    else
                        MessageBox.Show("Error. Could not update");
                }
            }
        }

        private void btnOlympicDelete_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlDeleteOlympics.Visible = true;
            olympic = new Olympics();
            cmbDeleteYear.DataSource = olympic.getAllOlympics(); //could make it a search 
            cmbDeleteYear.DisplayMember = "olympicID";
            cmbDeleteYear.ValueMember = "olympicID";
        }

        private void btnDeleteOlympic_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this olympic year? It will be removed permantly", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                olympic = new Olympics();
                int x = olympic.deleteOlympic(int.Parse(cmbDeleteYear.SelectedValue.ToString()));
                if (x > 0)
                {
                    MessageBox.Show("This olympic has beem permantely removed");
                    btnOlympicDelete_Click(sender, e);
                }
                else
                    MessageBox.Show("Could not remove olympics");
            }
        }

        private void btnOlympicDetails_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlOlympicDetails.Visible = true;

            olympic = new Olympics();
            cmbDetYear.DisplayMember = "olympicName";
            cmbDetYear.ValueMember = "olympicID";
            cmbDetYear.DataSource = olympic.getAllOlympics();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            string name, athlete, countrie, events;
            Olympics olympic = new Olympics();
            olympic = olympic.getOlympicDetails(int.Parse(cmbDetYear.SelectedValue.ToString()));
            name = olympic.CountryName;
            athlete = olympic.NoOfAthletes.ToString();
            countrie = olympic.NoOfCountries.ToString();
            events = olympic.NoOfEvents.ToString();

            DisplayHeading();          
            string line = string.Format("{0,-15} {1,-9} {2,-10} {3,-7}", name, athlete, countrie, events);
            lstOlympicDetails.Items.Add(line);
        }

        private void DisplayHeading()
        {
            lstOlympicDetails.Items.Clear();
            lstOlympicDetails.Items.Add(cmbDetYear.Text);
            string line = string.Format("{0,-15} {1,-9} {2,-10} {3,-7}", "Country", "Athletes", "Countries", "Events");
            lstOlympicDetails.Items.Add(line);
        }
    }
}
