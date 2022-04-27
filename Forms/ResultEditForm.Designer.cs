namespace BinaxNow_Portal.Forms
{
    partial class ResultEditForm
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
            System.Windows.Forms.Label patientIdLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label patientDOBLabel;
            System.Windows.Forms.Label patientPhoneLabel;
            System.Windows.Forms.Label testDateLabel;
            System.Windows.Forms.Label testResultLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultEditForm));
            this.Namebutton = new System.Windows.Forms.Button();
            this.phonebutton = new System.Windows.Forms.Button();
            this.SearchgroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.pDBDataSetV2 = new BinaxNow_Portal.PDBDataSetV2();
            this.binaxRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaxRecordsTableAdapter = new BinaxNow_Portal.PDBDataSetV2TableAdapters.BinaxRecordsTableAdapter();
            this.tableAdapterManager = new BinaxNow_Portal.PDBDataSetV2TableAdapters.TableAdapterManager();
            this.binaxRecordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.binaxRecordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.patientDOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientPhoneTextBox = new System.Windows.Forms.TextBox();
            this.testDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testResultTextBox = new System.Windows.Forms.TextBox();
            patientIdLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            patientDOBLabel = new System.Windows.Forms.Label();
            patientPhoneLabel = new System.Windows.Forms.Label();
            testDateLabel = new System.Windows.Forms.Label();
            testResultLabel = new System.Windows.Forms.Label();
            this.SearchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDBDataSetV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingNavigator)).BeginInit();
            this.binaxRecordsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Location = new System.Drawing.Point(58, 72);
            patientIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new System.Drawing.Size(81, 20);
            patientIdLabel.TabIndex = 17;
            patientIdLabel.Text = "Patient Id:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(30, 114);
            patientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(109, 20);
            patientNameLabel.TabIndex = 19;
            patientNameLabel.Text = "Patient Name:";
            // 
            // patientDOBLabel
            // 
            patientDOBLabel.AutoSize = true;
            patientDOBLabel.Location = new System.Drawing.Point(38, 158);
            patientDOBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            patientDOBLabel.Name = "patientDOBLabel";
            patientDOBLabel.Size = new System.Drawing.Size(102, 20);
            patientDOBLabel.TabIndex = 21;
            patientDOBLabel.Text = "Patient DOB:";
            // 
            // patientPhoneLabel
            // 
            patientPhoneLabel.AutoSize = true;
            patientPhoneLabel.Location = new System.Drawing.Point(26, 192);
            patientPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            patientPhoneLabel.Name = "patientPhoneLabel";
            patientPhoneLabel.Size = new System.Drawing.Size(113, 20);
            patientPhoneLabel.TabIndex = 23;
            patientPhoneLabel.Text = "Patient Phone:";
            // 
            // testDateLabel
            // 
            testDateLabel.AutoSize = true;
            testDateLabel.Location = new System.Drawing.Point(51, 235);
            testDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            testDateLabel.Name = "testDateLabel";
            testDateLabel.Size = new System.Drawing.Size(83, 20);
            testDateLabel.TabIndex = 25;
            testDateLabel.Text = "Test Date:";
            // 
            // testResultLabel
            // 
            testResultLabel.AutoSize = true;
            testResultLabel.Location = new System.Drawing.Point(45, 394);
            testResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            testResultLabel.Name = "testResultLabel";
            testResultLabel.Size = new System.Drawing.Size(94, 20);
            testResultLabel.TabIndex = 27;
            testResultLabel.Text = "Test Result:";
            // 
            // Namebutton
            // 
            this.Namebutton.Location = new System.Drawing.Point(105, 68);
            this.Namebutton.Name = "Namebutton";
            this.Namebutton.Size = new System.Drawing.Size(178, 37);
            this.Namebutton.TabIndex = 0;
            this.Namebutton.Text = "Search By Name";
            this.Namebutton.UseVisualStyleBackColor = true;
            this.Namebutton.Click += new System.EventHandler(this.Namebutton_Click);
            // 
            // phonebutton
            // 
            this.phonebutton.Location = new System.Drawing.Point(105, 168);
            this.phonebutton.Name = "phonebutton";
            this.phonebutton.Size = new System.Drawing.Size(178, 37);
            this.phonebutton.TabIndex = 1;
            this.phonebutton.Text = "Search By Phone #";
            this.phonebutton.UseVisualStyleBackColor = true;
            this.phonebutton.Click += new System.EventHandler(this.phonebutton_Click);
            // 
            // SearchgroupBox
            // 
            this.SearchgroupBox.Controls.Add(this.PhoneTextBox);
            this.SearchgroupBox.Controls.Add(this.NametextBox);
            this.SearchgroupBox.Controls.Add(this.Namebutton);
            this.SearchgroupBox.Controls.Add(this.phonebutton);
            this.SearchgroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchgroupBox.Location = new System.Drawing.Point(402, 55);
            this.SearchgroupBox.Name = "SearchgroupBox";
            this.SearchgroupBox.Size = new System.Drawing.Size(374, 235);
            this.SearchgroupBox.TabIndex = 16;
            this.SearchgroupBox.TabStop = false;
            this.SearchgroupBox.Text = "Patient Lookup";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(136, 135);
            this.PhoneTextBox.Mask = "(999) 000-0000";
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(116, 26);
            this.PhoneTextBox.TabIndex = 16;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(22, 35);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(331, 26);
            this.NametextBox.TabIndex = 1;
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
            this.binaxRecordsBindingNavigator.AddNewItem = null;
            this.binaxRecordsBindingNavigator.BindingSource = this.binaxRecordsBindingSource;
            this.binaxRecordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.binaxRecordsBindingNavigator.DeleteItem = null;
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
            this.binaxRecordsBindingNavigatorSaveItem});
            this.binaxRecordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.binaxRecordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.binaxRecordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.binaxRecordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.binaxRecordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.binaxRecordsBindingNavigator.Name = "binaxRecordsBindingNavigator";
            this.binaxRecordsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.binaxRecordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.binaxRecordsBindingNavigator.Size = new System.Drawing.Size(806, 33);
            this.binaxRecordsBindingNavigator.TabIndex = 17;
            this.binaxRecordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // patientIdTextBox
            // 
            this.patientIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binaxRecordsBindingSource, "PatientId", true));
            this.patientIdTextBox.Location = new System.Drawing.Point(146, 67);
            this.patientIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(192, 26);
            this.patientIdTextBox.TabIndex = 18;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binaxRecordsBindingSource, "PatientName", true));
            this.patientNameTextBox.Location = new System.Drawing.Point(146, 107);
            this.patientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(236, 26);
            this.patientNameTextBox.TabIndex = 20;
            // 
            // patientDOBDateTimePicker
            // 
            this.patientDOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binaxRecordsBindingSource, "PatientDOB", true));
            this.patientDOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patientDOBDateTimePicker.Location = new System.Drawing.Point(146, 147);
            this.patientDOBDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientDOBDateTimePicker.Name = "patientDOBDateTimePicker";
            this.patientDOBDateTimePicker.Size = new System.Drawing.Size(192, 26);
            this.patientDOBDateTimePicker.TabIndex = 22;
            // 
            // patientPhoneTextBox
            // 
            this.patientPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binaxRecordsBindingSource, "PatientPhone", true));
            this.patientPhoneTextBox.Location = new System.Drawing.Point(146, 187);
            this.patientPhoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientPhoneTextBox.Name = "patientPhoneTextBox";
            this.patientPhoneTextBox.Size = new System.Drawing.Size(192, 26);
            this.patientPhoneTextBox.TabIndex = 24;
            // 
            // testDateDateTimePicker
            // 
            this.testDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binaxRecordsBindingSource, "TestDate", true));
            this.testDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.testDateDateTimePicker.Location = new System.Drawing.Point(146, 227);
            this.testDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testDateDateTimePicker.Name = "testDateDateTimePicker";
            this.testDateDateTimePicker.Size = new System.Drawing.Size(192, 26);
            this.testDateDateTimePicker.TabIndex = 26;
            // 
            // testResultTextBox
            // 
            this.testResultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binaxRecordsBindingSource, "TestResult", true));
            this.testResultTextBox.Location = new System.Drawing.Point(146, 388);
            this.testResultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testResultTextBox.Name = "testResultTextBox";
            this.testResultTextBox.Size = new System.Drawing.Size(192, 26);
            this.testResultTextBox.TabIndex = 28;
            // 
            // ResultEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 454);
            this.Controls.Add(patientIdLabel);
            this.Controls.Add(this.patientIdTextBox);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.patientDOBDateTimePicker);
            this.Controls.Add(patientDOBLabel);
            this.Controls.Add(patientPhoneLabel);
            this.Controls.Add(this.patientPhoneTextBox);
            this.Controls.Add(testDateLabel);
            this.Controls.Add(this.testDateDateTimePicker);
            this.Controls.Add(testResultLabel);
            this.Controls.Add(this.testResultTextBox);
            this.Controls.Add(this.binaxRecordsBindingNavigator);
            this.Controls.Add(this.SearchgroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result Entry ";
            this.Load += new System.EventHandler(this.ResultEditForm_Load);
            this.SearchgroupBox.ResumeLayout(false);
            this.SearchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDBDataSetV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingNavigator)).EndInit();
            this.binaxRecordsBindingNavigator.ResumeLayout(false);
            this.binaxRecordsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Namebutton;
        private System.Windows.Forms.Button phonebutton;
        private System.Windows.Forms.GroupBox SearchgroupBox;
        private System.Windows.Forms.MaskedTextBox PhoneTextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private PDBDataSetV2 pDBDataSetV2;
        private System.Windows.Forms.BindingSource binaxRecordsBindingSource;
        private PDBDataSetV2TableAdapters.BinaxRecordsTableAdapter binaxRecordsTableAdapter;
        private PDBDataSetV2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator binaxRecordsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton binaxRecordsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.DateTimePicker patientDOBDateTimePicker;
        private System.Windows.Forms.TextBox patientPhoneTextBox;
        private System.Windows.Forms.DateTimePicker testDateDateTimePicker;
        private System.Windows.Forms.TextBox testResultTextBox;
    }
}