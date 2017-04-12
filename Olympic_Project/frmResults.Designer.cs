namespace Olympic_Project
{
    partial class frmResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResults));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlAddMedalsI = new System.Windows.Forms.Panel();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbEvents = new System.Windows.Forms.GroupBox();
            this.cmbAddCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbAddEvent = new System.Windows.Forms.ComboBox();
            this.cmbAddDiscipline = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnViewEvents = new System.Windows.Forms.Button();
            this.cmbAddOlympics = new System.Windows.Forms.ComboBox();
            this.gbAthleteDetails = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddAthleteNo = new System.Windows.Forms.TextBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMedal = new System.Windows.Forms.Label();
            this.cmbAddMedal = new System.Windows.Forms.ComboBox();
            this.txtAddPosition = new System.Windows.Forms.TextBox();
            this.txtAddResult = new System.Windows.Forms.TextBox();
            this.dgvMedalist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlViewMedalWinners = new System.Windows.Forms.Panel();
            this.lstViewWinners = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbViewEvents = new System.Windows.Forms.ComboBox();
            this.cmbViewDiscipline = new System.Windows.Forms.ComboBox();
            this.cmbViewYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnViewEventWinners = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnViewMedalWinners = new System.Windows.Forms.Button();
            this.btnAddMedal = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMini = new System.Windows.Forms.PictureBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlAddMedalsI.SuspendLayout();
            this.gbDelete.SuspendLayout();
            this.gbEvents.SuspendLayout();
            this.gbAthleteDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedalist)).BeginInit();
            this.pnlViewMedalWinners.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMini)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.pnlViewMedalWinners);
            this.pnlMain.Controls.Add(this.pnlAddMedalsI);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(167, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(558, 355);
            this.pnlMain.TabIndex = 8;
            // 
            // pnlAddMedalsI
            // 
            this.pnlAddMedalsI.BackColor = System.Drawing.Color.White;
            this.pnlAddMedalsI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddMedalsI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddMedalsI.Controls.Add(this.gbDelete);
            this.pnlAddMedalsI.Controls.Add(this.gbEvents);
            this.pnlAddMedalsI.Controls.Add(this.gbAthleteDetails);
            this.pnlAddMedalsI.Controls.Add(this.dgvMedalist);
            this.pnlAddMedalsI.Controls.Add(this.label2);
            this.pnlAddMedalsI.Location = new System.Drawing.Point(0, 0);
            this.pnlAddMedalsI.Name = "pnlAddMedalsI";
            this.pnlAddMedalsI.Size = new System.Drawing.Size(549, 343);
            this.pnlAddMedalsI.TabIndex = 3;
            this.pnlAddMedalsI.Visible = false;
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.label9);
            this.gbDelete.Controls.Add(this.btnDelete);
            this.gbDelete.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDelete.Location = new System.Drawing.Point(234, 191);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(173, 141);
            this.gbDelete.TabIndex = 32;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Delete Medal";
            this.gbDelete.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 56);
            this.label9.TabIndex = 13;
            this.label9.Text = "This will remove the medal \r\nthe athlete currently has.\r\nTheir position and score" +
    "\r\nwill remain the same";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(45, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbEvents
            // 
            this.gbEvents.Controls.Add(this.cmbAddCountry);
            this.gbEvents.Controls.Add(this.lblCountry);
            this.gbEvents.Controls.Add(this.cmbAddEvent);
            this.gbEvents.Controls.Add(this.cmbAddDiscipline);
            this.gbEvents.Controls.Add(this.label3);
            this.gbEvents.Controls.Add(this.label13);
            this.gbEvents.Controls.Add(this.label14);
            this.gbEvents.Controls.Add(this.btnViewEvents);
            this.gbEvents.Controls.Add(this.cmbAddOlympics);
            this.gbEvents.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEvents.Location = new System.Drawing.Point(17, 23);
            this.gbEvents.Name = "gbEvents";
            this.gbEvents.Size = new System.Drawing.Size(200, 157);
            this.gbEvents.TabIndex = 31;
            this.gbEvents.TabStop = false;
            this.gbEvents.Text = "Events";
            // 
            // cmbAddCountry
            // 
            this.cmbAddCountry.FormattingEnabled = true;
            this.cmbAddCountry.Location = new System.Drawing.Point(76, 103);
            this.cmbAddCountry.Name = "cmbAddCountry";
            this.cmbAddCountry.Size = new System.Drawing.Size(92, 22);
            this.cmbAddCountry.TabIndex = 31;
            this.cmbAddCountry.Visible = false;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.White;
            this.lblCountry.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(9, 106);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(51, 14);
            this.lblCountry.TabIndex = 30;
            this.lblCountry.Text = "Country";
            this.lblCountry.Visible = false;
            // 
            // cmbAddEvent
            // 
            this.cmbAddEvent.FormattingEnabled = true;
            this.cmbAddEvent.Location = new System.Drawing.Point(76, 73);
            this.cmbAddEvent.Name = "cmbAddEvent";
            this.cmbAddEvent.Size = new System.Drawing.Size(92, 22);
            this.cmbAddEvent.TabIndex = 29;
            // 
            // cmbAddDiscipline
            // 
            this.cmbAddDiscipline.FormattingEnabled = true;
            this.cmbAddDiscipline.Location = new System.Drawing.Point(77, 44);
            this.cmbAddDiscipline.Name = "cmbAddDiscipline";
            this.cmbAddDiscipline.Size = new System.Drawing.Size(92, 22);
            this.cmbAddDiscipline.TabIndex = 28;
            this.cmbAddDiscipline.SelectionChangeCommitted += new System.EventHandler(this.cmbAddDiscipline_SelectionChangeCommitted_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Event";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(10, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 14);
            this.label13.TabIndex = 27;
            this.label13.Text = "Discipline";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(9, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "Olympics";
            // 
            // btnViewEvents
            // 
            this.btnViewEvents.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEvents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewEvents.Location = new System.Drawing.Point(77, 130);
            this.btnViewEvents.Name = "btnViewEvents";
            this.btnViewEvents.Size = new System.Drawing.Size(65, 23);
            this.btnViewEvents.TabIndex = 26;
            this.btnViewEvents.Text = "Search";
            this.btnViewEvents.UseVisualStyleBackColor = false;
            this.btnViewEvents.Click += new System.EventHandler(this.btnViewEvents_Click);
            // 
            // cmbAddOlympics
            // 
            this.cmbAddOlympics.FormattingEnabled = true;
            this.cmbAddOlympics.Location = new System.Drawing.Point(76, 15);
            this.cmbAddOlympics.Name = "cmbAddOlympics";
            this.cmbAddOlympics.Size = new System.Drawing.Size(92, 22);
            this.cmbAddOlympics.TabIndex = 25;
            this.cmbAddOlympics.SelectionChangeCommitted += new System.EventHandler(this.cmbAddOlympics_SelectionChangeCommitted);
            // 
            // gbAthleteDetails
            // 
            this.gbAthleteDetails.Controls.Add(this.label15);
            this.gbAthleteDetails.Controls.Add(this.txtAddAthleteNo);
            this.gbAthleteDetails.Controls.Add(this.btnAddResult);
            this.gbAthleteDetails.Controls.Add(this.label4);
            this.gbAthleteDetails.Controls.Add(this.label10);
            this.gbAthleteDetails.Controls.Add(this.lblMedal);
            this.gbAthleteDetails.Controls.Add(this.cmbAddMedal);
            this.gbAthleteDetails.Controls.Add(this.txtAddPosition);
            this.gbAthleteDetails.Controls.Add(this.txtAddResult);
            this.gbAthleteDetails.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAthleteDetails.Location = new System.Drawing.Point(17, 180);
            this.gbAthleteDetails.Name = "gbAthleteDetails";
            this.gbAthleteDetails.Size = new System.Drawing.Size(200, 160);
            this.gbAthleteDetails.TabIndex = 29;
            this.gbAthleteDetails.TabStop = false;
            this.gbAthleteDetails.Text = "Result Details";
            this.gbAthleteDetails.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(9, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Athlete";
            // 
            // txtAddAthleteNo
            // 
            this.txtAddAthleteNo.Enabled = false;
            this.txtAddAthleteNo.Location = new System.Drawing.Point(76, 18);
            this.txtAddAthleteNo.Name = "txtAddAthleteNo";
            this.txtAddAthleteNo.Size = new System.Drawing.Size(39, 20);
            this.txtAddAthleteNo.TabIndex = 24;
            // 
            // btnAddResult
            // 
            this.btnAddResult.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddResult.Location = new System.Drawing.Point(76, 129);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(75, 23);
            this.btnAddResult.TabIndex = 4;
            this.btnAddResult.Text = "Save";
            this.btnAddResult.UseVisualStyleBackColor = false;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Result";
            // 
            // lblMedal
            // 
            this.lblMedal.AutoSize = true;
            this.lblMedal.BackColor = System.Drawing.Color.White;
            this.lblMedal.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedal.ForeColor = System.Drawing.Color.Black;
            this.lblMedal.Location = new System.Drawing.Point(9, 106);
            this.lblMedal.Name = "lblMedal";
            this.lblMedal.Size = new System.Drawing.Size(39, 14);
            this.lblMedal.TabIndex = 15;
            this.lblMedal.Text = "Medal";
            // 
            // cmbAddMedal
            // 
            this.cmbAddMedal.FormattingEnabled = true;
            this.cmbAddMedal.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Bronze",
            "None"});
            this.cmbAddMedal.Location = new System.Drawing.Point(76, 103);
            this.cmbAddMedal.Name = "cmbAddMedal";
            this.cmbAddMedal.Size = new System.Drawing.Size(92, 22);
            this.cmbAddMedal.TabIndex = 23;
            // 
            // txtAddPosition
            // 
            this.txtAddPosition.Location = new System.Drawing.Point(76, 44);
            this.txtAddPosition.Name = "txtAddPosition";
            this.txtAddPosition.Size = new System.Drawing.Size(39, 20);
            this.txtAddPosition.TabIndex = 21;
            // 
            // txtAddResult
            // 
            this.txtAddResult.Location = new System.Drawing.Point(76, 73);
            this.txtAddResult.Name = "txtAddResult";
            this.txtAddResult.Size = new System.Drawing.Size(70, 20);
            this.txtAddResult.TabIndex = 22;
            // 
            // dgvMedalist
            // 
            this.dgvMedalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedalist.Location = new System.Drawing.Point(234, 29);
            this.dgvMedalist.Name = "dgvMedalist";
            this.dgvMedalist.Size = new System.Drawing.Size(304, 147);
            this.dgvMedalist.TabIndex = 17;
            this.dgvMedalist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedalist_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(237, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add/Change/Delete Medals";
            // 
            // pnlViewMedalWinners
            // 
            this.pnlViewMedalWinners.BackColor = System.Drawing.Color.White;
            this.pnlViewMedalWinners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlViewMedalWinners.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlViewMedalWinners.Controls.Add(this.lstViewWinners);
            this.pnlViewMedalWinners.Controls.Add(this.label5);
            this.pnlViewMedalWinners.Controls.Add(this.label6);
            this.pnlViewMedalWinners.Controls.Add(this.cmbViewEvents);
            this.pnlViewMedalWinners.Controls.Add(this.cmbViewDiscipline);
            this.pnlViewMedalWinners.Controls.Add(this.cmbViewYear);
            this.pnlViewMedalWinners.Controls.Add(this.label7);
            this.pnlViewMedalWinners.Controls.Add(this.btnViewEventWinners);
            this.pnlViewMedalWinners.Controls.Add(this.label8);
            this.pnlViewMedalWinners.Location = new System.Drawing.Point(37, 31);
            this.pnlViewMedalWinners.Name = "pnlViewMedalWinners";
            this.pnlViewMedalWinners.Size = new System.Drawing.Size(482, 275);
            this.pnlViewMedalWinners.TabIndex = 4;
            this.pnlViewMedalWinners.Visible = false;
            // 
            // lstViewWinners
            // 
            this.lstViewWinners.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.lstViewWinners.FormattingEnabled = true;
            this.lstViewWinners.ItemHeight = 11;
            this.lstViewWinners.Location = new System.Drawing.Point(181, 48);
            this.lstViewWinners.Name = "lstViewWinners";
            this.lstViewWinners.Size = new System.Drawing.Size(281, 191);
            this.lstViewWinners.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Events";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(41, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Disciplines";
            // 
            // cmbViewEvents
            // 
            this.cmbViewEvents.Enabled = false;
            this.cmbViewEvents.FormattingEnabled = true;
            this.cmbViewEvents.Location = new System.Drawing.Point(22, 126);
            this.cmbViewEvents.Name = "cmbViewEvents";
            this.cmbViewEvents.Size = new System.Drawing.Size(121, 21);
            this.cmbViewEvents.TabIndex = 10;
            // 
            // cmbViewDiscipline
            // 
            this.cmbViewDiscipline.Enabled = false;
            this.cmbViewDiscipline.FormattingEnabled = true;
            this.cmbViewDiscipline.Location = new System.Drawing.Point(22, 85);
            this.cmbViewDiscipline.Name = "cmbViewDiscipline";
            this.cmbViewDiscipline.Size = new System.Drawing.Size(121, 21);
            this.cmbViewDiscipline.TabIndex = 9;
            this.cmbViewDiscipline.SelectionChangeCommitted += new System.EventHandler(this.cmbViewDiscipline_SelectionChangeCommitted);
            // 
            // cmbViewYear
            // 
            this.cmbViewYear.FormattingEnabled = true;
            this.cmbViewYear.Location = new System.Drawing.Point(22, 45);
            this.cmbViewYear.Name = "cmbViewYear";
            this.cmbViewYear.Size = new System.Drawing.Size(121, 21);
            this.cmbViewYear.TabIndex = 8;
            this.cmbViewYear.SelectionChangeCommitted += new System.EventHandler(this.cmbViewYear_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "View Medal Winners";
            // 
            // btnViewEventWinners
            // 
            this.btnViewEventWinners.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewEventWinners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEventWinners.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEventWinners.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewEventWinners.Location = new System.Drawing.Point(22, 228);
            this.btnViewEventWinners.Name = "btnViewEventWinners";
            this.btnViewEventWinners.Size = new System.Drawing.Size(75, 23);
            this.btnViewEventWinners.TabIndex = 4;
            this.btnViewEventWinners.Text = "View";
            this.btnViewEventWinners.UseVisualStyleBackColor = false;
            this.btnViewEventWinners.Click += new System.EventHandler(this.btnViewEventWinners_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(41, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Games";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlLeft.Controls.Add(this.btnViewMedalWinners);
            this.pnlLeft.Controls.Add(this.btnAddMedal);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(167, 355);
            this.pnlLeft.TabIndex = 7;
            // 
            // btnViewMedalWinners
            // 
            this.btnViewMedalWinners.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewMedalWinners.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnViewMedalWinners.FlatAppearance.BorderSize = 0;
            this.btnViewMedalWinners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMedalWinners.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedalWinners.ForeColor = System.Drawing.Color.White;
            this.btnViewMedalWinners.Location = new System.Drawing.Point(0, 65);
            this.btnViewMedalWinners.Name = "btnViewMedalWinners";
            this.btnViewMedalWinners.Size = new System.Drawing.Size(167, 28);
            this.btnViewMedalWinners.TabIndex = 3;
            this.btnViewMedalWinners.Text = "View Results";
            this.btnViewMedalWinners.UseVisualStyleBackColor = false;
            this.btnViewMedalWinners.Click += new System.EventHandler(this.btnViewMedalWinners_Click);
            // 
            // btnAddMedal
            // 
            this.btnAddMedal.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddMedal.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAddMedal.FlatAppearance.BorderSize = 0;
            this.btnAddMedal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedal.ForeColor = System.Drawing.Color.White;
            this.btnAddMedal.Location = new System.Drawing.Point(0, 30);
            this.btnAddMedal.Name = "btnAddMedal";
            this.btnAddMedal.Size = new System.Drawing.Size(167, 28);
            this.btnAddMedal.TabIndex = 2;
            this.btnAddMedal.Text = "Medals";
            this.btnAddMedal.UseVisualStyleBackColor = false;
            this.btnAddMedal.Click += new System.EventHandler(this.btnAddMedals_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pbClose);
            this.pnlTop.Controls.Add(this.pbMini);
            this.pnlTop.Controls.Add(this.lblResults);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(725, 50);
            this.pnlTop.TabIndex = 6;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(12, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(49, 37);
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "OLYMPICS";
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClose.BackgroundImage")));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Location = new System.Drawing.Point(647, 21);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(22, 22);
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            // 
            // pbMini
            // 
            this.pbMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMini.BackgroundImage")));
            this.pbMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMini.Location = new System.Drawing.Point(616, 21);
            this.pbMini.Name = "pbMini";
            this.pbMini.Size = new System.Drawing.Size(22, 22);
            this.pbMini.TabIndex = 3;
            this.pbMini.TabStop = false;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(322, 13);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(70, 22);
            this.lblResults.TabIndex = 2;
            this.lblResults.Text = "Results";
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 405);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmResults";
            this.Text = "frmResults";
            this.pnlMain.ResumeLayout(false);
            this.pnlAddMedalsI.ResumeLayout(false);
            this.pnlAddMedalsI.PerformLayout();
            this.gbDelete.ResumeLayout(false);
            this.gbDelete.PerformLayout();
            this.gbEvents.ResumeLayout(false);
            this.gbEvents.PerformLayout();
            this.gbAthleteDetails.ResumeLayout(false);
            this.gbAthleteDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedalist)).EndInit();
            this.pnlViewMedalWinners.ResumeLayout(false);
            this.pnlViewMedalWinners.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlAddMedalsI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnAddMedal;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMini;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlViewMedalWinners;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbViewEvents;
        private System.Windows.Forms.ComboBox cmbViewDiscipline;
        private System.Windows.Forms.ComboBox cmbViewYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnViewEventWinners;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnViewMedalWinners;
        private System.Windows.Forms.ListBox lstViewWinners;
        private System.Windows.Forms.ComboBox cmbAddMedal;
        private System.Windows.Forms.TextBox txtAddResult;
        private System.Windows.Forms.TextBox txtAddPosition;
        private System.Windows.Forms.DataGridView dgvMedalist;
        private System.Windows.Forms.Label lblMedal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbAthleteDetails;
        private System.Windows.Forms.GroupBox gbEvents;
        private System.Windows.Forms.ComboBox cmbAddEvent;
        private System.Windows.Forms.ComboBox cmbAddDiscipline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnViewEvents;
        private System.Windows.Forms.ComboBox cmbAddOlympics;
        private System.Windows.Forms.TextBox txtAddAthleteNo;
        private System.Windows.Forms.ComboBox cmbAddCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label15;
    }
}