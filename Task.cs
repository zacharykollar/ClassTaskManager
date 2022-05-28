using System;

public class Task
{
	public Task()
	{
	}
	public Task(string n)
	{
		Name = n;
	}
	public string Name { get; set; }
	public int DueDate { get; private set; }
	public int Priority { get; set; }
	public int Difficulty { get; set; }
	public void TickDay()
	{
		
	}
}
