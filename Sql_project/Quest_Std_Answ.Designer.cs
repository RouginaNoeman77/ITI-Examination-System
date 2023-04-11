namespace Sql_project
{
    partial class Quest_Std_Answ
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Exam_ID = new Sql_project.DS_Exam_ID();
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter = new Sql_project.DS_Exam_IDTableAdapters.ExamTableAdapter();
            this.dS_Std_ID = new Sql_project.dS_Std_ID();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Sql_project.dS_Std_IDTableAdapters.StudentTableAdapter();
            this.ques_Std_Answer_DataSet1 = new Sql_project.Ques_Std_Answer_DataSet1();
            this.quesStdAnswerDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Exam_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Std_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ques_Std_Answer_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quesStdAnswerDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save as PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 22);
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
            this.comboBox1.Location = new System.Drawing.Point(127, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Exam_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exam ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.studentBindingSource;
            this.comboBox2.DisplayMember = "St_ID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(414, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "St_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Std ID";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Ques_Std_Answer_DataSet1";
            reportDataSource2.Value = this.quesStdAnswerDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sql_project.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1096, 304);
            this.reportViewer1.TabIndex = 11;
            // 
            // dS_Exam_ID
            // 
            this.dS_Exam_ID.DataSetName = "DS_Exam_ID";
            this.dS_Exam_ID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "Exam";
            this.examBindingSource.DataSource = this.dS_Exam_ID;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // dS_Std_ID
            // 
            this.dS_Std_ID.DataSetName = "dS_Std_ID";
            this.dS_Std_ID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dS_Std_ID;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ques_Std_Answer_DataSet1
            // 
            this.ques_Std_Answer_DataSet1.DataSetName = "Ques_Std_Answer_DataSet1";
            this.ques_Std_Answer_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quesStdAnswerDataSet1BindingSource
            // 
            this.quesStdAnswerDataSet1BindingSource.DataSource = this.ques_Std_Answer_DataSet1;
            this.quesStdAnswerDataSet1BindingSource.Position = 0;
            // 
            // Quest_Std_Answ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Quest_Std_Answ";
            this.Text = "Quest_Std_Answ";
            this.Load += new System.EventHandler(this.Quest_Std_Answ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Exam_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Std_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ques_Std_Answer_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quesStdAnswerDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Exam_ID dS_Exam_ID;
        private System.Windows.Forms.BindingSource examBindingSource;
        private DS_Exam_IDTableAdapters.ExamTableAdapter examTableAdapter;
        private dS_Std_ID dS_Std_ID;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private dS_Std_IDTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource quesStdAnswerDataSet1BindingSource;
        private Ques_Std_Answer_DataSet1 ques_Std_Answer_DataSet1;
    }
}