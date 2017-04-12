using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Olympic_Project
{
    public partial class frmDiscipline : Form
    {
        Discipline discipline;
        public frmDiscipline()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void HideAllPanels()
        {
            bool x = false;
            pnlAddDiscipline.Visible = x;
            pnlUpdateDiscipline.Visible = x;
            pnlDisciplineActive.Visible = x;
            pnlDelete.Visible = x;
        }

        private void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlAddDiscipline.Visible = true;
            txtAddDiscName.Text = " ";
        }

        private void btnOpenDisLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "image files (*.png|*.png|All Files (*.*)|*.*";
            fileChooser.InitialDirectory = "C:\\Users\\Shannon\\Desktop\\ICT\\ONT2000\\Practicals\\SEM 2\\Project\\Disciplines";
            fileChooser.Title = "Select the discipline's logo";
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                pcbDisciplineLogo.ImageLocation = fileChooser.FileName;
                pcbDisciplineLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDisciplineAdd_Click(object sender, EventArgs e)
        {
            //cater for if the user does not choose an image
            //ask the user if they are sure they want to create
            //if there is an error
            byte[] imgData;
            imgData = File.ReadAllBytes(pcbDisciplineLogo.ImageLocation);
            string disciplineName = txtAddDiscName.Text;
            int active = 0;
            if (cbAddDiscActive.Checked)
                active = 1;
            discipline = new Discipline();
            int x = discipline.insertDiscipline(disciplineName, imgData, active);
            if (x > 0)
            {
                MessageBox.Show("Discipline has successfully been added");
                btnAddDiscipline_Click(sender, e);
            }
        }

        private void btnUpdateDiscipline_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlUpdateDiscipline.Visible = true;
            discipline = new Discipline();
            cmbUpdateDiscipline.DataSource = discipline.getAllDisciplines();
            cmbUpdateDiscipline.DisplayMember = "disciplineName";
            cmbUpdateDiscipline.ValueMember = "disciplineNo";
        }

        private void cmbUpdateDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
          // if the combo box item is changed the page is refreshed
          
        }

        private void btnUpdateDisplay_Click(object sender, EventArgs e)//displays data related to the combobox
        {
            pcbDisciplineLogoU.Image = null;
            btnDisciplineUpdate.Enabled = true;
            discipline = new Discipline();
            discipline = discipline.getADiscipline(int.Parse(cmbUpdateDiscipline.SelectedValue.ToString()));
            txtUpdateName.Text = discipline.Name;

            byte[] imgData = discipline.Logo;
            MemoryStream stmBOLBData = new MemoryStream(imgData);
            pcbDisciplineLogoU.Image = Image.FromStream(stmBOLBData);
            pcbDisciplineLogoU.SizeMode = PictureBoxSizeMode.StretchImage;

            if (discipline.Active >= 1)
                cbActiveUpdate.Checked = true;
            else
                cbActiveUpdate.Checked = false;
        }

        private void btnDisciplineUpdate_Click(object sender, EventArgs e)//save the new data and update
        {
            //validate information
            int no = int.Parse(cmbUpdateDiscipline.SelectedValue.ToString());
            string name = txtUpdateName.Text;
            int active = 0;
            if (cbActiveUpdate.Checked)
                active = 1;

             MemoryStream ms = new MemoryStream();                                          //this converts the image into bytes
             pcbDisciplineLogoU.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
             byte[] imgData = ms.GetBuffer();

            discipline = new Discipline();
            int x = discipline.updateDiscipline(no, name, imgData, active);
            if (x > 0)
            {
                MessageBox.Show("Discipline was updated");
                btnUpdateDiscipline_Click(sender, e);
            }
        }

        private void btnOpenDisciLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "image files (*.png|*.png|All Files (*.*)|*.*";
            fileChooser.InitialDirectory = "C:\\Users\\Shannon\\Desktop\\ICT\\ONT2000\\Practicals\\SEM 2\\Project\\Disciplines";
            fileChooser.Title = "Select the discipline's logo";
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                pcbDisciplineLogoU.ImageLocation = fileChooser.FileName;
                pcbDisciplineLogoU.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnActivateDiscipline_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlDisciplineActive.Visible = true;
            discipline = new Discipline();
            cmbDeactiveDiscipline.DataSource = discipline.getDeactiveDisciplines();
            cmbDeactiveDiscipline.DisplayMember = "disciplineName";
            cmbDeactiveDiscipline.ValueMember = "disciplineNo";
        }

        private void btnDisciplineActive_Click(object sender, EventArgs e)
        {
            discipline = new Discipline();
            int x = discipline.updateDisciplineStatus(int.Parse(cmbDeactiveDiscipline.SelectedValue.ToString()));
            if (x > 0)
            {
                MessageBox.Show("Discipline is now activated");
                btnActivateDiscipline_Click(sender, e);
            }
        }

        private void btnDisplayDel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            discipline = new Discipline();
            discipline = discipline.getADiscipline(int.Parse(cmbDelDiscipline.SelectedValue.ToString()));
            txtDelName.Text = discipline.Name;
        }

        private void btnDeleteDiscipline_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnlDelete.Visible = true;
            txtDelName.Text = "";

            discipline = new Discipline();
            cmbDelDiscipline.ValueMember = "disciplineNo";
            cmbDelDiscipline.DisplayMember = "disciplineName";
            cmbDelDiscipline.DataSource = discipline.getAllDisciplines();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            discipline = new Discipline();
            if (MessageBox.Show("Are you sure you want to delete this discpline?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int x = discipline.deleteDiscipline(int.Parse(cmbDelDiscipline.SelectedValue.ToString()));
                if (x > 0)
                {
                    MessageBox.Show("Disicipline was removed");
                    btnDeleteDiscipline_Click(sender, e);
                }
                else
                    MessageBox.Show("Could not delete discipline");
            }
        }
    }
}
