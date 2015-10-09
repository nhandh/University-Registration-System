namespace URS
{
    partial class SearchCourseInterface
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
            this.lblCourseDesignation = new System.Windows.Forms.Label();
            this.txtCourseDesignation = new System.Windows.Forms.TextBox();
            this.txtSearchOutput = new System.Windows.Forms.TextBox();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseDesignation
            // 
            this.lblCourseDesignation.AutoSize = true;
            this.lblCourseDesignation.Location = new System.Drawing.Point(46, 41);
            this.lblCourseDesignation.Name = "lblCourseDesignation";
            this.lblCourseDesignation.Size = new System.Drawing.Size(124, 13);
            this.lblCourseDesignation.TabIndex = 0;
            this.lblCourseDesignation.Text = "Enter course designation";
            // 
            // txtCourseDesignation
            // 
            this.txtCourseDesignation.Location = new System.Drawing.Point(176, 38);
            this.txtCourseDesignation.Name = "txtCourseDesignation";
            this.txtCourseDesignation.Size = new System.Drawing.Size(100, 20);
            this.txtCourseDesignation.TabIndex = 1;
            // 
            // txtSearchOutput
            // 
            this.txtSearchOutput.Location = new System.Drawing.Point(49, 70);
            this.txtSearchOutput.Multiline = true;
            this.txtSearchOutput.Name = "txtSearchOutput";
            this.txtSearchOutput.ReadOnly = true;
            this.txtSearchOutput.Size = new System.Drawing.Size(345, 267);
            this.txtSearchOutput.TabIndex = 2;
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Location = new System.Drawing.Point(319, 35);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCourse.TabIndex = 3;
            this.btnSearchCourse.Text = "Search";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // SearchCourseInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 384);
            this.Controls.Add(this.btnSearchCourse);
            this.Controls.Add(this.txtSearchOutput);
            this.Controls.Add(this.txtCourseDesignation);
            this.Controls.Add(this.lblCourseDesignation);
            this.Name = "SearchCourseInterface";
            this.Text = "SearchCourseInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseDesignation;
        private System.Windows.Forms.TextBox txtCourseDesignation;
        private System.Windows.Forms.TextBox txtSearchOutput;
        private System.Windows.Forms.Button btnSearchCourse;
    }
}