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
            foreach (Task t in Course.TaskList)
            {
                Controls.Add(new TaskControl(t));   
            }
        }
    }
}
