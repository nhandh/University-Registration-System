namespace URS
{
    partial class ViewCourseInterface
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
            this.btnDropCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseList = new System.Windows.Forms.TextBox();
            this.btnViewEnrollement = new System.Windows.Forms.Button();
            this.cbbCourseSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDropCourse
            // 
            this.btnDropCourse.Location = new System.Drawing.Point(351, 204);
            this.btnDropCourse.Name = "btnDropCourse";
            this.btnDropCourse.Size = new System.Drawing.Size(75, 23);
            this.btnDropCourse.TabIndex = 0;
            this.btnDropCourse.Text = "Drop Course";
            this.btnDropCourse.UseVisualStyleBackColor = true;
            this.btnDropCourse.Click += new System.EventHandler(this.btnDropCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here is the list of your current courses";
            // 
            // txtCourseList
            // 
            this.txtCourseList.Location = new System.Drawing.Point(27, 57);
            this.txtCourseList.Multiline = true;
            this.txtCourseList.Name = "txtCourseList";
            this.txtCourseList.ReadOnly = true;
            this.txtCourseList.Size = new System.Drawing.Size(399, 141);
            this.txtCourseList.TabIndex = 2;
            // 
            // btnViewEnrollement
            // 
            this.btnViewEnrollement.Location = new System.Drawing.Point(27, 203);
            this.btnViewEnrollement.Name = "btnViewEnrollement";
            this.btnViewEnrollement.Size = new System.Drawing.Size(170, 23);
            this.btnViewEnrollement.TabIndex = 3;
            this.btnViewEnrollement.Text = "View Enrollment Information";
            this.btnViewEnrollement.UseVisualStyleBackColor = true;
            this.btnViewEnrollement.Click += new System.EventHandler(this.btnViewEnrollement_Click);
            // 
            // cbbCourseSelector
            // 
            this.cbbCourseSelector.FormattingEnabled = true;
            this.cbbCourseSelector.Location = new System.Drawing.Point(204, 205);
            this.cbbCourseSelector.Name = "cbbCourseSelector";
            this.cbbCourseSelector.Size = new System.Drawing.Size(121, 21);
            this.cbbCourseSelector.TabIndex = 4;
            // 
            // ViewCourseInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 258);
            this.Controls.Add(this.cbbCourseSelector);
            this.Controls.Add(this.btnViewEnrollement);
            this.Controls.Add(this.txtCourseList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDropCourse);
            this.Name = "ViewCourseInterface";
            this.Text = "ViewCourseInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDropCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseList;
        private System.Windows.Forms.Button btnViewEnrollement;
        private System.Windows.Forms.ComboBox cbbCourseSelector;
    }
}