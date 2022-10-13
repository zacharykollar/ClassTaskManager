using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManagerApp
{
    public partial class ControllerControl : UserControl, IClassManagerControl
    {
        private Controller controller;
        public ControllerControl(Controller c)
        {
            controller = c;
            InitializeComponent();
        }

        public void Delete()
        {
            
        }

        public void InitDisplay()
        {
            Label labelName = new Label();
            // 
            // labelClassName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(150, 32);
            labelName.TabIndex = 0;
            labelName.Text = "Task List";

            List<Task> tasks = new();

            foreach (Course course in controller.Courses)
            {
                foreach(Task task in course.TaskList)
                {
                    tasks.Add(task);
                }
            }
            
            tasks.Sort(delegate (Task a, Task b)
            {
                if (a.Complete && b.Complete)
                    return a.Name.CompareTo(b.Name);
                else if (a.Complete)
                    return 1;
                else if (b.Complete)
                    return -1;
                else
                    return a.TimeLeft.CompareTo(b.TimeLeft);
            });
            int offset = labelName.Height;
            foreach(Task t in tasks)
            {
                TaskControl ctrl = new TaskControl(t)
                {
                    Location = new Point(0, offset),
                };
                Controls.Add(ctrl);
                offset += ctrl.Height;
            }
        }
    }
}
