namespace ClassManagerApp
{
    partial class TaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTaskName = new System.Windows.Forms.Label();
            this.checkBoxComplete = new System.Windows.Forms.CheckBox();
            this.progressBarTimeLeft = new System.Windows.Forms.ProgressBar();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTaskName.Location = new System.Drawing.Point(0, 0);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(90, 28);
            this.labelTaskName.TabIndex = 0;
            this.labelTaskName.Text = "labelTask";
            // 
            // checkBoxComplete
            // 
            this.checkBoxComplete.AutoSize = true;
            this.checkBoxComplete.Location = new System.Drawing.Point(3, 31);
            this.checkBoxComplete.Name = "checkBoxComplete";
            this.checkBoxComplete.Size = new System.Drawing.Size(96, 24);
            this.checkBoxComplete.TabIndex = 1;
            this.checkBoxComplete.Text = "Complete";
            this.checkBoxComplete.UseVisualStyleBackColor = true;
            // 
            // progressBarTimeLeft
            // 
            this.progressBarTimeLeft.Location = new System.Drawing.Point(3, 61);
            this.progressBarTimeLeft.Name = "progressBarTimeLeft";
            this.progressBarTimeLeft.Size = new System.Drawing.Size(244, 36);
            this.progressBarTimeLeft.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTimeLeft.TabIndex = 2;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(105, 31);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(50, 20);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "label1";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(197, 31);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(50, 20);
            this.labelEndDate.TabIndex = 4;
            this.labelEndDate.Text = "label1";
            this.labelEndDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.progressBarTimeLeft);
            this.Controls.Add(this.checkBoxComplete);
            this.Controls.Add(this.labelTaskName);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(250, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTaskName;
        private CheckBox checkBoxComplete;
        private ProgressBar progressBarTimeLeft;
        private Label labelStartDate;
        private Label labelEndDate;
    }
}
