namespace Sql_project
{
    partial class Crs_Topic
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
            this.St_ID_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet21 = new Sql_project.DataSet2();
            this.crs_TopicsTableAdapter1 = new Sql_project.DataSet2TableAdapters.Crs_TopicsTableAdapter();
            this.dataSet22 = new Sql_project.DataSet2();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // St_ID_label
            // 
            this.St_ID_label.AutoSize = true;
            this.St_ID_label.Location = new System.Drawing.Point(67, 24);
            this.St_ID_label.Name = "St_ID_label";
            this.St_ID_label.Size = new System.Drawing.Size(71, 16);
            this.St_ID_label.TabIndex = 4;
            this.St_ID_label.Text = "Crs_Name";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(178, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sql_project.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(737, 363);
            this.reportViewer1.TabIndex = 5;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crs_TopicsTableAdapter1
            // 
            this.crs_TopicsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet22
            // 
            this.dataSet22.DataSetName = "DataSet2";
            this.dataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save as PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Crs_Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.St_ID_label);
            this.Controls.Add(this.textBox1);
            this.Name = "Crs_Topic";
            this.Text = "Crs_Topic";
            this.Load += new System.EventHandler(this.Crs_Topic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label St_ID_label;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet2 dataSet21;
        private DataSet2TableAdapters.Crs_TopicsTableAdapter crs_TopicsTableAdapter1;
        private DataSet2 dataSet22;
        private System.Windows.Forms.Button button1;
    }
}