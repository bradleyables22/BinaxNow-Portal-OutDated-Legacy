namespace BinaxNow_Portal.Forms
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.startlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartPicker = new System.Windows.Forms.DateTimePicker();
            this.EndPicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.Namebutton = new System.Windows.Forms.Button();
            this.DOBbutton = new System.Windows.Forms.Button();
            this.DOBpicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Phonebutton = new System.Windows.Forms.Button();
            this.PosButton = new System.Windows.Forms.Button();
            this.NegButton = new System.Windows.Forms.Button();
            this.ResButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Exportbutton = new System.Windows.Forms.Button();
            this.pDBDataSetV2 = new BinaxNow_Portal.PDBDataSetV2();
            this.binaxRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaxRecordsTableAdapter = new BinaxNow_Portal.PDBDataSetV2TableAdapters.BinaxRecordsTableAdapter();
            this.tableAdapterManager = new BinaxNow_Portal.PDBDataSetV2TableAdapters.TableAdapterManager();
            this.binaxRecordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.binaxRecordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.binaxRecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDBDataSetV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingNavigator)).BeginInit();
            this.binaxRecordsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startlabel
            // 
            this.startlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startlabel.AutoSize = true;
            this.startlabel.Location = new System.Drawing.Point(248, 22);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(97, 20);
            this.startlabel.TabIndex = 2;
            this.startlabel.Text = "Start Period:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "End Period:";
            // 
            // StartPicker
            // 
            this.StartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartPicker.Location = new System.Drawing.Point(224, 45);
            this.StartPicker.Name = "StartPicker";
            this.StartPicker.Size = new System.Drawing.Size(142, 26);
            this.StartPicker.TabIndex = 4;
            // 
            // EndPicker
            // 
            this.EndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndPicker.Location = new System.Drawing.Point(384, 45);
            this.EndPicker.Name = "EndPicker";
            this.EndPicker.Size = new System.Drawing.Size(138, 26);
            this.EndPicker.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filter by Dates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(94, 137);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(427, 26);
            this.NametextBox.TabIndex = 7;
            // 
            // Namebutton
            // 
            this.Namebutton.Location = new System.Drawing.Point(550, 115);
            this.Namebutton.Name = "Namebutton";
            this.Namebutton.Size = new System.Drawing.Size(128, 69);
            this.Namebutton.TabIndex = 8;
            this.Namebutton.Text = "Search by Name";
            this.Namebutton.UseVisualStyleBackColor = true;
            this.Namebutton.Click += new System.EventHandler(this.Namebutton_Click);
            // 
            // DOBbutton
            // 
            this.DOBbutton.Location = new System.Drawing.Point(550, 205);
            this.DOBbutton.Name = "DOBbutton";
            this.DOBbutton.Size = new System.Drawing.Size(128, 69);
            this.DOBbutton.TabIndex = 9;
            this.DOBbutton.Text = "Search by D.O.B";
            this.DOBbutton.UseVisualStyleBackColor = true;
            this.DOBbutton.Click += new System.EventHandler(this.DOBbutton_Click);
            // 
            // DOBpicker
            // 
            this.DOBpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBpicker.Location = new System.Drawing.Point(382, 225);
            this.DOBpicker.Name = "DOBpicker";
            this.DOBpicker.Size = new System.Drawing.Size(140, 26);
            this.DOBpicker.TabIndex = 10;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(404, 312);
            this.PhoneTextBox.Mask = "(999) 000-0000";
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(120, 26);
            this.PhoneTextBox.TabIndex = 11;
            // 
            // Phonebutton
            // 
            this.Phonebutton.Location = new System.Drawing.Point(550, 289);
            this.Phonebutton.Name = "Phonebutton";
            this.Phonebutton.Size = new System.Drawing.Size(128, 69);
            this.Phonebutton.TabIndex = 12;
            this.Phonebutton.Text = "Search by Phone";
            this.Phonebutton.UseVisualStyleBackColor = true;
            this.Phonebutton.Click += new System.EventHandler(this.Phonebutton_Click);
            // 
            // PosButton
            // 
            this.PosButton.Location = new System.Drawing.Point(814, 25);
            this.PosButton.Name = "PosButton";
            this.PosButton.Size = new System.Drawing.Size(128, 69);
            this.PosButton.TabIndex = 13;
            this.PosButton.Text = "Positive Results";
            this.PosButton.UseVisualStyleBackColor = true;
            this.PosButton.Click += new System.EventHandler(this.PosButton_Click);
            // 
            // NegButton
            // 
            this.NegButton.Location = new System.Drawing.Point(814, 115);
            this.NegButton.Name = "NegButton";
            this.NegButton.Size = new System.Drawing.Size(128, 69);
            this.NegButton.TabIndex = 14;
            this.NegButton.Text = "Negative Results";
            this.NegButton.UseVisualStyleBackColor = true;
            this.NegButton.Click += new System.EventHandler(this.NegButton_Click);
            // 
            // ResButton
            // 
            this.ResButton.Location = new System.Drawing.Point(814, 289);
            this.ResButton.Name = "ResButton";
            this.ResButton.Size = new System.Drawing.Size(128, 69);
            this.ResButton.TabIndex = 15;
            this.ResButton.Text = "RESET";
            this.ResButton.UseVisualStyleBackColor = true;
            this.ResButton.Click += new System.EventHandler(this.ResButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 69);
            this.button2.TabIndex = 16;
            this.button2.Text = "Other Results";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartPicker);
            this.groupBox1.Controls.Add(this.ResButton);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.startlabel);
            this.groupBox1.Controls.Add(this.EndPicker);
            this.groupBox1.Controls.Add(this.NegButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PosButton);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.Phonebutton);
            this.groupBox1.Controls.Add(this.DOBpicker);
            this.groupBox1.Controls.Add(this.DOBbutton);
            this.groupBox1.Controls.Add(this.PhoneTextBox);
            this.groupBox1.Controls.Add(this.Namebutton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(46, 562);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 378);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search && Filter";
            // 
            // Exportbutton
            // 
            this.Exportbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exportbutton.Location = new System.Drawing.Point(1240, 869);
            this.Exportbutton.Name = "Exportbutton";
            this.Exportbutton.Size = new System.Drawing.Size(130, 69);
            this.Exportbutton.TabIndex = 18;
            this.Exportbutton.Text = "Export to Excel";
            this.Exportbutton.UseVisualStyleBackColor = true;
            this.Exportbutton.Click += new System.EventHandler(this.Exportbutton_Click);
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
            // binaxRecordsBindingNavigator
            // 
            this.binaxRecordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.binaxRecordsBindingNavigator.BindingSource = this.binaxRecordsBindingSource;
            this.binaxRecordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.binaxRecordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.binaxRecordsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.binaxRecordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.binaxRecordsBindingNavigatorSaveItem});
            this.binaxRecordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.binaxRecordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.binaxRecordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.binaxRecordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.binaxRecordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.binaxRecordsBindingNavigator.Name = "binaxRecordsBindingNavigator";
            this.binaxRecordsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.binaxRecordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.binaxRecordsBindingNavigator.Size = new System.Drawing.Size(1406, 33);
            this.binaxRecordsBindingNavigator.TabIndex = 19;
            this.binaxRecordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // binaxRecordsBindingNavigatorSaveItem
            // 
            this.binaxRecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.binaxRecordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("binaxRecordsBindingNavigatorSaveItem.Image")));
            this.binaxRecordsBindingNavigatorSaveItem.Name = "binaxRecordsBindingNavigatorSaveItem";
            this.binaxRecordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.binaxRecordsBindingNavigatorSaveItem.Text = "Save Data";
            this.binaxRecordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.binaxRecordsBindingNavigatorSaveItem_Click);
            // 
            // binaxRecordsDataGridView
            // 
            this.binaxRecordsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.binaxRecordsDataGridView.AutoGenerateColumns = false;
            this.binaxRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.binaxRecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.binaxRecordsDataGridView.DataSource = this.binaxRecordsBindingSource;
            this.binaxRecordsDataGridView.Location = new System.Drawing.Point(13, 60);
            this.binaxRecordsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.binaxRecordsDataGridView.Name = "binaxRecordsDataGridView";
            this.binaxRecordsDataGridView.RowHeadersWidth = 62;
            this.binaxRecordsDataGridView.Size = new System.Drawing.Size(1380, 482);
            this.binaxRecordsDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatientId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatientName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PatientDOB";
            this.dataGridViewTextBoxColumn3.HeaderText = "PatientDOB";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PatientPhone";
            this.dataGridViewTextBoxColumn4.HeaderText = "PatientPhone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TestDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "TestDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TestResult";
            this.dataGridViewTextBoxColumn6.HeaderText = "TestResult";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ExpoInfo";
            this.dataGridViewTextBoxColumn7.HeaderText = "ExpoInfo";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PatientRace";
            this.dataGridViewTextBoxColumn8.HeaderText = "PatientRace";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PatientEthnic";
            this.dataGridViewTextBoxColumn9.HeaderText = "PatientEthnic";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PatientGender";
            this.dataGridViewTextBoxColumn10.HeaderText = "PatientGender";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 1050);
            this.Controls.Add(this.binaxRecordsDataGridView);
            this.Controls.Add(this.binaxRecordsBindingNavigator);
            this.Controls.Add(this.Exportbutton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDBDataSetV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingNavigator)).EndInit();
            this.binaxRecordsBindingNavigator.ResumeLayout(false);
            this.binaxRecordsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartPicker;
        private System.Windows.Forms.DateTimePicker EndPicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Button Namebutton;
        private System.Windows.Forms.Button DOBbutton;
        private System.Windows.Forms.DateTimePicker DOBpicker;
        private System.Windows.Forms.MaskedTextBox PhoneTextBox;
        private System.Windows.Forms.Button Phonebutton;
        private System.Windows.Forms.Button PosButton;
        private System.Windows.Forms.Button NegButton;
        private System.Windows.Forms.Button ResButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exportbutton;
        private PDBDataSetV2 pDBDataSetV2;
        private System.Windows.Forms.BindingSource binaxRecordsBindingSource;
        private PDBDataSetV2TableAdapters.BinaxRecordsTableAdapter binaxRecordsTableAdapter;
        private PDBDataSetV2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator binaxRecordsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton binaxRecordsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView binaxRecordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}