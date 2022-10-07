namespace ClassManagerApp
{
	public class Task
	{
        public double TimeLeft
        {
            get { return (DateTime.Now - StartDate)/(DueDate - StartDate); }
        }


        public Task(string n)
		{
			Name = n;
			StartDate = DateTime.Now;
			DueDate = DateTime.Now.AddDays(1);
            Complete = false;
        }

        public Task(string n, DateTime due)
        {
            Name = n;
            StartDate = DateTime.Now;
            DueDate = due;
            Complete = false;
        }
        public Task(string n, DateTime start, DateTime due)
        {
            Name = n;
            StartDate = start;
            DueDate = due;
            Complete = false;
        }

        public bool Complete { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; private set; }
        public DateTime DueDate { get; private set; }
		public override string ToString()
		{
			return "Task: " + Name;
		}
	}
}