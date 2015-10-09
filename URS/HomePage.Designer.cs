namespace URS
{
    partial class HomePage
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
            this.btnGenerateRegistrationCard = new System.Windows.Forms.Button();
            this.btnRegisterCourse = new System.Windows.Forms.Button();
            this.btnViewDropCourse = new System.Windows.Forms.Button();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateRegistrationCard
            // 
            this.btnGenerateRegistrationCard.Location = new System.Drawing.Point(72, 183);
            this.btnGenerateRegistrationCard.Name = "btnGenerateRegistrationCard";
            this.btnGenerateRegistrationCard.Size = new System.Drawing.Size(168, 23);
            this.btnGenerateRegistrationCard.TabIndex = 0;
            this.btnGenerateRegistrationCard.Text = "Generate Your Registration Card";
            this.btnGenerateRegistrationCard.UseVisualStyleBackColor = true;
            this.btnGenerateRegistrationCard.Click += new System.EventHandler(this.btnGenerateRegistrationCard_Click);
            // 
            // btnRegisterCourse
            // 
            this.btnRegisterCourse.Location = new System.Drawing.Point(72, 88);
            this.btnRegisterCourse.Name = "btnRegisterCourse";
            this.btnRegisterCourse.Size = new System.Drawing.Size(168, 23);
            this.btnRegisterCourse.TabIndex = 1;
            this.btnRegisterCourse.Text = "Register for a course";
            this.btnRegisterCourse.UseVisualStyleBackColor = true;
            this.btnRegisterCourse.Click += new System.EventHandler(this.btnRegisterCourse_Click);
            // 
            // btnViewDropCourse
            // 
            this.btnViewDropCourse.Location = new System.Drawing.Point(72, 134);
            this.btnViewDropCourse.Name = "btnViewDropCourse";
            this.btnViewDropCourse.Size = new System.Drawing.Size(168, 23);
            this.btnViewDropCourse.TabIndex = 2;
            this.btnViewDropCourse.Text = "View / Drop Course registered";
            this.btnViewDropCourse.UseVisualStyleBackColor = true;
            this.btnViewDropCourse.Click += new System.EventHandler(this.btnViewDropCourse_Click);
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Location = new System.Drawing.Point(72, 44);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(168, 23);
            this.btnSearchCourse.TabIndex = 3;
            this.btnSearchCourse.Text = "Search for a course";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 275);
            this.Controls.Add(this.btnSearchCourse);
            this.Controls.Add(this.btnViewDropCourse);
            this.Controls.Add(this.btnRegisterCourse);
            this.Controls.Add(this.btnGenerateRegistrationCard);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateRegistrationCard;
        private System.Windows.Forms.Button btnRegisterCourse;
        private System.Windows.Forms.Button btnViewDropCourse;
        private System.Windows.Forms.Button btnSearchCourse;
    }
}