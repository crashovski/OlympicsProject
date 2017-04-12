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
    public partial class frmEvent : Form
    {
        Event events;
        Discipline discipline;
        public frmEvent()
        {
            InitializeComponent();
        }

        public void HideAllPanels()
        {
            bool x = false;
            pnlAddEvent.Visible = x;
            pnlViewEvents.Visible = x;
            pnlRegisterEvent.Visible = x;
            pnlEventStatus.Visible = x;
            pnlDeleteEvent.Visible = x;
            pnlUpdateEvent.Visible = x;
        }
        
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlAddEvent.Visible = true;
            discipline = new Discipline();
            cmbDisciplineAdd.DataSource = discipline.getAllDisciplines();
            cmbDisciplineAdd.DisplayMember = "disciplineName";
            cmbDisciplineAdd.ValueMember = "disciplineNo";
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            string gender = "M", eventType = "I", eventName;
            string OR, WR;
            OR = txtAddOR.Text;
            WR = txtAddWR.Text;
            if (rbFemale.Checked)//already a M so if the if is true then it changes
                gender = "F";
            if (rbTeam.Checked)//already an I, will change if Team is checked
                eventType = "T";
            int disciplineNo = int.Parse(cmbDisciplineAdd.SelectedValue.ToString());
            eventName = txtAddEventName.Text + " " + gender;

            events = new Event();
            int x = events.insertEvent(disciplineNo, eventName, eventType, gender, OR, WR);
            if (x > 0)
            {
                MessageBox.Show("Event has successfully been added");
            }
            else
            {
                MessageBox.Show("This event could not be added at this time", "Error");
            }
        }

        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlViewEvents.Visible = true;
            discipline = new Discipline();
            cmbViewEventsDiscipine.DataSource = discipline.getAllDisciplines();
            cmbViewEventsDiscipine.DisplayMember = "disciplineName";
            cmbViewEventsDiscipine.ValueMember = "disciplineNo";
        }

        private void btnRegisterEvents_Click(object sender, EventArgs e)
        {           
            HideAllPanels();
            pnlRegisterEvent.Visible = true;
            discipline = new Discipline();
            cmbRegDiscipline.DisplayMember = "disciplineName";
            cmbRegDiscipline.ValueMember = "disciplineNo";
            cmbRegDiscipline.DataSource = discipline.getAllDisciplines();
            
            cmbRegDiscipline.SelectedIndex = 0;
        }

        private void cmbRegDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRegEvent.DataSource = null;
            try
            {
                events = new Event();
                cmbRegEvent.DisplayMember = "eventName";
                cmbRegEvent.ValueMember = "eventNo";
                cmbRegEvent.DataSource = events.getEventsinDiscipline(int.Parse(cmbRegDiscipline.SelectedValue.ToString()));
                
            }
            catch (Exception)
            {               
                MessageBox.Show("There is no events for this discipline");
            }
        }

        private void btnRegisterEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbRegEvent.Text))//if there are no events
            {
                MessageBox.Show("There are no events for this discipline");
            }
            else if (txtRegYear.Text != null || txtEventTime.Text != null)
            {
                RegisterEvent();
            }
            else
                MessageBox.Show("Please enter values in all fields");   
                
        }

        public void RegisterEvent()
        {
            int eventNo = int.Parse(cmbRegEvent.SelectedValue.ToString());
            int year = int.Parse(txtRegYear.Text);
            string date = dtEventDate.Value.ToShortDateString();
            string time = txtEventTime.Text;
            events = new Event();
            int x = events.insertOlympicEvent(eventNo, year, date, time);
            if (x > 0)
            {
                MessageBox.Show("Event has been registered to this years olympics");
            }
            else
                MessageBox.Show("This event is already registered for this year");
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlDeleteEvent.Visible = true;

            lstCurrentEvents.DataSource = null;
            events = new Event();
            lstCurrentEvents.DataSource = events.getAllEvents();
            lstCurrentEvents.DisplayMember = "eventName";
            lstCurrentEvents.ValueMember = "eventNo";
        }

        private void btnViewAllEvents_Click(object sender, EventArgs e)
        {
            events = new Event();
            dgvViewEvent.DataSource = events.getAllEvents();
        }

        private void btnViewRegisteredEv_Click(object sender, EventArgs e)
        {
            events = new Event();
            dgvViewEvent.DataSource = events.getOlympicEvents();
        }

        private void btnViewEvinDiscipline_Click(object sender, EventArgs e)
        {
            events = new Event();
            dgvViewEvent.DataSource = events.getEventsinDiscipline(int.Parse(cmbViewEventsDiscipine.SelectedValue.ToString()));
            
        }

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            int x = -1;
            int y = -1;
            if (MessageBox.Show("Do you want to delete event(s)? All Results will be removed as well", "File Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                events = new Event();
                foreach (var i in lstCurrentEvents.SelectedItems)
                {
                    x = events.deleteEvent(int.Parse(((DataRowView)i)["eventNo"].ToString()));  //gets the value member of the item in list box
                    y = events.deleteEventAthlete(int.Parse(((DataRowView)i)["eventNo"].ToString()), 2016);
                }
                if (x > 0)  //resets the panel and combo box
                {
                    MessageBox.Show("Events have been deleted");
                    HideAllPanels();
                    btnDeleteEvent_Click(sender, e);
                }
                else
                    MessageBox.Show("Could not delete this event");
            }
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlUpdateEvent.Visible = true;

            events = new Event();
            dgvUpdateEvent.DataSource = events.getAllEvents();
        }

        private void dgvUpdateEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvUpdateEvent.SelectedCells[0].RowIndex;
            txtUpNo.Text = dgvUpdateEvent["eventNo", i].Value.ToString();
            txtUpName.Text = dgvUpdateEvent["eventName", i].Value.ToString();
            txtUpOR.Text = dgvUpdateEvent["olympicRecord", i].Value.ToString();
            txtUpWR.Text = dgvUpdateEvent["worldRecord", i].Value.ToString();

            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x = -1;
            bool valid = true;
            if (string.IsNullOrEmpty(txtUpOR.Text) && string.IsNullOrEmpty(txtUpWR.Text))
            {
                valid = false;
            }

            if (valid == true)
            {
                if (MessageBox.Show("Are you sure you want to update and save?", "File Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    events = new Event();
                    x = events.updateEvent(int.Parse(txtUpNo.Text), txtUpOR.Text, txtUpWR.Text);
                    if (x > 0)  //resets the panel and combo box
                    {
                        MessageBox.Show("Events have been edited");
                        HideAllPanels();
                        btnUpdateEvent_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Could not edit this event");
                }
            }
        }

        private void btnShowDates_Click(object sender, EventArgs e)
        {
            string start = dtpStartDate.Value.ToShortDateString();
            string end = dtpEndDate.Value.ToShortDateString();
            events = new Event();

            dgvViewEvent.DataSource = null;
            dgvViewEvent.DataSource = events.getEventbyDates(start, end);
        }
    }
}
