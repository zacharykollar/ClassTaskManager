namespace ClassManagerApp
{
    partial class FormMain
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
            this.tabControlCourses = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.tabControlCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCourses
            // 
            this.tabControlCourses.Controls.Add(this.tabPage1);
            this.tabControlCourses.Controls.Add(this.tabPage2);
            this.tabControlCourses.Location = new System.Drawing.Point(12, 47);
            this.tabControlCourses.Name = "tabControlCourses";
            this.tabControlCourses.SelectedIndex = 0;
            this.tabControlCourses.Size = new System.Drawing.Size(300, 455);
            this.tabControlCourses.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(12, 12);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(94, 29);
            this.buttonAddCourse.TabIndex = 1;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.ButtonAddCourse_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(316, 514);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.tabControlCourses);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(334, 561);
            this.MinimumSize = new System.Drawing.Size(334, 561);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tabControlCourses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlCourses;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button buttonAddCourse;
    }
}