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
    public partial class InputBox : Form
    {
        public string Output
        {
            get { return textBoxOut.Text; }
        }
        public DateTime Time
        {
            get;
            set;
        }
        public InputBox(string title, string message)
        {
            InitializeComponent();
            labelMessage.Text = message;
            Text = title;
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Time = dateTimePicker1.Value;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
