namespace Olympic_Project
{
    partial class frmOlympics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOlympics));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlChangeOlympics = new System.Windows.Forms.Panel();
            this.txtChangeCity = new System.Windows.Forms.TextBox();
            this.cmbChangeYear = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdateOlympics = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlOlympicDetails = new System.Windows.Forms.Panel();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDetYear = new System.Windows.Forms.ComboBox();
            this.lstOlympicDetails = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlDeleteOlympics = new System.Windows.Forms.Panel();
            this.cmbDeleteYear = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDeleteOlympic = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlAddOlympic = new System.Windows.Forms.Panel();
            this.txtAddYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dteAddEnd = new System.Windows.Forms.DateTimePicker();
            this.dteAddStart = new System.Windows.Forms.DateTimePicker();
            this.txtAddCity = new System.Windows.Forms.TextBox();
            this.cmbAddCountry = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddOlympics = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnOlympicDetails = new System.Windows.Forms.Button();
            this.btnOlympicDelete = new System.Windows.Forms.Button();
            this.btnChangeOlympics = new System.Windows.Forms.Button();
            this.btnAddOlympic = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMini = new System.Windows.Forms.PictureBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlChangeOlympics.SuspendLayout();
            this.pnlOlympicDetails.SuspendLayout();
            this.pnlDeleteOlympics.SuspendLayout();
            this.pnlAddOlympic.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.pnlAddOlympic);
            this.pnlMain.Controls.Add(this.pnlChangeOlympics);
            this.pnlMain.Controls.Add(this.pnlOlympicDetails);
            this.pnlMain.Controls.Add(this.pnlDeleteOlympics);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(167, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(520, 307);
            this.pnlMain.TabIndex = 8;
            // 
            // pnlChangeOlympics
            // 
            this.pnlChangeOlympics.BackColor = System.Drawing.Color.White;
            this.pnlChangeOlympics.Controls.Add(this.txtChangeCity);
            this.pnlChangeOlympics.Controls.Add(this.cmbChangeYear);
            this.pnlChangeOlympics.Controls.Add(this.label11);
            this.pnlChangeOlympics.Controls.Add(this.label12);
            this.pnlChangeOlympics.Controls.Add(this.btnUpdateOlympics);
            this.pnlChangeOlympics.Controls.Add(this.label13);
            this.pnlChangeOlympics.Location = new System.Drawing.Point(25, 22);
            this.pnlChangeOlympics.Name = "pnlChangeOlympics";
            this.pnlChangeOlympics.Size = new System.Drawing.Size(464, 268);
            this.pnlChangeOlympics.TabIndex = 9;
            this.pnlChangeOlympics.Visible = false;
            // 
            // txtChangeCity
            // 
            this.txtChangeCity.Location = new System.Drawing.Point(168, 93);
            this.txtChangeCity.Name = "txtChangeCity";
            this.txtChangeCity.Size = new System.Drawing.Size(100, 20);
            this.txtChangeCity.TabIndex = 18;
            // 
            // cmbChangeYear
            // 
            this.cmbChangeYear.FormattingEnabled = true;
            this.cmbChangeYear.Location = new System.Drawing.Point(168, 62);
            this.cmbChangeYear.Name = "cmbChangeYear";
            this.cmbChangeYear.Size = new System.Drawing.Size(121, 21);
            this.cmbChangeYear.TabIndex = 17;
            this.cmbChangeYear.SelectedIndexChanged += new System.EventHandler(this.cmbChangeYear_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "City Hosting";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Choose Year";
            // 
            // btnUpdateOlympics
            // 
            this.btnUpdateOlympics.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateOlympics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOlympics.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOlympics.ForeColor = System.Drawing.Color.White;
            this.btnUpdateOlympics.Location = new System.Drawing.Point(177, 178);
            this.btnUpdateOlympics.Name = "btnUpdateOlympics";
            this.btnUpdateOlympics.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateOlympics.TabIndex = 9;
            this.btnUpdateOlympics.Text = "update";
            this.btnUpdateOlympics.UseVisualStyleBackColor = false;
            this.btnUpdateOlympics.Click += new System.EventHandler(this.btnUpdateOlympics_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(135, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Change Olympic Details";
            // 
            // pnlOlympicDetails
            // 
            this.pnlOlympicDetails.BackColor = System.Drawing.Color.White;
            this.pnlOlympicDetails.Controls.Add(this.btnViewDetails);
            this.pnlOlympicDetails.Controls.Add(this.label4);
            this.pnlOlympicDetails.Controls.Add(this.cmbDetYear);
            this.pnlOlympicDetails.Controls.Add(this.lstOlympicDetails);
            this.pnlOlympicDetails.Controls.Add(this.label14);
            this.pnlOlympicDetails.Location = new System.Drawing.Point(25, 22);
            this.pnlOlympicDetails.Name = "pnlOlympicDetails";
            this.pnlOlympicDetails.Size = new System.Drawing.Size(464, 268);
            this.pnlOlympicDetails.TabIndex = 11;
            this.pnlOlympicDetails.Visible = false;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(295, 40);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(75, 23);
            this.btnViewDetails.TabIndex = 20;
            this.btnViewDetails.Text = "view";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Choose Year";
            // 
            // cmbDetYear
            // 
            this.cmbDetYear.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDetYear.FormattingEnabled = true;
            this.cmbDetYear.Location = new System.Drawing.Point(156, 40);
            this.cmbDetYear.Name = "cmbDetYear";
            this.cmbDetYear.Size = new System.Drawing.Size(121, 22);
            this.cmbDetYear.TabIndex = 18;
            // 
            // lstOlympicDetails
            // 
            this.lstOlympicDetails.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOlympicDetails.FormattingEnabled = true;
            this.lstOlympicDetails.ItemHeight = 14;
            this.lstOlympicDetails.Location = new System.Drawing.Point(35, 75);
            this.lstOlympicDetails.Name = "lstOlympicDetails";
            this.lstOlympicDetails.Size = new System.Drawing.Size(390, 144);
            this.lstOlympicDetails.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(153, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Details About Olympics";
            // 
            // pnlDeleteOlympics
            // 
            this.pnlDeleteOlympics.BackColor = System.Drawing.Color.White;
            this.pnlDeleteOlympics.Controls.Add(this.cmbDeleteYear);
            this.pnlDeleteOlympics.Controls.Add(this.label16);
            this.pnlDeleteOlympics.Controls.Add(this.btnDeleteOlympic);
            this.pnlDeleteOlympics.Controls.Add(this.label17);
            this.pnlDeleteOlympics.Location = new System.Drawing.Point(25, 22);
            this.pnlDeleteOlympics.Name = "pnlDeleteOlympics";
            this.pnlDeleteOlympics.Size = new System.Drawing.Size(464, 268);
            this.pnlDeleteOlympics.TabIndex = 10;
            this.pnlDeleteOlympics.Visible = false;
            // 
            // cmbDeleteYear
            // 
            this.cmbDeleteYear.FormattingEnabled = true;
            this.cmbDeleteYear.Location = new System.Drawing.Point(161, 62);
            this.cmbDeleteYear.Name = "cmbDeleteYear";
            this.cmbDeleteYear.Size = new System.Drawing.Size(121, 21);
            this.cmbDeleteYear.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(61, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 15);
            this.label16.TabIndex = 13;
            this.label16.Text = "Choose Year";
            // 
            // btnDeleteOlympic
            // 
            this.btnDeleteOlympic.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDeleteOlympic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOlympic.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOlympic.Location = new System.Drawing.Point(168, 156);
            this.btnDeleteOlympic.Name = "btnDeleteOlympic";
            this.btnDeleteOlympic.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOlympic.TabIndex = 9;
            this.btnDeleteOlympic.Text = "Remove";
            this.btnDeleteOlympic.UseVisualStyleBackColor = false;
            this.btnDeleteOlympic.Click += new System.EventHandler(this.btnDeleteOlympic_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(159, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 15);
            this.label17.TabIndex = 8;
            this.label17.Text = "Delete Olympics";
            // 
            // pnlAddOlympic
            // 
            this.pnlAddOlympic.BackColor = System.Drawing.Color.White;
            this.pnlAddOlympic.Controls.Add(this.txtAddYear);
            this.pnlAddOlympic.Controls.Add(this.label2);
            this.pnlAddOlympic.Controls.Add(this.dteAddEnd);
            this.pnlAddOlympic.Controls.Add(this.dteAddStart);
            this.pnlAddOlympic.Controls.Add(this.txtAddCity);
            this.pnlAddOlympic.Controls.Add(this.cmbAddCountry);
            this.pnlAddOlympic.Controls.Add(this.label10);
            this.pnlAddOlympic.Controls.Add(this.label9);
            this.pnlAddOlympic.Controls.Add(this.label8);
            this.pnlAddOlympic.Controls.Add(this.label7);
            this.pnlAddOlympic.Controls.Add(this.btnAddOlympics);
            this.pnlAddOlympic.Controls.Add(this.label3);
            this.pnlAddOlympic.Location = new System.Drawing.Point(23, 23);
            this.pnlAddOlympic.Name = "pnlAddOlympic";
            this.pnlAddOlympic.Size = new System.Drawing.Size(464, 268);
            this.pnlAddOlympic.TabIndex = 8;
            this.pnlAddOlympic.Visible = false;
            // 
            // txtAddYear
            // 
            this.txtAddYear.Location = new System.Drawing.Point(168, 122);
            this.txtAddYear.MaxLength = 4;
            this.txtAddYear.Name = "txtAddYear";
            this.txtAddYear.Size = new System.Drawing.Size(37, 20);
            this.txtAddYear.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Year";
            // 
            // dteAddEnd
            // 
            this.dteAddEnd.Location = new System.Drawing.Point(168, 176);
            this.dteAddEnd.Name = "dteAddEnd";
            this.dteAddEnd.Size = new System.Drawing.Size(200, 20);
            this.dteAddEnd.TabIndex = 20;
            // 
            // dteAddStart
            // 
            this.dteAddStart.Location = new System.Drawing.Point(168, 148);
            this.dteAddStart.Name = "dteAddStart";
            this.dteAddStart.Size = new System.Drawing.Size(200, 20);
            this.dteAddStart.TabIndex = 19;
            // 
            // txtAddCity
            // 
            this.txtAddCity.Location = new System.Drawing.Point(168, 93);
            this.txtAddCity.Name = "txtAddCity";
            this.txtAddCity.Size = new System.Drawing.Size(100, 20);
            this.txtAddCity.TabIndex = 18;
            // 
            // cmbAddCountry
            // 
            this.cmbAddCountry.FormattingEnabled = true;
            this.cmbAddCountry.Location = new System.Drawing.Point(168, 62);
            this.cmbAddCountry.Name = "cmbAddCountry";
            this.cmbAddCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbAddCountry.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "City Hosting";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Country Hosting";
            // 
            // btnAddOlympics
            // 
            this.btnAddOlympics.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddOlympics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOlympics.ForeColor = System.Drawing.Color.White;
            this.btnAddOlympics.Location = new System.Drawing.Point(168, 223);
            this.btnAddOlympics.Name = "btnAddOlympics";
            this.btnAddOlympics.Size = new System.Drawing.Size(75, 23);
            this.btnAddOlympics.TabIndex = 9;
            this.btnAddOlympics.Text = "Add";
            this.btnAddOlympics.UseVisualStyleBackColor = false;
            this.btnAddOlympics.Click += new System.EventHandler(this.btnActivateCountry_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add Olympic Games";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlLeft.Controls.Add(this.btnOlympicDetails);
            this.pnlLeft.Controls.Add(this.btnOlympicDelete);
            this.pnlLeft.Controls.Add(this.btnChangeOlympics);
            this.pnlLeft.Controls.Add(this.btnAddOlympic);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(167, 307);
            this.pnlLeft.TabIndex = 7;
            // 
            // btnOlympicDetails
            // 
            this.btnOlympicDetails.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOlympicDetails.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnOlympicDetails.FlatAppearance.BorderSize = 0;
            this.btnOlympicDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlympicDetails.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlympicDetails.ForeColor = System.Drawing.Color.White;
            this.btnOlympicDetails.Location = new System.Drawing.Point(0, 135);
            this.btnOlympicDetails.Name = "btnOlympicDetails";
            this.btnOlympicDetails.Size = new System.Drawing.Size(167, 28);
            this.btnOlympicDetails.TabIndex = 5;
            this.btnOlympicDetails.Text = "Details";
            this.btnOlympicDetails.UseVisualStyleBackColor = false;
            this.btnOlympicDetails.Click += new System.EventHandler(this.btnOlympicDetails_Click);
            // 
            // btnOlympicDelete
            // 
            this.btnOlympicDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOlympicDelete.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnOlympicDelete.FlatAppearance.BorderSize = 0;
            this.btnOlympicDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlympicDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlympicDelete.ForeColor = System.Drawing.Color.White;
            this.btnOlympicDelete.Location = new System.Drawing.Point(1, 95);
            this.btnOlympicDelete.Name = "btnOlympicDelete";
            this.btnOlympicDelete.Size = new System.Drawing.Size(167, 28);
            this.btnOlympicDelete.TabIndex = 4;
            this.btnOlympicDelete.Text = "Delete Olympics";
            this.btnOlympicDelete.UseVisualStyleBackColor = false;
            this.btnOlympicDelete.Click += new System.EventHandler(this.btnOlympicDelete_Click);
            // 
            // btnChangeOlympics
            // 
            this.btnChangeOlympics.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChangeOlympics.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnChangeOlympics.FlatAppearance.BorderSize = 0;
            this.btnChangeOlympics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeOlympics.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeOlympics.ForeColor = System.Drawing.Color.White;
            this.btnChangeOlympics.Location = new System.Drawing.Point(0, 55);
            this.btnChangeOlympics.Name = "btnChangeOlympics";
            this.btnChangeOlympics.Size = new System.Drawing.Size(167, 28);
            this.btnChangeOlympics.TabIndex = 3;
            this.btnChangeOlympics.Text = "Change Olympic";
            this.btnChangeOlympics.UseVisualStyleBackColor = false;
            this.btnChangeOlympics.Click += new System.EventHandler(this.btnChangeOlympics_Click);
            // 
            // btnAddOlympic
            // 
            this.btnAddOlympic.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddOlympic.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAddOlympic.FlatAppearance.BorderSize = 0;
            this.btnAddOlympic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOlympic.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOlympic.ForeColor = System.Drawing.Color.White;
            this.btnAddOlympic.Location = new System.Drawing.Point(0, 20);
            this.btnAddOlympic.Name = "btnAddOlympic";
            this.btnAddOlympic.Size = new System.Drawing.Size(167, 28);
            this.btnAddOlympic.TabIndex = 2;
            this.btnAddOlympic.Text = "Add Olympic";
            this.btnAddOlympic.UseVisualStyleBackColor = false;
            this.btnAddOlympic.Click += new System.EventHandler(this.btnAddOlympic_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pbClose);
            this.pnlTop.Controls.Add(this.pbMini);
            this.pnlTop.Controls.Add(this.lblCountry);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(687, 50);
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
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(322, 13);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(86, 22);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Olympic";
            // 
            // frmOlympics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 357);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmOlympics";
            this.Text = "frmOlympics";
            this.pnlMain.ResumeLayout(false);
            this.pnlChangeOlympics.ResumeLayout(false);
            this.pnlChangeOlympics.PerformLayout();
            this.pnlOlympicDetails.ResumeLayout(false);
            this.pnlOlympicDetails.PerformLayout();
            this.pnlDeleteOlympics.ResumeLayout(false);
            this.pnlDeleteOlympics.PerformLayout();
            this.pnlAddOlympic.ResumeLayout(false);
            this.pnlAddOlympic.PerformLayout();
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
        private System.Windows.Forms.Panel pnlAddOlympic;
        private System.Windows.Forms.Button btnAddOlympics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnAddOlympic;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMini;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.DateTimePicker dteAddEnd;
        private System.Windows.Forms.DateTimePicker dteAddStart;
        private System.Windows.Forms.TextBox txtAddCity;
        private System.Windows.Forms.ComboBox cmbAddCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlChangeOlympics;
        private System.Windows.Forms.TextBox txtChangeCity;
        private System.Windows.Forms.ComboBox cmbChangeYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdateOlympics;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOlympicDelete;
        private System.Windows.Forms.Button btnChangeOlympics;
        private System.Windows.Forms.Panel pnlDeleteOlympics;
        private System.Windows.Forms.ComboBox cmbDeleteYear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDeleteOlympic;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnOlympicDetails;
        private System.Windows.Forms.Panel pnlOlympicDetails;
        private System.Windows.Forms.ListBox lstOlympicDetails;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDetYear;
    }
}