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
            InitTabs();
        }

        private void InitTabs()
        {
            tabControlCourses.TabPages.Clear();
            for (int i = 0; i < controller.Courses.Count; i++)
            {
                tabControlCourses.TabPages.Add(controller.Courses[i].Name);
                tabControlCourses.TabPages[i].Controls.Add(new CourseControl(controller.Courses[i]));
            }
        }
    }
}
