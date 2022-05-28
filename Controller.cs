public static class Controller
{
	public static List<Course> CourseList = new List<Course>();
	public static void AddCourse(Course c)
    {
        CourseList.Add(c);
    }
    public static void RemoveCourse(Course c)
    {
        CourseList.Remove(c);
    }
}
