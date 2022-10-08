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
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TaskControl))
                    Controls.Remove(c);
            }
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
