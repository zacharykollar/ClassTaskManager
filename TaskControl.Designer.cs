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
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelTaskName);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(148, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTaskName;
    }
}
