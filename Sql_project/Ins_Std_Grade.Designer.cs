namespace Sql_project
{
    partial class Ins_Std_Grade
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.std_ID_Dataset = new Sql_project.Std_ID_Dataset();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Sql_project.Std_ID_DatasetTableAdapters.StudentTableAdapter();
            this.ins_Std_Grade_DataSet1 = new Sql_project.Ins_Std_Grade_DataSet1();
            this.insStdGradeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.std_GardeTableAdapter1 = new Sql_project.Examination_System_Final_ProjectDataSetTableAdapters.Std_GardeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.std_ID_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ins_Std_Grade_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insStdGradeDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.studentBindingSource;
            this.comboBox1.DisplayMember = "St_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "St_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Std_ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save as Pdf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Ins_Std_Grade_DataSet";
            reportDataSource2.Value = this.insStdGradeDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sql_project.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(764, 289);
            this.reportViewer1.TabIndex = 4;
            // 
            // std_ID_Dataset
            // 
            this.std_ID_Dataset.DataSetName = "Std_ID_Dataset";
            this.std_ID_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.std_ID_Dataset;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ins_Std_Grade_DataSet1
            // 
            this.ins_Std_Grade_DataSet1.DataSetName = "Ins_Std_Grade_DataSet1";
            this.ins_Std_Grade_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insStdGradeDataSet1BindingSource
            // 
            this.insStdGradeDataSet1BindingSource.DataSource = this.ins_Std_Grade_DataSet1;
            this.insStdGradeDataSet1BindingSource.Position = 0;
            // 
            // std_GardeTableAdapter1
            // 
            this.std_GardeTableAdapter1.ClearBeforeFill = true;
            // 
            // Ins_Std_Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Ins_Std_Grade";
            this.Text = "Ins_Std_Grade";
            this.Load += new System.EventHandler(this.Ins_Std_Grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.std_ID_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ins_Std_Grade_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insStdGradeDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Std_ID_Dataset std_ID_Dataset;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Std_ID_DatasetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource insStdGradeDataSet1BindingSource;
        private Ins_Std_Grade_DataSet1 ins_Std_Grade_DataSet1;
        private Examination_System_Final_ProjectDataSetTableAdapters.Std_GardeTableAdapter std_GardeTableAdapter1;
    }
}