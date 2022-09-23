namespace ClassManagerApp
{
	public class Task
	{
		public Task()
		{
		}
		public Task(string n)
		{
			Name = n;
		}

		public string Name { get; set; } = "Default";
		public int DueDate { get; private set; } = 0;
		public int Priority { get; set; } = 1;
		public int Difficulty { get; set; } = 10;
		public override string ToString()
		{
			return "Task: " + Name;
		}
	}
}