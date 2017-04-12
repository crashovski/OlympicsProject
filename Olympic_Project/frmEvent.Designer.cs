namespace Olympic_Project
{
    partial class frmEvent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvent));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlViewEvents = new System.Windows.Forms.Panel();
            this.btnShowDates = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewEvinDiscipline = new System.Windows.Forms.Button();
            this.cmbViewEventsDiscipine = new System.Windows.Forms.ComboBox();
            this.btnViewRegisteredEv = new System.Windows.Forms.Button();
            this.btnViewAllEvents = new System.Windows.Forms.Button();
            this.dgvViewEvent = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlUpdateEvent = new System.Windows.Forms.Panel();
            this.txtUpWR = new System.Windows.Forms.TextBox();
            this.txtUpOR = new System.Windows.Forms.TextBox();
            this.txtUpName = new System.Windows.Forms.TextBox();
            this.txtUpNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvUpdateEvent = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlDeleteEvent = new System.Windows.Forms.Panel();
            this.lstCurrentEvents = new System.Windows.Forms.ListBox();
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlEventStatus = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlAddEvent = new System.Windows.Forms.Panel();
            this.gbEventTypr = new System.Windows.Forms.GroupBox();
            this.rbIndividual = new System.Windows.Forms.RadioButton();
            this.rbTeam = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtAddWR = new System.Windows.Forms.TextBox();
            this.lblWRAdd = new System.Windows.Forms.Label();
            this.txtAddOR = new System.Windows.Forms.TextBox();
            this.lblORAdd = new System.Windows.Forms.Label();
            this.cmbDisciplineAdd = new System.Windows.Forms.ComboBox();
            this.lblDisciplineAdd = new System.Windows.Forms.Label();
            this.txtAddEventName = new System.Windows.Forms.TextBox();
            this.lblEventNameAdd = new System.Windows.Forms.Label();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.lblAddHeading = new System.Windows.Forms.Label();
            this.pnlRegisterEvent = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEventTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEventDate = new System.Windows.Forms.DateTimePicker();
            this.cmbRegEvent = new System.Windows.Forms.ComboBox();
            this.txtRegYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRegDiscipline = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegisterEvent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnRegisterEvents = new System.Windows.Forms.Button();
            this.btnViewEvents = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMini = new System.Windows.Forms.PictureBox();
            this.lblAthlete = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlViewEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEvent)).BeginInit();
            this.pnlUpdateEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateEvent)).BeginInit();
            this.pnlDeleteEvent.SuspendLayout();
            this.pnlEventStatus.SuspendLayout();
            this.pnlAddEvent.SuspendLayout();
            this.gbEventTypr.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.pnlRegisterEvent.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.pnlUpdateEvent);
            this.pnlMain.Controls.Add(this.pnlViewEvents);
            this.pnlMain.Controls.Add(this.pnlDeleteEvent);
            this.pnlMain.Controls.Add(this.pnlEventStatus);
            this.pnlMain.Controls.Add(this.pnlAddEvent);
            this.pnlMain.Controls.Add(this.pnlRegisterEvent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(167, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(512, 331);
            this.pnlMain.TabIndex = 11;
            // 
            // pnlViewEvents
            // 
            this.pnlViewEvents.BackColor = System.Drawing.Color.White;
            this.pnlViewEvents.Controls.Add(this.btnShowDates);
            this.pnlViewEvents.Controls.Add(this.label17);
            this.pnlViewEvents.Controls.Add(this.dtpEndDate);
            this.pnlViewEvents.Controls.Add(this.label16);
            this.pnlViewEvents.Controls.Add(this.dtpStartDate);
            this.pnlViewEvents.Controls.Add(this.btnViewEvinDiscipline);
            this.pnlViewEvents.Controls.Add(this.cmbViewEventsDiscipine);
            this.pnlViewEvents.Controls.Add(this.btnViewRegisteredEv);
            this.pnlViewEvents.Controls.Add(this.btnViewAllEvents);
            this.pnlViewEvents.Controls.Add(this.dgvViewEvent);
            this.pnlViewEvents.Controls.Add(this.label7);
            this.pnlViewEvents.Location = new System.Drawing.Point(23, 24);
            this.pnlViewEvents.Name = "pnlViewEvents";
            this.pnlViewEvents.Size = new System.Drawing.Size(477, 295);
            this.pnlViewEvents.TabIndex = 12;
            this.pnlViewEvents.Visible = false;
            // 
            // btnShowDates
            // 
            this.btnShowDates.BackColor = System.Drawing.Color.LimeGreen;
            this.btnShowDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDates.ForeColor = System.Drawing.Color.White;
            this.btnShowDates.Location = new System.Drawing.Point(340, 89);
            this.btnShowDates.Name = "btnShowDates";
            this.btnShowDates.Size = new System.Drawing.Size(75, 23);
            this.btnShowDates.TabIndex = 25;
            this.btnShowDates.Text = "All Events";
            this.btnShowDates.UseVisualStyleBackColor = false;
            this.btnShowDates.Click += new System.EventHandler(this.btnShowDates_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(266, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(340, 63);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(131, 20);
            this.dtpEndDate.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(266, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(340, 35);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(131, 20);
            this.dtpStartDate.TabIndex = 21;
            // 
            // btnViewEvinDiscipline
            // 
            this.btnViewEvinDiscipline.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewEvinDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEvinDiscipline.ForeColor = System.Drawing.Color.White;
            this.btnViewEvinDiscipline.Location = new System.Drawing.Point(146, 38);
            this.btnViewEvinDiscipline.Name = "btnViewEvinDiscipline";
            this.btnViewEvinDiscipline.Size = new System.Drawing.Size(110, 23);
            this.btnViewEvinDiscipline.TabIndex = 20;
            this.btnViewEvinDiscipline.Text = "Events in Discipline";
            this.btnViewEvinDiscipline.UseVisualStyleBackColor = false;
            this.btnViewEvinDiscipline.Click += new System.EventHandler(this.btnViewEvinDiscipline_Click);
            // 
            // cmbViewEventsDiscipine
            // 
            this.cmbViewEventsDiscipine.FormattingEnabled = true;
            this.cmbViewEventsDiscipine.Location = new System.Drawing.Point(14, 39);
            this.cmbViewEventsDiscipine.Name = "cmbViewEventsDiscipine";
            this.cmbViewEventsDiscipine.Size = new System.Drawing.Size(121, 21);
            this.cmbViewEventsDiscipine.TabIndex = 19;
            // 
            // btnViewRegisteredEv
            // 
            this.btnViewRegisteredEv.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewRegisteredEv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRegisteredEv.ForeColor = System.Drawing.Color.White;
            this.btnViewRegisteredEv.Location = new System.Drawing.Point(112, 75);
            this.btnViewRegisteredEv.Name = "btnViewRegisteredEv";
            this.btnViewRegisteredEv.Size = new System.Drawing.Size(112, 23);
            this.btnViewRegisteredEv.TabIndex = 18;
            this.btnViewRegisteredEv.Text = "Registered Events";
            this.btnViewRegisteredEv.UseVisualStyleBackColor = false;
            this.btnViewRegisteredEv.Click += new System.EventHandler(this.btnViewRegisteredEv_Click);
            // 
            // btnViewAllEvents
            // 
            this.btnViewAllEvents.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewAllEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllEvents.ForeColor = System.Drawing.Color.White;
            this.btnViewAllEvents.Location = new System.Drawing.Point(18, 75);
            this.btnViewAllEvents.Name = "btnViewAllEvents";
            this.btnViewAllEvents.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllEvents.TabIndex = 17;
            this.btnViewAllEvents.Text = "All Events";
            this.btnViewAllEvents.UseVisualStyleBackColor = false;
            this.btnViewAllEvents.Click += new System.EventHandler(this.btnViewAllEvents_Click);
            // 
            // dgvViewEvent
            // 
            this.dgvViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewEvent.Location = new System.Drawing.Point(18, 121);
            this.dgvViewEvent.Name = "dgvViewEvent";
            this.dgvViewEvent.Size = new System.Drawing.Size(440, 160);
            this.dgvViewEvent.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "View Events";
            // 
            // pnlUpdateEvent
            // 
            this.pnlUpdateEvent.AutoSize = true;
            this.pnlUpdateEvent.BackColor = System.Drawing.Color.White;
            this.pnlUpdateEvent.Controls.Add(this.txtUpWR);
            this.pnlUpdateEvent.Controls.Add(this.txtUpOR);
            this.pnlUpdateEvent.Controls.Add(this.txtUpName);
            this.pnlUpdateEvent.Controls.Add(this.txtUpNo);
            this.pnlUpdateEvent.Controls.Add(this.label15);
            this.pnlUpdateEvent.Controls.Add(this.label14);
            this.pnlUpdateEvent.Controls.Add(this.label12);
            this.pnlUpdateEvent.Controls.Add(this.label11);
            this.pnlUpdateEvent.Controls.Add(this.dgvUpdateEvent);
            this.pnlUpdateEvent.Controls.Add(this.btnUpdate);
            this.pnlUpdateEvent.Controls.Add(this.label10);
            this.pnlUpdateEvent.Location = new System.Drawing.Point(22, 18);
            this.pnlUpdateEvent.Name = "pnlUpdateEvent";
            this.pnlUpdateEvent.Size = new System.Drawing.Size(477, 297);
            this.pnlUpdateEvent.TabIndex = 16;
            this.pnlUpdateEvent.Visible = false;
            // 
            // txtUpWR
            // 
            this.txtUpWR.Location = new System.Drawing.Point(97, 259);
            this.txtUpWR.Name = "txtUpWR";
            this.txtUpWR.Size = new System.Drawing.Size(56, 20);
            this.txtUpWR.TabIndex = 29;
            // 
            // txtUpOR
            // 
            this.txtUpOR.Location = new System.Drawing.Point(97, 229);
            this.txtUpOR.Name = "txtUpOR";
            this.txtUpOR.Size = new System.Drawing.Size(56, 20);
            this.txtUpOR.TabIndex = 28;
            // 
            // txtUpName
            // 
            this.txtUpName.Enabled = false;
            this.txtUpName.Location = new System.Drawing.Point(97, 198);
            this.txtUpName.Name = "txtUpName";
            this.txtUpName.Size = new System.Drawing.Size(100, 20);
            this.txtUpName.TabIndex = 27;
            // 
            // txtUpNo
            // 
            this.txtUpNo.Enabled = false;
            this.txtUpNo.Location = new System.Drawing.Point(97, 168);
            this.txtUpNo.Name = "txtUpNo";
            this.txtUpNo.Size = new System.Drawing.Size(49, 20);
            this.txtUpNo.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "World Record";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Olympic Record";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Name of Event";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Event No";
            // 
            // dgvUpdateEvent
            // 
            this.dgvUpdateEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateEvent.Location = new System.Drawing.Point(15, 36);
            this.dgvUpdateEvent.Name = "dgvUpdateEvent";
            this.dgvUpdateEvent.Size = new System.Drawing.Size(422, 117);
            this.dgvUpdateEvent.TabIndex = 18;
            this.dgvUpdateEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateEvent_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(362, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(159, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Update Event";
            // 
            // pnlDeleteEvent
            // 
            this.pnlDeleteEvent.BackColor = System.Drawing.Color.White;
            this.pnlDeleteEvent.Controls.Add(this.lstCurrentEvents);
            this.pnlDeleteEvent.Controls.Add(this.btnEventDelete);
            this.pnlDeleteEvent.Controls.Add(this.label9);
            this.pnlDeleteEvent.Location = new System.Drawing.Point(24, 22);
            this.pnlDeleteEvent.Name = "pnlDeleteEvent";
            this.pnlDeleteEvent.Size = new System.Drawing.Size(477, 271);
            this.pnlDeleteEvent.TabIndex = 15;
            this.pnlDeleteEvent.Visible = false;
            // 
            // lstCurrentEvents
            // 
            this.lstCurrentEvents.BackColor = System.Drawing.Color.White;
            this.lstCurrentEvents.FormattingEnabled = true;
            this.lstCurrentEvents.Location = new System.Drawing.Point(90, 41);
            this.lstCurrentEvents.Name = "lstCurrentEvents";
            this.lstCurrentEvents.Size = new System.Drawing.Size(154, 199);
            this.lstCurrentEvents.TabIndex = 18;
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEventDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventDelete.ForeColor = System.Drawing.Color.White;
            this.btnEventDelete.Location = new System.Drawing.Point(280, 41);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(75, 23);
            this.btnEventDelete.TabIndex = 17;
            this.btnEventDelete.Text = "Delete";
            this.btnEventDelete.UseVisualStyleBackColor = false;
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Delete an Event";
            // 
            // pnlEventStatus
            // 
            this.pnlEventStatus.BackColor = System.Drawing.Color.White;
            this.pnlEventStatus.Controls.Add(this.label13);
            this.pnlEventStatus.Location = new System.Drawing.Point(24, 22);
            this.pnlEventStatus.Name = "pnlEventStatus";
            this.pnlEventStatus.Size = new System.Drawing.Size(477, 271);
            this.pnlEventStatus.TabIndex = 14;
            this.pnlEventStatus.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(119, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Delete or Activate an Event";
            // 
            // pnlAddEvent
            // 
            this.pnlAddEvent.BackColor = System.Drawing.Color.White;
            this.pnlAddEvent.Controls.Add(this.gbEventTypr);
            this.pnlAddEvent.Controls.Add(this.gbGender);
            this.pnlAddEvent.Controls.Add(this.txtAddWR);
            this.pnlAddEvent.Controls.Add(this.lblWRAdd);
            this.pnlAddEvent.Controls.Add(this.txtAddOR);
            this.pnlAddEvent.Controls.Add(this.lblORAdd);
            this.pnlAddEvent.Controls.Add(this.cmbDisciplineAdd);
            this.pnlAddEvent.Controls.Add(this.lblDisciplineAdd);
            this.pnlAddEvent.Controls.Add(this.txtAddEventName);
            this.pnlAddEvent.Controls.Add(this.lblEventNameAdd);
            this.pnlAddEvent.Controls.Add(this.btnSaveEvent);
            this.pnlAddEvent.Controls.Add(this.lblAddHeading);
            this.pnlAddEvent.Location = new System.Drawing.Point(24, 22);
            this.pnlAddEvent.Name = "pnlAddEvent";
            this.pnlAddEvent.Size = new System.Drawing.Size(477, 271);
            this.pnlAddEvent.TabIndex = 11;
            this.pnlAddEvent.Visible = false;
            // 
            // gbEventTypr
            // 
            this.gbEventTypr.Controls.Add(this.rbIndividual);
            this.gbEventTypr.Controls.Add(this.rbTeam);
            this.gbEventTypr.Location = new System.Drawing.Point(280, 116);
            this.gbEventTypr.Name = "gbEventTypr";
            this.gbEventTypr.Size = new System.Drawing.Size(138, 61);
            this.gbEventTypr.TabIndex = 26;
            this.gbEventTypr.TabStop = false;
            this.gbEventTypr.Text = "Event Type";
            // 
            // rbIndividual
            // 
            this.rbIndividual.AutoSize = true;
            this.rbIndividual.Location = new System.Drawing.Point(61, 27);
            this.rbIndividual.Name = "rbIndividual";
            this.rbIndividual.Size = new System.Drawing.Size(70, 17);
            this.rbIndividual.TabIndex = 1;
            this.rbIndividual.TabStop = true;
            this.rbIndividual.Text = "Individual";
            this.rbIndividual.UseVisualStyleBackColor = true;
            // 
            // rbTeam
            // 
            this.rbTeam.AutoSize = true;
            this.rbTeam.Location = new System.Drawing.Point(7, 27);
            this.rbTeam.Name = "rbTeam";
            this.rbTeam.Size = new System.Drawing.Size(52, 17);
            this.rbTeam.TabIndex = 0;
            this.rbTeam.TabStop = true;
            this.rbTeam.Text = "Team";
            this.rbTeam.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(280, 36);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(138, 61);
            this.gbGender.TabIndex = 25;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(61, 27);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(7, 27);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtAddWR
            // 
            this.txtAddWR.Location = new System.Drawing.Point(103, 164);
            this.txtAddWR.Name = "txtAddWR";
            this.txtAddWR.Size = new System.Drawing.Size(65, 20);
            this.txtAddWR.TabIndex = 24;
            // 
            // lblWRAdd
            // 
            this.lblWRAdd.AutoSize = true;
            this.lblWRAdd.Location = new System.Drawing.Point(48, 160);
            this.lblWRAdd.Name = "lblWRAdd";
            this.lblWRAdd.Size = new System.Drawing.Size(42, 26);
            this.lblWRAdd.TabIndex = 23;
            this.lblWRAdd.Text = "World\r\nRecord";
            // 
            // txtAddOR
            // 
            this.txtAddOR.Location = new System.Drawing.Point(103, 125);
            this.txtAddOR.Name = "txtAddOR";
            this.txtAddOR.Size = new System.Drawing.Size(65, 20);
            this.txtAddOR.TabIndex = 22;
            // 
            // lblORAdd
            // 
            this.lblORAdd.AutoSize = true;
            this.lblORAdd.Location = new System.Drawing.Point(46, 121);
            this.lblORAdd.Name = "lblORAdd";
            this.lblORAdd.Size = new System.Drawing.Size(44, 26);
            this.lblORAdd.TabIndex = 21;
            this.lblORAdd.Text = "Olympic\r\nRecord";
            // 
            // cmbDisciplineAdd
            // 
            this.cmbDisciplineAdd.FormattingEnabled = true;
            this.cmbDisciplineAdd.Location = new System.Drawing.Point(103, 45);
            this.cmbDisciplineAdd.Name = "cmbDisciplineAdd";
            this.cmbDisciplineAdd.Size = new System.Drawing.Size(121, 21);
            this.cmbDisciplineAdd.TabIndex = 20;
            // 
            // lblDisciplineAdd
            // 
            this.lblDisciplineAdd.AutoSize = true;
            this.lblDisciplineAdd.Location = new System.Drawing.Point(38, 45);
            this.lblDisciplineAdd.Name = "lblDisciplineAdd";
            this.lblDisciplineAdd.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplineAdd.TabIndex = 19;
            this.lblDisciplineAdd.Text = "Discipline";
            // 
            // txtAddEventName
            // 
            this.txtAddEventName.Location = new System.Drawing.Point(103, 85);
            this.txtAddEventName.Name = "txtAddEventName";
            this.txtAddEventName.Size = new System.Drawing.Size(100, 20);
            this.txtAddEventName.TabIndex = 18;
            // 
            // lblEventNameAdd
            // 
            this.lblEventNameAdd.AutoSize = true;
            this.lblEventNameAdd.Location = new System.Drawing.Point(24, 88);
            this.lblEventNameAdd.Name = "lblEventNameAdd";
            this.lblEventNameAdd.Size = new System.Drawing.Size(66, 13);
            this.lblEventNameAdd.TabIndex = 17;
            this.lblEventNameAdd.Text = "Event Name";
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEvent.ForeColor = System.Drawing.Color.White;
            this.btnSaveEvent.Location = new System.Drawing.Point(149, 217);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEvent.TabIndex = 16;
            this.btnSaveEvent.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSaveEvent, "Remember to register event after creating");
            this.btnSaveEvent.UseVisualStyleBackColor = false;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // lblAddHeading
            // 
            this.lblAddHeading.AutoSize = true;
            this.lblAddHeading.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddHeading.Location = new System.Drawing.Point(159, 8);
            this.lblAddHeading.Name = "lblAddHeading";
            this.lblAddHeading.Size = new System.Drawing.Size(96, 17);
            this.lblAddHeading.TabIndex = 1;
            this.lblAddHeading.Text = "Add an Event";
            // 
            // pnlRegisterEvent
            // 
            this.pnlRegisterEvent.BackColor = System.Drawing.Color.White;
            this.pnlRegisterEvent.Controls.Add(this.label5);
            this.pnlRegisterEvent.Controls.Add(this.txtEventTime);
            this.pnlRegisterEvent.Controls.Add(this.label3);
            this.pnlRegisterEvent.Controls.Add(this.dtEventDate);
            this.pnlRegisterEvent.Controls.Add(this.cmbRegEvent);
            this.pnlRegisterEvent.Controls.Add(this.txtRegYear);
            this.pnlRegisterEvent.Controls.Add(this.label2);
            this.pnlRegisterEvent.Controls.Add(this.cmbRegDiscipline);
            this.pnlRegisterEvent.Controls.Add(this.label4);
            this.pnlRegisterEvent.Controls.Add(this.btnRegisterEvent);
            this.pnlRegisterEvent.Controls.Add(this.label6);
            this.pnlRegisterEvent.Controls.Add(this.label8);
            this.pnlRegisterEvent.Location = new System.Drawing.Point(24, 22);
            this.pnlRegisterEvent.Name = "pnlRegisterEvent";
            this.pnlRegisterEvent.Size = new System.Drawing.Size(477, 271);
            this.pnlRegisterEvent.TabIndex = 13;
            this.pnlRegisterEvent.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Time";
            // 
            // txtEventTime
            // 
            this.txtEventTime.Location = new System.Drawing.Point(154, 164);
            this.txtEventTime.MaxLength = 5;
            this.txtEventTime.Name = "txtEventTime";
            this.txtEventTime.Size = new System.Drawing.Size(41, 20);
            this.txtEventTime.TabIndex = 28;
            this.txtEventTime.Text = "12:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date ";
            // 
            // dtEventDate
            // 
            this.dtEventDate.CustomFormat = "dd MM yyyy";
            this.dtEventDate.Location = new System.Drawing.Point(154, 134);
            this.dtEventDate.Name = "dtEventDate";
            this.dtEventDate.Size = new System.Drawing.Size(178, 20);
            this.dtEventDate.TabIndex = 26;
            this.dtEventDate.Value = new System.DateTime(2016, 9, 7, 0, 0, 0, 0);
            // 
            // cmbRegEvent
            // 
            this.cmbRegEvent.FormattingEnabled = true;
            this.cmbRegEvent.Location = new System.Drawing.Point(154, 72);
            this.cmbRegEvent.Name = "cmbRegEvent";
            this.cmbRegEvent.Size = new System.Drawing.Size(121, 21);
            this.cmbRegEvent.TabIndex = 25;
            // 
            // txtRegYear
            // 
            this.txtRegYear.Location = new System.Drawing.Point(154, 102);
            this.txtRegYear.MaxLength = 4;
            this.txtRegYear.Name = "txtRegYear";
            this.txtRegYear.Size = new System.Drawing.Size(41, 20);
            this.txtRegYear.TabIndex = 24;
            this.txtRegYear.Text = "2016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Year";
            // 
            // cmbRegDiscipline
            // 
            this.cmbRegDiscipline.FormattingEnabled = true;
            this.cmbRegDiscipline.Location = new System.Drawing.Point(154, 41);
            this.cmbRegDiscipline.Name = "cmbRegDiscipline";
            this.cmbRegDiscipline.Size = new System.Drawing.Size(121, 21);
            this.cmbRegDiscipline.TabIndex = 20;
            this.cmbRegDiscipline.SelectedIndexChanged += new System.EventHandler(this.cmbRegDiscipline_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Discipline";
            // 
            // btnRegisterEvent
            // 
            this.btnRegisterEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegisterEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterEvent.ForeColor = System.Drawing.Color.White;
            this.btnRegisterEvent.Location = new System.Drawing.Point(149, 217);
            this.btnRegisterEvent.Name = "btnRegisterEvent";
            this.btnRegisterEvent.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterEvent.TabIndex = 16;
            this.btnRegisterEvent.Text = "Save";
            this.btnRegisterEvent.UseVisualStyleBackColor = false;
            this.btnRegisterEvent.Click += new System.EventHandler(this.btnRegisterEvent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Event No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(159, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Register Event";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlLeft.Controls.Add(this.btnUpdateEvent);
            this.pnlLeft.Controls.Add(this.btnDeleteEvent);
            this.pnlLeft.Controls.Add(this.btnRegisterEvents);
            this.pnlLeft.Controls.Add(this.btnViewEvents);
            this.pnlLeft.Controls.Add(this.btnAddEvent);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(167, 331);
            this.pnlLeft.TabIndex = 10;
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateEvent.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateEvent.FlatAppearance.BorderSize = 0;
            this.btnUpdateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEvent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEvent.Location = new System.Drawing.Point(0, 174);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(167, 28);
            this.btnUpdateEvent.TabIndex = 6;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDeleteEvent.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteEvent.FlatAppearance.BorderSize = 0;
            this.btnDeleteEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEvent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEvent.Location = new System.Drawing.Point(0, 135);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(167, 28);
            this.btnDeleteEvent.TabIndex = 5;
            this.btnDeleteEvent.Text = "Delete Events";
            this.btnDeleteEvent.UseVisualStyleBackColor = false;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnRegisterEvents
            // 
            this.btnRegisterEvents.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegisterEvents.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnRegisterEvents.FlatAppearance.BorderSize = 0;
            this.btnRegisterEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterEvents.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterEvents.ForeColor = System.Drawing.Color.White;
            this.btnRegisterEvents.Location = new System.Drawing.Point(0, 96);
            this.btnRegisterEvents.Name = "btnRegisterEvents";
            this.btnRegisterEvents.Size = new System.Drawing.Size(167, 28);
            this.btnRegisterEvents.TabIndex = 4;
            this.btnRegisterEvents.Text = "Register Events";
            this.btnRegisterEvents.UseVisualStyleBackColor = false;
            this.btnRegisterEvents.Click += new System.EventHandler(this.btnRegisterEvents_Click);
            // 
            // btnViewEvents
            // 
            this.btnViewEvents.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewEvents.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnViewEvents.FlatAppearance.BorderSize = 0;
            this.btnViewEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEvents.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEvents.ForeColor = System.Drawing.Color.White;
            this.btnViewEvents.Location = new System.Drawing.Point(0, 58);
            this.btnViewEvents.Name = "btnViewEvents";
            this.btnViewEvents.Size = new System.Drawing.Size(167, 28);
            this.btnViewEvents.TabIndex = 3;
            this.btnViewEvents.Text = "View Events";
            this.btnViewEvents.UseVisualStyleBackColor = false;
            this.btnViewEvents.Click += new System.EventHandler(this.btnViewEvents_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddEvent.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAddEvent.FlatAppearance.BorderSize = 0;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.ForeColor = System.Drawing.Color.White;
            this.btnAddEvent.Location = new System.Drawing.Point(0, 19);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(167, 28);
            this.btnAddEvent.TabIndex = 2;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pbClose);
            this.pnlTop.Controls.Add(this.pbMini);
            this.pnlTop.Controls.Add(this.lblAthlete);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(679, 50);
            this.pnlTop.TabIndex = 9;
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
            // lblAthlete
            // 
            this.lblAthlete.AutoSize = true;
            this.lblAthlete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAthlete.Location = new System.Drawing.Point(322, 13);
            this.lblAthlete.Name = "lblAthlete";
            this.lblAthlete.Size = new System.Drawing.Size(71, 22);
            this.lblAthlete.TabIndex = 2;
            this.lblAthlete.Text = "Events";
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 381);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmEvent";
            this.Text = "frmEvent";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlViewEvents.ResumeLayout(false);
            this.pnlViewEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEvent)).EndInit();
            this.pnlUpdateEvent.ResumeLayout(false);
            this.pnlUpdateEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateEvent)).EndInit();
            this.pnlDeleteEvent.ResumeLayout(false);
            this.pnlDeleteEvent.PerformLayout();
            this.pnlEventStatus.ResumeLayout(false);
            this.pnlEventStatus.PerformLayout();
            this.pnlAddEvent.ResumeLayout(false);
            this.pnlAddEvent.PerformLayout();
            this.gbEventTypr.ResumeLayout(false);
            this.gbEventTypr.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.pnlRegisterEvent.ResumeLayout(false);
            this.pnlRegisterEvent.PerformLayout();
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
        private System.Windows.Forms.Panel pnlAddEvent;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.Label lblAddHeading;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnRegisterEvents;
        private System.Windows.Forms.Button btnViewEvents;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMini;
        private System.Windows.Forms.Label lblAthlete;
        private System.Windows.Forms.GroupBox gbEventTypr;
        private System.Windows.Forms.RadioButton rbIndividual;
        private System.Windows.Forms.RadioButton rbTeam;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtAddWR;
        private System.Windows.Forms.Label lblWRAdd;
        private System.Windows.Forms.TextBox txtAddOR;
        private System.Windows.Forms.Label lblORAdd;
        private System.Windows.Forms.ComboBox cmbDisciplineAdd;
        private System.Windows.Forms.Label lblDisciplineAdd;
        private System.Windows.Forms.TextBox txtAddEventName;
        private System.Windows.Forms.Label lblEventNameAdd;
        private System.Windows.Forms.Panel pnlViewEvents;
        private System.Windows.Forms.DataGridView dgvViewEvent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlRegisterEvent;
        private System.Windows.Forms.DateTimePicker dtEventDate;
        private System.Windows.Forms.ComboBox cmbRegEvent;
        private System.Windows.Forms.TextBox txtRegYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRegDiscipline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegisterEvent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEventTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlEventStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnViewRegisteredEv;
        private System.Windows.Forms.Button btnViewAllEvents;
        private System.Windows.Forms.Button btnViewEvinDiscipline;
        private System.Windows.Forms.ComboBox cmbViewEventsDiscipine;
        private System.Windows.Forms.Panel pnlDeleteEvent;
        private System.Windows.Forms.Button btnEventDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstCurrentEvents;
        private System.Windows.Forms.Panel pnlUpdateEvent;
        private System.Windows.Forms.TextBox txtUpWR;
        private System.Windows.Forms.TextBox txtUpOR;
        private System.Windows.Forms.TextBox txtUpName;
        private System.Windows.Forms.TextBox txtUpNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvUpdateEvent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnShowDates;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}