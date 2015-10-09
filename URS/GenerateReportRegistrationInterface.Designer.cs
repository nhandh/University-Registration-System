namespace URS
{
    partial class GenerateReportRegistrationInterface
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
            this.lblChooseSemester = new System.Windows.Forms.Label();
            this.cbbSemesterSelector = new System.Windows.Forms.ComboBox();
            this.btnGenerateReportRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseSemester
            // 
            this.lblChooseSemester.AutoSize = true;
            this.lblChooseSemester.Location = new System.Drawing.Point(43, 38);
            this.lblChooseSemester.Name = "lblChooseSemester";
            this.lblChooseSemester.Size = new System.Drawing.Size(91, 13);
            this.lblChooseSemester.TabIndex = 0;
            this.lblChooseSemester.Text = "Choose semester:";
            // 
            // cbbSemesterSelector
            // 
            this.cbbSemesterSelector.FormattingEnabled = true;
            this.cbbSemesterSelector.Location = new System.Drawing.Point(176, 29);
            this.cbbSemesterSelector.Name = "cbbSemesterSelector";
            this.cbbSemesterSelector.Size = new System.Drawing.Size(121, 21);
            this.cbbSemesterSelector.TabIndex = 1;
            // 
            // btnGenerateReportRegistration
            // 
            this.btnGenerateReportRegistration.Location = new System.Drawing.Point(46, 76);
            this.btnGenerateReportRegistration.Name = "btnGenerateReportRegistration";
            this.btnGenerateReportRegistration.Size = new System.Drawing.Size(251, 23);
            this.btnGenerateReportRegistration.TabIndex = 2;
            this.btnGenerateReportRegistration.Text = "Generate Registration Card";
            this.btnGenerateReportRegistration.UseVisualStyleBackColor = true;
            this.btnGenerateReportRegistration.Click += new System.EventHandler(this.btnGenerateReportRegistration_Click);
            // 
            // GenerateReportRegistrationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 126);
            this.Controls.Add(this.btnGenerateReportRegistration);
            this.Controls.Add(this.cbbSemesterSelector);
            this.Controls.Add(this.lblChooseSemester);
            this.Name = "GenerateReportRegistrationInterface";
            this.Text = "GenerateReportRegistrationInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseSemester;
        private System.Windows.Forms.ComboBox cbbSemesterSelector;
        private System.Windows.Forms.Button btnGenerateReportRegistration;
    }
}