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
        }

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            
        }
    }
}
