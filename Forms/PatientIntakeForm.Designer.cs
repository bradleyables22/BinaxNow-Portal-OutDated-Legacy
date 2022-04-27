namespace BinaxNow_Portal.Forms
{
    partial class PatientIntakeForm
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
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label patientDOBLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientIntakeForm));
            this.GeneralGroupbox = new System.Windows.Forms.GroupBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.DobPicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.GroupBox();
            this.EthnicListBox = new System.Windows.Forms.ListBox();
            this.RaceListbox = new System.Windows.Forms.ListBox();
            this.OtherRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.EthnicLabel = new System.Windows.Forms.Label();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.CountyTextBox = new System.Windows.Forms.TextBox();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.CountyLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.KitGroupBox = new System.Windows.Forms.GroupBox();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.ControlResultLabel = new System.Windows.Forms.Label();
            this.KitTextBox = new System.Windows.Forms.TextBox();
            this.KitRecievedPicker = new System.Windows.Forms.DateTimePicker();
            this.KitXpPicker = new System.Windows.Forms.DateTimePicker();
            this.KitReceivedLabel = new System.Windows.Forms.Label();
            this.KitXPLabel = new System.Windows.Forms.Label();
            this.KitLotLabel = new System.Windows.Forms.Label();
            this.CreatePatientbutton = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pDBDataSetV2 = new BinaxNow_Portal.PDBDataSetV2();
            this.binaxRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaxRecordsTableAdapter = new BinaxNow_Portal.PDBDataSetV2TableAdapters.BinaxRecordsTableAdapter();
            this.tableAdapterManager = new BinaxNow_Portal.PDBDataSetV2TableAdapters.TableAdapterManager();
            this.ContractTracegroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpolistBox = new System.Windows.Forms.ListBox();
            this.ExpoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            patientDOBLabel = new System.Windows.Forms.Label();
            this.GeneralGroupbox.SuspendLayout();
            this.l.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.KitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDBDataSetV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource)).BeginInit();
            this.ContractTracegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(46, 32);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(109, 20);
            patientNameLabel.TabIndex = 6;
            patientNameLabel.Text = "Patient Name:";
            // 
            // patientDOBLabel
            // 
            patientDOBLabel.AutoSize = true;
            patientDOBLabel.Location = new System.Drawing.Point(52, 83);
            patientDOBLabel.Name = "patientDOBLabel";
            patientDOBLabel.Size = new System.Drawing.Size(102, 20);
            patientDOBLabel.TabIndex = 7;
            patientDOBLabel.Text = "Patient DOB:";
            // 
            // GeneralGroupbox
            // 
            this.GeneralGroupbox.Controls.Add(this.NameTextbox);
            this.GeneralGroupbox.Controls.Add(this.DobPicker);
            this.GeneralGroupbox.Controls.Add(patientDOBLabel);
            this.GeneralGroupbox.Controls.Add(patientNameLabel);
            this.GeneralGroupbox.Controls.Add(this.PhoneMTextBox);
            this.GeneralGroupbox.Controls.Add(this.PhoneLabel);
            this.GeneralGroupbox.Location = new System.Drawing.Point(22, 23);
            this.GeneralGroupbox.Name = "GeneralGroupbox";
            this.GeneralGroupbox.Size = new System.Drawing.Size(488, 171);
            this.GeneralGroupbox.TabIndex = 0;
            this.GeneralGroupbox.TabStop = false;
            this.GeneralGroupbox.Text = "General Info";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(160, 32);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(304, 26);
            this.NameTextbox.TabIndex = 9;
            // 
            // DobPicker
            // 
            this.DobPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DobPicker.Location = new System.Drawing.Point(160, 78);
            this.DobPicker.Name = "DobPicker";
            this.DobPicker.Size = new System.Drawing.Size(138, 26);
            this.DobPicker.TabIndex = 8;
            this.DobPicker.Value = new System.DateTime(1990, 12, 1, 0, 0, 0, 0);
            // 
            // PhoneMTextBox
            // 
            this.PhoneMTextBox.Location = new System.Drawing.Point(178, 123);
            this.PhoneMTextBox.Mask = "(999) 000-0000";
            this.PhoneMTextBox.Name = "PhoneMTextBox";
            this.PhoneMTextBox.Size = new System.Drawing.Size(120, 26);
            this.PhoneMTextBox.TabIndex = 3;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(54, 126);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(119, 20);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Phone Number:";
            // 
            // l
            // 
            this.l.Controls.Add(this.EthnicListBox);
            this.l.Controls.Add(this.RaceListbox);
            this.l.Controls.Add(this.OtherRadioButton);
            this.l.Controls.Add(this.FemaleRadioButton);
            this.l.Controls.Add(this.MaleRadioButton);
            this.l.Controls.Add(this.EthnicLabel);
            this.l.Controls.Add(this.RaceLabel);
            this.l.Controls.Add(this.GenderLabel);
            this.l.Location = new System.Drawing.Point(682, 23);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(447, 363);
            this.l.TabIndex = 1;
            this.l.TabStop = false;
            this.l.Text = "Patient Demographics";
            // 
            // EthnicListBox
            // 
            this.EthnicListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EthnicListBox.FormattingEnabled = true;
            this.EthnicListBox.ItemHeight = 20;
            this.EthnicListBox.Items.AddRange(new object[] {
            "Non-Hispanic",
            "Hispanic",
            "Other",
            "Unknown"});
            this.EthnicListBox.Location = new System.Drawing.Point(110, 260);
            this.EthnicListBox.Name = "EthnicListBox";
            this.EthnicListBox.Size = new System.Drawing.Size(310, 84);
            this.EthnicListBox.TabIndex = 7;
            // 
            // RaceListbox
            // 
            this.RaceListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RaceListbox.FormattingEnabled = true;
            this.RaceListbox.ItemHeight = 20;
            this.RaceListbox.Items.AddRange(new object[] {
            "White",
            "Hispanic or Latino",
            "Black or African American",
            "American Indian or Alaska Native",
            "Asian",
            "Native Hawaiian or Other Pacific Islander",
            "Other",
            "Unknown"});
            this.RaceListbox.Location = new System.Drawing.Point(110, 74);
            this.RaceListbox.Name = "RaceListbox";
            this.RaceListbox.Size = new System.Drawing.Size(310, 164);
            this.RaceListbox.TabIndex = 6;
            // 
            // OtherRadioButton
            // 
            this.OtherRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OtherRadioButton.AutoSize = true;
            this.OtherRadioButton.Location = new System.Drawing.Point(261, 28);
            this.OtherRadioButton.Name = "OtherRadioButton";
            this.OtherRadioButton.Size = new System.Drawing.Size(74, 24);
            this.OtherRadioButton.TabIndex = 5;
            this.OtherRadioButton.TabStop = true;
            this.OtherRadioButton.Text = "Other";
            this.OtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(166, 28);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(87, 24);
            this.FemaleRadioButton.TabIndex = 4;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(92, 29);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(68, 24);
            this.MaleRadioButton.TabIndex = 3;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // EthnicLabel
            // 
            this.EthnicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EthnicLabel.AutoSize = true;
            this.EthnicLabel.Location = new System.Drawing.Point(32, 260);
            this.EthnicLabel.Name = "EthnicLabel";
            this.EthnicLabel.Size = new System.Drawing.Size(73, 20);
            this.EthnicLabel.TabIndex = 2;
            this.EthnicLabel.Text = "Ethnicity:";
            // 
            // RaceLabel
            // 
            this.RaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(52, 74);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(51, 20);
            this.RaceLabel.TabIndex = 1;
            this.RaceLabel.Text = "Race:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(20, 32);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(67, 20);
            this.GenderLabel.TabIndex = 0;
            this.GenderLabel.Text = "Gender:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ZipTextBox);
            this.groupBox1.Controls.Add(this.CountyTextBox);
            this.groupBox1.Controls.Add(this.StateTextBox);
            this.groupBox1.Controls.Add(this.CountyLabel);
            this.groupBox1.Controls.Add(this.ZipLabel);
            this.groupBox1.Controls.Add(this.StateLabel);
            this.groupBox1.Controls.Add(this.CityLabel);
            this.groupBox1.Controls.Add(this.StreetLabel);
            this.groupBox1.Controls.Add(this.CityTextBox);
            this.groupBox1.Controls.Add(this.StreetTextBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Address";
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(486, 72);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(100, 26);
            this.ZipTextBox.TabIndex = 14;
            // 
            // CountyTextBox
            // 
            this.CountyTextBox.Location = new System.Drawing.Point(448, 122);
            this.CountyTextBox.Name = "CountyTextBox";
            this.CountyTextBox.Size = new System.Drawing.Size(138, 26);
            this.CountyTextBox.TabIndex = 13;
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(357, 72);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(82, 26);
            this.StateTextBox.TabIndex = 12;
            // 
            // CountyLabel
            // 
            this.CountyLabel.AutoSize = true;
            this.CountyLabel.Location = new System.Drawing.Point(380, 122);
            this.CountyLabel.Name = "CountyLabel";
            this.CountyLabel.Size = new System.Drawing.Size(63, 20);
            this.CountyLabel.TabIndex = 11;
            this.CountyLabel.Text = "County:";
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(446, 75);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(35, 20);
            this.ZipLabel.TabIndex = 9;
            this.ZipLabel.Text = "Zip:";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(298, 75);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(52, 20);
            this.StateLabel.TabIndex = 8;
            this.StateLabel.Text = "State:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(8, 75);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(39, 20);
            this.CityLabel.TabIndex = 7;
            this.CityLabel.Text = "City:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(8, 31);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(120, 20);
            this.StreetLabel.TabIndex = 6;
            this.StreetLabel.Text = "Street Address:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(52, 72);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(228, 26);
            this.CityTextBox.TabIndex = 1;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(134, 26);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(474, 26);
            this.StreetTextBox.TabIndex = 0;
            // 
            // KitGroupBox
            // 
            this.KitGroupBox.Controls.Add(this.NoRadioButton);
            this.KitGroupBox.Controls.Add(this.YesRadioButton);
            this.KitGroupBox.Controls.Add(this.ControlResultLabel);
            this.KitGroupBox.Controls.Add(this.KitTextBox);
            this.KitGroupBox.Controls.Add(this.KitRecievedPicker);
            this.KitGroupBox.Controls.Add(this.KitXpPicker);
            this.KitGroupBox.Controls.Add(this.KitReceivedLabel);
            this.KitGroupBox.Controls.Add(this.KitXPLabel);
            this.KitGroupBox.Controls.Add(this.KitLotLabel);
            this.KitGroupBox.Location = new System.Drawing.Point(22, 414);
            this.KitGroupBox.Name = "KitGroupBox";
            this.KitGroupBox.Size = new System.Drawing.Size(374, 243);
            this.KitGroupBox.TabIndex = 3;
            this.KitGroupBox.TabStop = false;
            this.KitGroupBox.Text = "Kit Information";
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(278, 188);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(54, 24);
            this.NoRadioButton.TabIndex = 8;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.Location = new System.Drawing.Point(192, 188);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(62, 24);
            this.YesRadioButton.TabIndex = 7;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Yes";
            this.YesRadioButton.UseVisualStyleBackColor = true;
            // 
            // ControlResultLabel
            // 
            this.ControlResultLabel.AutoSize = true;
            this.ControlResultLabel.Location = new System.Drawing.Point(28, 191);
            this.ControlResultLabel.Name = "ControlResultLabel";
            this.ControlResultLabel.Size = new System.Drawing.Size(161, 20);
            this.ControlResultLabel.TabIndex = 6;
            this.ControlResultLabel.Text = "Control Results Valid:";
            // 
            // KitTextBox
            // 
            this.KitTextBox.Location = new System.Drawing.Point(192, 145);
            this.KitTextBox.Name = "KitTextBox";
            this.KitTextBox.Size = new System.Drawing.Size(142, 26);
            this.KitTextBox.TabIndex = 5;
            this.KitTextBox.Text = "127099";
            this.KitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KitRecievedPicker
            // 
            this.KitRecievedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.KitRecievedPicker.Location = new System.Drawing.Point(192, 92);
            this.KitRecievedPicker.Name = "KitRecievedPicker";
            this.KitRecievedPicker.Size = new System.Drawing.Size(142, 26);
            this.KitRecievedPicker.TabIndex = 4;
            this.KitRecievedPicker.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // KitXpPicker
            // 
            this.KitXpPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.KitXpPicker.Location = new System.Drawing.Point(192, 40);
            this.KitXpPicker.Name = "KitXpPicker";
            this.KitXpPicker.Size = new System.Drawing.Size(142, 26);
            this.KitXpPicker.TabIndex = 3;
            this.KitXpPicker.Value = new System.DateTime(2021, 3, 23, 0, 0, 0, 0);
            // 
            // KitReceivedLabel
            // 
            this.KitReceivedLabel.AutoSize = true;
            this.KitReceivedLabel.Location = new System.Drawing.Point(46, 95);
            this.KitReceivedLabel.Name = "KitReceivedLabel";
            this.KitReceivedLabel.Size = new System.Drawing.Size(140, 20);
            this.KitReceivedLabel.TabIndex = 2;
            this.KitReceivedLabel.Text = "Kit Received Date:";
            // 
            // KitXPLabel
            // 
            this.KitXPLabel.AutoSize = true;
            this.KitXPLabel.Location = new System.Drawing.Point(92, 43);
            this.KitXPLabel.Name = "KitXPLabel";
            this.KitXPLabel.Size = new System.Drawing.Size(95, 20);
            this.KitXPLabel.TabIndex = 1;
            this.KitXPLabel.Text = "Kit XP Date:";
            // 
            // KitLotLabel
            // 
            this.KitLotLabel.AutoSize = true;
            this.KitLotLabel.Location = new System.Drawing.Point(117, 149);
            this.KitLotLabel.Name = "KitLotLabel";
            this.KitLotLabel.Size = new System.Drawing.Size(71, 20);
            this.KitLotLabel.TabIndex = 0;
            this.KitLotLabel.Text = "Kit Lot #:";
            // 
            // CreatePatientbutton
            // 
            this.CreatePatientbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatePatientbutton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.CreatePatientbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePatientbutton.Location = new System.Drawing.Point(22, 681);
            this.CreatePatientbutton.Name = "CreatePatientbutton";
            this.CreatePatientbutton.Size = new System.Drawing.Size(1108, 65);
            this.CreatePatientbutton.TabIndex = 5;
            this.CreatePatientbutton.Text = "Create Patient";
            this.CreatePatientbutton.UseVisualStyleBackColor = false;
            this.CreatePatientbutton.Click += new System.EventHandler(this.CreatePatientbutton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pDBDataSetV2
            // 
            this.pDBDataSetV2.DataSetName = "PDBDataSetV2";
            this.pDBDataSetV2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // binaxRecordsBindingSource
            // 
            this.binaxRecordsBindingSource.DataMember = "BinaxRecords";
            this.binaxRecordsBindingSource.DataSource = this.pDBDataSetV2;
            // 
            // binaxRecordsTableAdapter
            // 
            this.binaxRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BinaxRecordsTableAdapter = this.binaxRecordsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BinaxNow_Portal.PDBDataSetV2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ContractTracegroupBox
            // 
            this.ContractTracegroupBox.Controls.Add(this.label2);
            this.ContractTracegroupBox.Controls.Add(this.ExpolistBox);
            this.ContractTracegroupBox.Controls.Add(this.ExpoTextBox);
            this.ContractTracegroupBox.Controls.Add(this.label1);
            this.ContractTracegroupBox.Location = new System.Drawing.Point(420, 414);
            this.ContractTracegroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContractTracegroupBox.Name = "ContractTracegroupBox";
            this.ContractTracegroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContractTracegroupBox.Size = new System.Drawing.Size(710, 243);
            this.ContractTracegroupBox.TabIndex = 7;
            this.ContractTracegroupBox.TabStop = false;
            this.ContractTracegroupBox.Text = "Contact Tracing information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exposure Details:";
            // 
            // ExpolistBox
            // 
            this.ExpolistBox.FormattingEnabled = true;
            this.ExpolistBox.ItemHeight = 20;
            this.ExpolistBox.Items.AddRange(new object[] {
            "Household",
            "Restaurant/Bar",
            "Work",
            "Social Gathuring",
            "Other",
            "Unknown"});
            this.ExpolistBox.Location = new System.Drawing.Point(514, 27);
            this.ExpolistBox.Name = "ExpolistBox";
            this.ExpolistBox.Size = new System.Drawing.Size(168, 124);
            this.ExpolistBox.TabIndex = 2;
            // 
            // ExpoTextBox
            // 
            this.ExpoTextBox.Location = new System.Drawing.Point(12, 207);
            this.ExpoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpoTextBox.Name = "ExpoTextBox";
            this.ExpoTextBox.Size = new System.Drawing.Size(690, 26);
            this.ExpoTextBox.TabIndex = 1;
            this.ExpoTextBox.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Exposure:";
            // 
            // PatientIntakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1154, 810);
            this.Controls.Add(this.ContractTracegroupBox);
            this.Controls.Add(this.CreatePatientbutton);
            this.Controls.Add(this.KitGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.GeneralGroupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientIntakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Intake";
            this.Load += new System.EventHandler(this.PatientIntakeForm_Load);
            this.GeneralGroupbox.ResumeLayout(false);
            this.GeneralGroupbox.PerformLayout();
            this.l.ResumeLayout(false);
            this.l.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.KitGroupBox.ResumeLayout(false);
            this.KitGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDBDataSetV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource)).EndInit();
            this.ContractTracegroupBox.ResumeLayout(false);
            this.ContractTracegroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GeneralGroupbox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.GroupBox l;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label CountyLabel;
        private System.Windows.Forms.RadioButton OtherRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Label EthnicLabel;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.MaskedTextBox PhoneMTextBox;
        private System.Windows.Forms.ListBox EthnicListBox;
        private System.Windows.Forms.ListBox RaceListbox;
        private System.Windows.Forms.GroupBox KitGroupBox;
        private System.Windows.Forms.Label KitXPLabel;
        private System.Windows.Forms.Label KitLotLabel;
        private System.Windows.Forms.DateTimePicker KitRecievedPicker;
        private System.Windows.Forms.DateTimePicker KitXpPicker;
        private System.Windows.Forms.Label KitReceivedLabel;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.Label ControlResultLabel;
        private System.Windows.Forms.TextBox KitTextBox;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.TextBox CountyTextBox;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.Button CreatePatientbutton;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.DateTimePicker DobPicker;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PDBDataSetV2 pDBDataSetV2;
        private System.Windows.Forms.BindingSource binaxRecordsBindingSource;
        private PDBDataSetV2TableAdapters.BinaxRecordsTableAdapter binaxRecordsTableAdapter;
        private PDBDataSetV2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox ContractTracegroupBox;
        private System.Windows.Forms.TextBox ExpoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ExpolistBox;
    }
}