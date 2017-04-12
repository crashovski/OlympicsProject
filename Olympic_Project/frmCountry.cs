using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Olympic_Project
{
    public partial class frmCountry : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = Olympics;Integrated Security = SSPI");//used to add a flag
        SqlCommand cmd;                                                                                                          //will remove later
        String sql;

        public frmCountry()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "image files (*.png|*.png|All Files (*.*)|*.*";
            fileChooser.InitialDirectory = "C:\\Users\\Shannon\\Desktop\\ICT\\ONT2000\\Practicals\\SEM 2\\Project\\Flags";
            fileChooser.Title = "Select the country's flag";
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                pcbFlag.ImageLocation = fileChooser.FileName;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            this.Close();
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlAddFlag.Visible = true;
            Country cntr = new Country();

            cmbCountry.DataSource = cntr.getAllCountries();  //gets active and deactive countries
            cmbCountry.DisplayMember = "countryName";
            cmbCountry.ValueMember = "countryID";

        }

        private void btnSave_Click(object sender, EventArgs e)  //need to put this in Data Access Layer. Saving the flag
        {
            try
            {
                sql = "UPDATE Country SET flag = @flag WHERE countryID = @ID";

                byte[] imgData;
                imgData = File.ReadAllBytes(pcbFlag.ImageLocation);
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@flag", imgData);
                cmd.Parameters.AddWithValue("@ID", cmbCountry.SelectedValue);

                conn.Open();
                int x = cmd.ExecuteNonQuery();
                conn.Close();

                if (x >= 0)
                    MessageBox.Show("flag has successfully been added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }



        }

        private void btnViewCountry_Click(object sender, EventArgs e)//view country
        {                                                    //will display all active countries name and ID in combobox
            HideAllPanels();
            pnlViewCountry.Visible = true;
            Country cntr = new Country();
            cmbViewCountry.DataSource = cntr.getActiveCountries();
            cmbViewCountry.DisplayMember = "countryName";
            cmbViewCountry.ValueMember = "countryID";
        }

        private void HideAllPanels() //hides all the panels so that you only see one at a time
        {
            bool x = false;
            pnlAddFlag.Visible = x;
            pnlViewCountry.Visible = x;
            pnlAddCountry.Visible = x;
            pnlActivate.Visible = x;
            pnlDeleteCountry.Visible = x;
            pnlCountryView.Visible = x;
            pnlUpdate.Visible = x;
        }

        private void btnDisplay_Click(object sender, EventArgs e) //displays the country flag with the parameters
        {
            lstOlympicMedal.Items.Clear();
            string name, pres, email;
            Country cntr = new Country();

            try
            {
                Byte[] img = cntr.getCountryFlag(int.Parse(cmbViewCountry.SelectedValue.ToString()));
                MemoryStream stmBLOBData = new MemoryStream(img);
                pcbCountryFlag.Image = Image.FromStream(stmBLOBData);
            }
            catch (Exception)
            {
                pcbCountryFlag.Image = null;
                pcbCountryFlag.BackColor = Color.DeepSkyBlue;
            }

            pnlCountryView.Visible = true;

            Country country = new Country();                                    //whatever was clicked in the combo box will display
            country = country.getACountry(int.Parse(cmbViewCountry.SelectedValue.ToString()));     //in the the text boxes
            name = country.Name;
            pres = country.President;
            email = country.Email;
            txtPresident.Text = pres;
            txtEmail.Text = email;
            lblCountryName.Text = name;
            ShowCountryMedals(int.Parse(cmbViewCountry.SelectedValue.ToString()));
        }

        private int CountMedalsTeam(int countryID, string medal)//returns values for team events
        {
            int count = 0;
            Country country = new Country();
            country = country.CountTeamMedalCountry(countryID, 2016, medal);
            count = country.NoOfMedals;
            return count;
        }
        private int CountMedalsIndividual(int countryID, string medal)//returns value for individual events
        {
            int count = 0;
            Country country = new Country();
            country = country.CountIndividualMedalCountry(countryID, 2016, medal);
            count = country.NoOfMedals;
            return count;
        }

        private void ShowCountryMedals(int countryID)
        {
            int bronze = 0, silver = 0, gold = 0;
            bronze = CountMedalsIndividual(countryID, "B");
            bronze = bronze + CountMedalsTeam(countryID, "B");

            silver = CountMedalsIndividual(countryID, "S");
            silver = silver + CountMedalsTeam(countryID, "S");

            gold = CountMedalsIndividual(countryID, "G");
            gold = gold + CountMedalsTeam(countryID, "G");

            lstOlympicMedal.Items.Clear();
            lstOlympicMedal.Items.Add("For Rio 2016");//at the moment it only displays for the one olympic event
            lstOlympicMedal.Items.Add("G\tS\tB");
            lstOlympicMedal.Items.Add(gold + "\t" + silver + "\t" + bronze);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name, pres, email;
            int active = 0; //0 - inactive. 1 - active
                            //validate that the correct data type has been entered and not null
            if (MessageBox.Show("Do you want to add a new country?", "Saving Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                name = txtName.Text;
                pres = txtAddPres.Text;
                email = txtAddEmail.Text;
                if (cbActive.Checked == true)
                    active = 1;
                Country cntr = new Country();
                int x = cntr.insertCountry(name, pres, email, active);
            }
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlAddCountry.Visible = true;
        }

        private void btnActivate_Click(object sender, EventArgs e)//will show all deactive countries
        {
            HideAllPanels();
            pnlActivate.Visible = true;
            Country cntr = new Country();

            lstDeactiveCountry.DataSource = cntr.getDeactiveCountries();
            lstDeactiveCountry.ValueMember = "countryID";
            lstDeactiveCountry.DisplayMember = "countryName";
        }

        private void btnActivateCountry_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (MessageBox.Show("Do you want to activate the country(s) ?", "File Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Country cntr = new Country();
                foreach (var i in lstDeactiveCountry.SelectedItems)
                {
                    x = cntr.updateCountryStatus(int.Parse(((DataRowView)i)["countryID"].ToString()));  //gets the value member of the item in list box
                }
                if (x > 0)  //resets the panel and combo box
                {
                    MessageBox.Show("Countries have been activated");
                    HideAllPanels();
                    btnActivateCountry_Click(sender, e);
                }
            }


        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)//will display active countries that can be deleted
        {
            HideAllPanels();
            pnlDeleteCountry.Visible = true;
            Country cntr = new Country();
            cmbDelActive.DataSource = cntr.getActiveCountries();
            cmbDelActive.ValueMember = "countryID";
            cmbDelActive.DisplayMember = "countryName";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this country ?", "File Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Country cntr = new Country();
                int x = cntr.deleteCountry(int.Parse(cmbDelActive.SelectedValue.ToString()));
                if (x > 0)
                {
                    MessageBox.Show("Country has been removed");
                    HideAllPanels();
                    btnDeleteCountry_Click(sender, e);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlUpdate.Visible = true;
        }

        private void btnSearchCountry_Click(object sender, EventArgs e)
        {
            int n;
            bool intValid = int.TryParse(txtSearchUpdate.Text, out n);
            
            if (string.IsNullOrEmpty(txtSearchUpdate.Text))
            {             
                txtSearchUpdate.Focus();
                MessageBox.Show("Please enter a country ID");
                btnUpdateCountry.Enabled = false;
            }
            else
            {
                if (intValid == true)
                {
                    Country country = new Country();
                    country = country.getACountry(int.Parse(txtSearchUpdate.Text));
                    txtUpdateEmail.Text = country.Email;
                    txtUpdatePresident.Text = country.President;
                    txtUpdateName.Text = country.Name;
                    btnUpdateCountry.Enabled = true;
                }
                else
                    MessageBox.Show("Incorrect data entered. Numbers only");
            }        
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            dgvCountry.DataSource = country.getAllCountries();
        }

        private void dgvCountry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCountry.SelectedCells[0].RowIndex;
            txtUpdateEmail.Text = dgvCountry["email", i].Value.ToString();
            txtUpdatePresident.Text = dgvCountry["president", i].Value.ToString();
            txtUpdateName.Text = dgvCountry["countryName", i].Value.ToString();
            txtSearchUpdate.Text = dgvCountry["countryID", i].Value.ToString();
            btnUpdateCountry.Enabled = true;
        }

        private void btnUpdateCountry_Click(object sender, EventArgs e)
        {
            int x = 0;
            string name, pres, email;
            int id = int.Parse(txtSearchUpdate.Text);
            name = txtUpdateName.Text;
            pres = txtUpdatePresident.Text;
            email = txtUpdateEmail.Text;
            Country country = new Country();
            if (country.isEmpty(txtUpdateName.Text) == false)
            {
                if (country.isEmpty(txtUpdateEmail.Text) == false)
                {
                    if (country.isEmpty(txtUpdatePresident.Text) == false)
                    {
                        x = country.updateCountry(id, name, pres, email);
                        if (x > 0)
                        {
                            MessageBox.Show("Country has been updated");
                            HideAllPanels();
                            txtUpdateEmail.Text = "";
                            txtUpdateName.Text = "";
                            txtUpdatePresident.Text = "";
                            txtSearchUpdate.Text = "";
                            btnDisplayAll_Click(sender, e); //must reset database
                        }
                    }
                    else
                        MessageBox.Show("Please fill in all fields");
                }
                else
                    MessageBox.Show("Please fill in all fields");
            }
            
        }
        
    }
}
