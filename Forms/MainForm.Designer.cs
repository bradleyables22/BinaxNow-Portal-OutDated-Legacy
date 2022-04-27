namespace BinaxNow_Portal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CpButton = new System.Windows.Forms.Button();
            this.RecordsButton = new System.Windows.Forms.Button();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.RedcapButton = new System.Windows.Forms.Button();
            this.patientDBDataSet = new BinaxNow_Portal.Data.PatientDBDataSet();
            this.binaxRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaxRecordsTableAdapter = new BinaxNow_Portal.Data.PatientDBDataSetTableAdapters.BinaxRecordsTableAdapter();
            this.tableAdapterManager = new BinaxNow_Portal.Data.PatientDBDataSetTableAdapters.TableAdapterManager();
            this.CountLabel = new System.Windows.Forms.Label();
            this.testdbutton = new System.Windows.Forms.Button();
            this.pDBDataSetV2 = new BinaxNow_Portal.PDBDataSetV2();
            this.binaxRecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.binaxRecordsTableAdapter1 = new BinaxNow_Portal.PDBDataSetV2TableAdapters.BinaxRecordsTableAdapter();
            this.tableAdapterManager1 = new BinaxNow_Portal.PDBDataSetV2TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.patientDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDBDataSetV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CpButton
            // 
            this.CpButton.Location = new System.Drawing.Point(26, 28);
            this.CpButton.Name = "CpButton";
            this.CpButton.Size = new System.Drawing.Size(158, 78);
            this.CpButton.TabIndex = 0;
            this.CpButton.Text = "Create Patient";
            this.CpButton.UseVisualStyleBackColor = true;
            this.CpButton.Click += new System.EventHandler(this.CpButton_Click);
            // 
            // RecordsButton
            // 
            this.RecordsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordsButton.Location = new System.Drawing.Point(752, 28);
            this.RecordsButton.Name = "RecordsButton";
            this.RecordsButton.Size = new System.Drawing.Size(158, 78);
            this.RecordsButton.TabIndex = 1;
            this.RecordsButton.Text = "Manage Records";
            this.RecordsButton.UseVisualStyleBackColor = true;
            this.RecordsButton.Click += new System.EventHandler(this.RecordsButton_Click);
            // 
            // ResultsButton
            // 
            this.ResultsButton.Location = new System.Drawing.Point(26, 140);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(158, 78);
            this.ResultsButton.TabIndex = 2;
            this.ResultsButton.Text = "Input Results";
            this.ResultsButton.UseVisualStyleBackColor = true;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // RedcapButton
            // 
            this.RedcapButton.Location = new System.Drawing.Point(26, 252);
            this.RedcapButton.Name = "RedcapButton";
            this.RedcapButton.Size = new System.Drawing.Size(158, 78);
            this.RedcapButton.TabIndex = 3;
            this.RedcapButton.Text = "REDCAP Reporting";
            this.RedcapButton.UseVisualStyleBackColor = true;
            this.RedcapButton.Click += new System.EventHandler(this.RedcapButton_Click);
            // 
            // patientDBDataSet
            // 
            this.patientDBDataSet.DataSetName = "PatientDBDataSet";
            this.patientDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // binaxRecordsBindingSource
            // 
            this.binaxRecordsBindingSource.DataMember = "BinaxRecords";
            this.binaxRecordsBindingSource.DataSource = this.patientDBDataSet;
            // 
            // binaxRecordsTableAdapter
            // 
            this.binaxRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BinaxRecordsTableAdapter = this.binaxRecordsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BinaxNow_Portal.Data.PatientDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CountLabel
            // 
            this.CountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CountLabel.BackColor = System.Drawing.Color.White;
            this.CountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountLabel.Location = new System.Drawing.Point(858, 636);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(52, 23);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testdbutton
            // 
            this.testdbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testdbutton.Location = new System.Drawing.Point(735, 636);
            this.testdbutton.Name = "testdbutton";
            this.testdbutton.Size = new System.Drawing.Size(117, 30);
            this.testdbutton.TabIndex = 5;
            this.testdbutton.Text = "Tested Today";
            this.testdbutton.UseVisualStyleBackColor = true;
            this.testdbutton.Click += new System.EventHandler(this.testdbutton_Click);
            // 
            // pDBDataSetV2
            // 
            this.pDBDataSetV2.DataSetName = "PDBDataSetV2";
            this.pDBDataSetV2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // binaxRecordsBindingSource1
            // 
            this.binaxRecordsBindingSource1.DataMember = "BinaxRecords";
            this.binaxRecordsBindingSource1.DataSource = this.pDBDataSetV2;
            // 
            // binaxRecordsTableAdapter1
            // 
            this.binaxRecordsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BinaxRecordsTableAdapter = this.binaxRecordsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = BinaxNow_Portal.PDBDataSetV2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 689);
            this.Controls.Add(this.testdbutton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.RedcapButton);
            this.Controls.Add(this.ResultsButton);
            this.Controls.Add(this.RecordsButton);
            this.Controls.Add(this.CpButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BinaxNOW Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDBDataSetV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaxRecordsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CpButton;
        private System.Windows.Forms.Button RecordsButton;
        private System.Windows.Forms.Button ResultsButton;
        private System.Windows.Forms.Button RedcapButton;
        private Data.PatientDBDataSet patientDBDataSet;
        private System.Windows.Forms.BindingSource binaxRecordsBindingSource;
        private Data.PatientDBDataSetTableAdapters.BinaxRecordsTableAdapter binaxRecordsTableAdapter;
        private Data.PatientDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button testdbutton;
        private PDBDataSetV2 pDBDataSetV2;
        private System.Windows.Forms.BindingSource binaxRecordsBindingSource1;
        private PDBDataSetV2TableAdapters.BinaxRecordsTableAdapter binaxRecordsTableAdapter1;
        private PDBDataSetV2TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

