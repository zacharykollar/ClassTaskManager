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
    public partial class CourseControl : UserControl
    {
        private Course course;
        public CourseControl(Course c)
        {
            Course = c;
            InitializeComponent();
        }

        public Course Course { get => course; set => course = value; }
    }
}
