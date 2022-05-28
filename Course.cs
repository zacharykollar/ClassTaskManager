using System;

public class Course
{
	

	public Course()
	{
	}
	public Course (int prior)
    {
		Priority = prior;
    }
	public int Priority { get; set; }
	public List<Task> TaskList = new List<Task>();
}
