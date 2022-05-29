public static class Controller
{
	public static List<Course> CourseList = new List<Course>();
	public static void AddCourse(Course c)
    {
        CourseList.Add(c);
    }
    public static void AddCourse()
    {
        Console.WriteLine("Input Course Name");
        string name = Console.ReadLine();
        CourseList.Add(new Course(name));
    }
    public static void RemoveCourse(Course c)
    {
        CourseList.Remove(c);
    }
    public static void ShowCourseTasks()
    {
        if (!CourseList.Any())
        {
            Console.WriteLine("No Courses");
            return;
        }
        foreach (Course c in CourseList)
        {
            Console.WriteLine(c);
            c.ShowAllTasks();
        }
    }
}
