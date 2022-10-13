namespace ClassManagerApp
{
    public partial class FormMain : Form
    {
        private Controller controller;
        public FormMain()
        {
            InitializeComponent();
            controller = new Controller();
            controller.Courses.Add(new Course("Math"));
            Task t = new Task("hell0");
            t.Complete = true;
            controller.Courses[0].AddTask(new Task("mostt over", DateTime.Today.AddDays(-2), DateTime.Today.AddDays(1)));
            controller.Courses[0].AddTask(new Task("half", DateTime.Today.AddDays(-10), DateTime.Today.AddDays(10)));
            controller.Courses[0].AddTask(t);
            controller.Courses[0].AddTask(new Task("No Time", DateTime.Today.AddDays(-100), DateTime.Today.AddDays(1)));
            controller.Courses.Add(new Course("English"));
            controller.Courses[1].AddTask(new Task("Word"));
            InitTabs();
            CourseControl.DeleteCourseEvent += DeleteCourse;
        }

        private void DeleteCourse(Course course)
        {
            controller.Courses.Remove(course);
            InitTabs();
        }

        private void InitTabs()
        {
            tabControlCourses.TabPages.Clear();
            for (int i = 0; i < controller.Courses.Count; i++)
            {
                TabPage tb = new (controller.Courses[i].Name)
                {
                    AutoScroll = true
                };
                tabControlCourses.TabPages.Add(tb);
                tabControlCourses.TabPages[i].Controls.Add(new CourseControl(controller.Courses[i]));
            }
        }
        private void AddCourse()
        {
            Tuple<DialogResult, string, DateTime> tuple = Program.InputBox("Add Course", "Input Course Name");
            controller.Courses.Add(new Course(tuple.Item2));
            if (tuple.Item1 != DialogResult.OK || tuple.Item2 == "")
                return;
            InitTabs();
        }

        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse();
        }
    }
}
