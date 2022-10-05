namespace ClassManagerApp
{
	public class Course
	{


		public Course()
		{

		}
		public Course(string n)
		{
			Name = n;
		}
		public string Name { get; set; } = "default";
		public List<Task> TaskList = new();

		public override string ToString()
		{
			return "Course: " + Name;
		}
		public void AddTask(Task t)
		{
			TaskList.Add(t);
		}
	}
}