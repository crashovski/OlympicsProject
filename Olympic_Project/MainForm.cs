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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();          
        }

        private void btnCountrie_Click(object sender, EventArgs e)
        {
            frmCountry country = new frmCountry();
            country.Show();
        }

        private void pbMini_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscipline_Click(object sender, EventArgs e)
        {
            frmDiscipline discipline = new frmDiscipline();
            discipline.Show();
        }

        private void btnAthlete_Click(object sender, EventArgs e)
        {
            frmAthlete athlete = new frmAthlete();
            athlete.Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            frmEvent events = new frmEvent();
            events.Show();
        }

        private void btnOlympics_Click(object sender, EventArgs e)
        {
            frmOlympics olymp = new frmOlympics();
            olymp.Show();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            frmResults medal = new frmResults();
            medal.Show();
        }
    }
}
