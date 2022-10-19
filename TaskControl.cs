namespace ClassManagerApp
{
    public partial class TaskControl : UserControl, IClassManagerControl
    {
        private Task task;
        public TaskControl(Task t)
        {
            task = t;
            InitializeComponent();
            InitDisplay();
        }
        public TaskControl(Task t, DateTime date)
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
            checkBoxComplete.Checked = task.Complete;
            progressBarTimeLeft.Maximum = (int)(task.DueDate - task.StartDate).TotalHours;
            progressBarTimeLeft.Value = (int)(DateTime.Now - task.StartDate).TotalHours;
            labelStartDate.Text = task.StartDate.ToShortDateString();
            labelEndDate.Text = task.DueDate.ToShortDateString();

        }

    }
}
