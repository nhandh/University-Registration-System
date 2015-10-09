namespace URS
{
    partial class HomePageAdmin
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
            this.btnMaintainStudent = new System.Windows.Forms.Button();
            this.btnMaintainCourse = new System.Windows.Forms.Button();
            this.btnMaintainFaculty = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaintainStudent
            // 
            this.btnMaintainStudent.Location = new System.Drawing.Point(57, 52);
            this.btnMaintainStudent.Name = "btnMaintainStudent";
            this.btnMaintainStudent.Size = new System.Drawing.Size(178, 23);
            this.btnMaintainStudent.TabIndex = 0;
            this.btnMaintainStudent.Text = "Maintain Student Details";
            this.btnMaintainStudent.UseVisualStyleBackColor = true;
            this.btnMaintainStudent.Click += new System.EventHandler(this.btnMaintainStudent_Click);
            // 
            // btnMaintainCourse
            // 
            this.btnMaintainCourse.Location = new System.Drawing.Point(57, 97);
            this.btnMaintainCourse.Name = "btnMaintainCourse";
            this.btnMaintainCourse.Size = new System.Drawing.Size(178, 23);
            this.btnMaintainCourse.TabIndex = 0;
            this.btnMaintainCourse.Text = "Maintain Course Details";
            this.btnMaintainCourse.UseVisualStyleBackColor = true;
            this.btnMaintainCourse.Click += new System.EventHandler(this.btnMaintainCourse_Click);
            // 
            // btnMaintainFaculty
            // 
            this.btnMaintainFaculty.Location = new System.Drawing.Point(57, 143);
            this.btnMaintainFaculty.Name = "btnMaintainFaculty";
            this.btnMaintainFaculty.Size = new System.Drawing.Size(178, 23);
            this.btnMaintainFaculty.TabIndex = 0;
            this.btnMaintainFaculty.Text = "Maintain Faculty Details";
            this.btnMaintainFaculty.UseVisualStyleBackColor = true;
            this.btnMaintainFaculty.Click += new System.EventHandler(this.btnMaintainFaculty_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(57, 184);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(178, 23);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // HomePageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnMaintainFaculty);
            this.Controls.Add(this.btnMaintainCourse);
            this.Controls.Add(this.btnMaintainStudent);
            this.Name = "HomePageAdmin";
            this.Text = "HomePageAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaintainStudent;
        private System.Windows.Forms.Button btnMaintainCourse;
        private System.Windows.Forms.Button btnMaintainFaculty;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}