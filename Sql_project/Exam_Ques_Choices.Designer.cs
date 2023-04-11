namespace Sql_project
{
    partial class Exam_Ques_Choices
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.examIDComboBoxDataSet1 = new Sql_project.ExamIDComboBoxDataSet1();
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter = new Sql_project.ExamIDComboBoxDataSet1TableAdapters.ExamTableAdapter();
            this.exam_Ques_Choice_DataSet1 = new Sql_project.Exam_Ques_Choice_DataSet1();
            this.examQuesChoiceDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.examIDComboBoxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam_Ques_Choice_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examQuesChoiceDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save as PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.examBindingSource;
            this.comboBox1.DisplayMember = "Exam_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Exam_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exam ID";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Exam_Ques_Choice_DataSet1";
            reportDataSource2.Value = this.examQuesChoiceDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sql_project.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(32, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(730, 299);
            this.reportViewer1.TabIndex = 9;
            // 
            // examIDComboBoxDataSet1
            // 
            this.examIDComboBoxDataSet1.DataSetName = "ExamIDComboBoxDataSet1";
            this.examIDComboBoxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "Exam";
            this.examBindingSource.DataSource = this.examIDComboBoxDataSet1;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // exam_Ques_Choice_DataSet1
            // 
            this.exam_Ques_Choice_DataSet1.DataSetName = "Exam_Ques_Choice_DataSet1";
            this.exam_Ques_Choice_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examQuesChoiceDataSet1BindingSource
            // 
            this.examQuesChoiceDataSet1BindingSource.DataSource = this.exam_Ques_Choice_DataSet1;
            this.examQuesChoiceDataSet1BindingSource.Position = 0;
            // 
            // Exam_Ques_Choices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Exam_Ques_Choices";
            this.Text = "Exam_Ques_Choices";
            this.Load += new System.EventHandler(this.Exam_Ques_Choices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examIDComboBoxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam_Ques_Choice_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examQuesChoiceDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ExamIDComboBoxDataSet1 examIDComboBoxDataSet1;
        private System.Windows.Forms.BindingSource examBindingSource;
        private ExamIDComboBoxDataSet1TableAdapters.ExamTableAdapter examTableAdapter;
        private System.Windows.Forms.BindingSource examQuesChoiceDataSet1BindingSource;
        private Exam_Ques_Choice_DataSet1 exam_Ques_Choice_DataSet1;
    }
}