public class Course
{
	

	public Course()
	{
		
	}
	public Course (string n)
    {
		Name = n;
    }
	public string Name { get; set; } = "default";
	public int Priority { get; set; } = 1;
	public List<Task> TaskList = new List<Task>();

	public override string ToString()
    {
		return "Course: " + Name;
    }
	public void AddTask(Task t)
    {
		TaskList.Add(t);
    }
	public void RemoveTask(Task t)
    {
		TaskList.Remove(t);
    }
	public void ShowAllTasks()
    {
		if (!TaskList.Any())
        {
			Console.WriteLine("No Tasks");
			return;
        }
		foreach (Task t in TaskList)
        {
			Console.WriteLine(t);
        }
    }
}
