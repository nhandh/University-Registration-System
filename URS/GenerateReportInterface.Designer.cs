namespace URS
{
    partial class GenerateReportInterface
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
            this.btnReportRegistrationStudent = new System.Windows.Forms.Button();
            this.btnReportCourseDetails = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblCourseDesignation = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.btnReportAllStudents = new System.Windows.Forms.Button();
            this.btnReportAllCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportRegistrationStudent
            // 
            this.btnReportRegistrationStudent.Location = new System.Drawing.Point(40, 50);
            this.btnReportRegistrationStudent.Name = "btnReportRegistrationStudent";
            this.btnReportRegistrationStudent.Size = new System.Drawing.Size(187, 23);
            this.btnReportRegistrationStudent.TabIndex = 0;
            this.btnReportRegistrationStudent.Text = "Report registration of student";
            this.btnReportRegistrationStudent.UseVisualStyleBackColor = true;
            this.btnReportRegistrationStudent.Click += new System.EventHandler(this.btnReportRegistrationStudent_Click);
            // 
            // btnReportCourseDetails
            // 
            this.btnReportCourseDetails.Location = new System.Drawing.Point(40, 102);
            this.btnReportCourseDetails.Name = "btnReportCourseDetails";
            this.btnReportCourseDetails.Size = new System.Drawing.Size(187, 23);
            this.btnReportCourseDetails.TabIndex = 1;
            this.btnReportCourseDetails.Text = "Report detail of this course";
            this.btnReportCourseDetails.UseVisualStyleBackColor = true;
            this.btnReportCourseDetails.Click += new System.EventHandler(this.btnReportCourseDetails_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(243, 55);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(348, 52);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // lblCourseDesignation
            // 
            this.lblCourseDesignation.AutoSize = true;
            this.lblCourseDesignation.Location = new System.Drawing.Point(243, 107);
            this.lblCourseDesignation.Name = "lblCourseDesignation";
            this.lblCourseDesignation.Size = new System.Drawing.Size(102, 13);
            this.lblCourseDesignation.TabIndex = 2;
            this.lblCourseDesignation.Text = "Course Designation:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(348, 107);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(100, 20);
            this.txtCourseID.TabIndex = 3;
            // 
            // btnReportAllStudents
            // 
            this.btnReportAllStudents.Location = new System.Drawing.Point(40, 143);
            this.btnReportAllStudents.Name = "btnReportAllStudents";
            this.btnReportAllStudents.Size = new System.Drawing.Size(187, 23);
            this.btnReportAllStudents.TabIndex = 1;
            this.btnReportAllStudents.Text = "Report all students";
            this.btnReportAllStudents.UseVisualStyleBackColor = true;
            this.btnReportAllStudents.Click += new System.EventHandler(this.btnReportAllStudents_Click);
            // 
            // btnReportAllCourses
            // 
            this.btnReportAllCourses.Location = new System.Drawing.Point(40, 187);
            this.btnReportAllCourses.Name = "btnReportAllCourses";
            this.btnReportAllCourses.Size = new System.Drawing.Size(187, 23);
            this.btnReportAllCourses.TabIndex = 1;
            this.btnReportAllCourses.Text = "Report all courses";
            this.btnReportAllCourses.UseVisualStyleBackColor = true;
            this.btnReportAllCourses.Click += new System.EventHandler(this.btnReportAllCourses_Click);
            // 
            // GenerateReportInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 239);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblCourseDesignation);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.btnReportAllCourses);
            this.Controls.Add(this.btnReportAllStudents);
            this.Controls.Add(this.btnReportCourseDetails);
            this.Controls.Add(this.btnReportRegistrationStudent);
            this.Name = "GenerateReportInterface";
            this.Text = "GenerateReportInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportRegistrationStudent;
        private System.Windows.Forms.Button btnReportCourseDetails;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblCourseDesignation;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Button btnReportAllStudents;
        private System.Windows.Forms.Button btnReportAllCourses;
    }
}