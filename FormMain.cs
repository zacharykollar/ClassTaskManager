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
            controller.Courses.Add(new Course("Hi"));
            controller.Courses.Add(new Course("bye"));
            InitTabs();
        }

        private void InitTabs()
        {
            tabControlCourses.TabPages.Clear();
            foreach (Course c in controller.Courses)
            {
                tabControlCourses.TabPages.Add(c.Name);
            }
        }
    }
}
