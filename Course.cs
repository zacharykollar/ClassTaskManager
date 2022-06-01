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
	public Dictionary<string, Task> TaskDict = new Dictionary<string, Task>();

	public override string ToString()
    {
		return "Course: " + Name;
    }
	public void AddTask(Task t)
    {
        TaskDict.Add(t.Name, t);
    }
	public void AddTask(string t)
    {
		AddTask(new Task(t));
    }
	public void RemoveTask(Task t)
    {
		TaskDict.Remove(t.Name);
    }
	public void ShowAllTasks()
    {
		foreach (KeyValuePair<string, Task> t in TaskDict)
        {
			Console.WriteLine(t.Value);
        }
    }
}
