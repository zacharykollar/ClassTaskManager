using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses[0].AddTask(new Task("Problem"));
            controller.Courses.Add(new Course("English"));
            controller.Courses[1].AddTask(new Task("Word"));
            InitTabs();
        }

        private void InitTabs()
        {
            tabControlCourses.TabPages.Clear();
            for (int i = 0; i < controller.Courses.Count; i++)
            {
                TabPage tb = new TabPage(controller.Courses[i].Name)
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
