namespace URS
{
    partial class DropCourseInterface
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
            this.lblCourseSelect = new System.Windows.Forms.Label();
            this.btnDropCourse = new System.Windows.Forms.Button();
            this.cbbCourseSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCourseSelect
            // 
            this.lblCourseSelect.AutoSize = true;
            this.lblCourseSelect.Location = new System.Drawing.Point(43, 28);
            this.lblCourseSelect.Name = "lblCourseSelect";
            this.lblCourseSelect.Size = new System.Drawing.Size(115, 13);
            this.lblCourseSelect.TabIndex = 0;
            this.lblCourseSelect.Text = "Select a course below:";
            // 
            // btnDropCourse
            // 
            this.btnDropCourse.Location = new System.Drawing.Point(46, 98);
            this.btnDropCourse.Name = "btnDropCourse";
            this.btnDropCourse.Size = new System.Drawing.Size(138, 23);
            this.btnDropCourse.TabIndex = 2;
            this.btnDropCourse.Text = "Drop this course";
            this.btnDropCourse.UseVisualStyleBackColor = true;
            this.btnDropCourse.Click += new System.EventHandler(this.btnDropCourse_Click);
            // 
            // cbbCourseSelector
            // 
            this.cbbCourseSelector.FormattingEnabled = true;
            this.cbbCourseSelector.Location = new System.Drawing.Point(46, 58);
            this.cbbCourseSelector.Name = "cbbCourseSelector";
            this.cbbCourseSelector.Size = new System.Drawing.Size(121, 21);
            this.cbbCourseSelector.TabIndex = 3;
            // 
            // DropCourseInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 156);
            this.Controls.Add(this.cbbCourseSelector);
            this.Controls.Add(this.btnDropCourse);
            this.Controls.Add(this.lblCourseSelect);
            this.Name = "DropCourseInterface";
            this.Text = "DropCourseInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseSelect;
        private System.Windows.Forms.Button btnDropCourse;
        private System.Windows.Forms.ComboBox cbbCourseSelector;
    }
}