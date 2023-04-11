namespace Sql_project
{
    partial class Ins_crs
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Ins_ID_dataset = new Sql_project.ComboBox_Ins_ID_dataset();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorTableAdapter = new Sql_project.ComboBox_Ins_ID_datasetTableAdapters.InstructorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.ins_Crs_DataSet1 = new Sql_project.Ins_Crs_DataSet1();
            this.insCrsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_Ins_ID_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ins_Crs_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insCrsDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructor ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.instructorBindingSource;
            this.comboBox1.DisplayMember = "Instructor_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Instructor_ID";
            // 
            // comboBox_Ins_ID_dataset
            // 
            this.comboBox_Ins_ID_dataset.DataSetName = "ComboBox_Ins_ID_dataset";
            this.comboBox_Ins_ID_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataMember = "Instructor";
            this.instructorBindingSource.DataSource = this.comboBox_Ins_ID_dataset;
            // 
            // instructorTableAdapter
            // 
            this.instructorTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Ins_Crs_DataSet1";
            reportDataSource2.Value = this.insCrsDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sql_project.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(720, 299);
            this.reportViewer1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save as PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ins_Crs_DataSet1
            // 
            this.ins_Crs_DataSet1.DataSetName = "Ins_Crs_DataSet1";
            this.ins_Crs_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insCrsDataSet1BindingSource
            // 
            this.insCrsDataSet1BindingSource.DataSource = this.ins_Crs_DataSet1;
            this.insCrsDataSet1BindingSource.Position = 0;
            // 
            // Ins_crs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ins_crs";
            this.Text = "Ins_crs";
            this.Load += new System.EventHandler(this.Ins_crs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_Ins_ID_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ins_Crs_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insCrsDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ComboBox_Ins_ID_dataset comboBox_Ins_ID_dataset;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private ComboBox_Ins_ID_datasetTableAdapters.InstructorTableAdapter instructorTableAdapter;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource insCrsDataSet1BindingSource;
        private Ins_Crs_DataSet1 ins_Crs_DataSet1;
    }
}