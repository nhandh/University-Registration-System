namespace URS
{
    partial class RegisterCourseInterFace
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
            this.btnRegisterCourse = new System.Windows.Forms.Button();
            this.cbbCourseSelector = new System.Windows.Forms.ComboBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterCourse
            // 
            this.btnRegisterCourse.Location = new System.Drawing.Point(45, 112);
            this.btnRegisterCourse.Name = "btnRegisterCourse";
            this.btnRegisterCourse.Size = new System.Drawing.Size(154, 23);
            this.btnRegisterCourse.TabIndex = 4;
            this.btnRegisterCourse.Text = "Register for this course";
            this.btnRegisterCourse.UseVisualStyleBackColor = true;
            this.btnRegisterCourse.Click += new System.EventHandler(this.btnRegisterCourse_Click);
            // 
            // cbbCourseSelector
            // 
            this.cbbCourseSelector.FormattingEnabled = true;
            this.cbbCourseSelector.Location = new System.Drawing.Point(45, 72);
            this.cbbCourseSelector.Name = "cbbCourseSelector";
            this.cbbCourseSelector.Size = new System.Drawing.Size(154, 21);
            this.cbbCourseSelector.TabIndex = 5;
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Location = new System.Drawing.Point(42, 32);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(115, 13);
            this.lblSelectCourse.TabIndex = 6;
            this.lblSelectCourse.Text = "Select a course below:";
            // 
            // RegisterCourseInterFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 182);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.cbbCourseSelector);
            this.Controls.Add(this.btnRegisterCourse);
            this.Name = "RegisterCourseInterFace";
            this.Text = "RegisterCourseInterFace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterCourse;
        private System.Windows.Forms.ComboBox cbbCourseSelector;
        private System.Windows.Forms.Label lblSelectCourse;
    }
}