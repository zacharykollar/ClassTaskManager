using System.Linq;
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

		public void SortTasks()
		{
			TaskList.Sort(delegate (Task a, Task b)
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
		}

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