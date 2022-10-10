using System.Diagnostics;

namespace ClassManagerApp
{
    public partial class CourseControl : UserControl, IClassManagerControl
    {
        private Course course;
        public CourseControl(Course c)
        {
            course = c;
            InitializeComponent();
            InitDisplay();
        }

        public Course Course { get => course; set => course = value; }

        public void Delete()
        {
            DeleteCourseEvent.Invoke(course);
        }

        public void InitDisplay()
        {
            course.SortTasks();
            Controls.Clear();
            labelClassName = new System.Windows.Forms.Label();
            buttonAddTask = new System.Windows.Forms.Button();
            buttonDeleteCourse = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelClassName
            // 
            labelClassName.AutoSize = true;
            labelClassName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelClassName.Location = new System.Drawing.Point(0, 0);
            labelClassName.Name = "labelClassName";
            labelClassName.Size = new System.Drawing.Size(150, 32);
            labelClassName.TabIndex = 0;
            labelClassName.Text = "labelClassName";
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new System.Drawing.Point(labelClassName.Width, 0);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new System.Drawing.Size(75, 25);
            buttonAddTask.TabIndex = 1;
            buttonAddTask.Text = "Add Task";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // buttonDeleteCourse
            // 
            buttonDeleteCourse.Location = new System.Drawing.Point(150, 0);
            buttonDeleteCourse.Name = "buttonDeleteCourse";
            buttonDeleteCourse.Size = new System.Drawing.Size(75, 25);
            buttonDeleteCourse.TabIndex = 2;
            buttonDeleteCourse.Text = "Delete Course";
            buttonDeleteCourse.UseVisualStyleBackColor = true;
            buttonDeleteCourse.Click += new System.EventHandler(this.ButtonDeleteCourse_Click);

            Controls.Add(this.buttonDeleteCourse);
            Controls.Add(this.buttonAddTask);
            Controls.Add(this.labelClassName);

            ResumeLayout(false);
            PerformLayout();
            labelClassName.Text = Course.Name;
            int offset = labelClassName.Height;
            foreach (Task t in Course.TaskList)
            {
                TaskControl ctrl = new TaskControl(t)
                {
                    Location = new Point(0, offset),
                };
                Controls.Add(ctrl);
                offset += ctrl.Height;
            }
            buttonAddTask.Location = new Point(labelClassName.Width + 10, 0);
            Invalidate();
        }

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            Tuple<DialogResult, string, DateTime> i = Program.InputBox("Add Task", "Add Task");
            
            if (i.Item1 != DialogResult.OK || i.Item2 == "" || i.Item3.CompareTo(DateTime.Now) <= 0)
                return;
            course.TaskList.Add(new Task(i.Item2, i.Item3));
            InitDisplay();
        }

        public delegate void DeleteCourse(Course course);
        public static event DeleteCourse DeleteCourseEvent;
        private void ButtonDeleteCourse_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
