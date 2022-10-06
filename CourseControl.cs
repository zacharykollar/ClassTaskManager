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
            throw new NotImplementedException();
        }

        public void InitDisplay()
        {
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
        }

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            Tuple<DialogResult, string, DateTime> i = InputBox("Add Task", "Add Task");
            Tuple<DialogResult, string, DateTime> InputBox(string title, string message)
            {
                InputBox inputBox = new InputBox(title, message);
                inputBox.ShowDialog();
                return new Tuple<DialogResult, string, DateTime>(inputBox.DialogResult, inputBox.Output, inputBox.Time);
            }
            if (i.Item1 != DialogResult.OK || i.Item2 == "")
                return;
            course.TaskList.Add(new Task(i.Item2, i.Item3));
            InitDisplay();
        }
    }
}
