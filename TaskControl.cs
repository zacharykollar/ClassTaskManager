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
    public partial class TaskControl : UserControl, IClassManagerControl
    {
        Task task;
        public TaskControl(Task t)
        {
            task = t;
            InitializeComponent();
            InitDisplay();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void InitDisplay()
        {
            labelTaskName.Text = task.Name;
        }

    }
}
