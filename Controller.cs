namespace ClassManagerApp
{
    public class Controller
    {
        public List<Course> Courses = new List<Course>();
        public void ShowCourseTasks()
        {
            if (!Courses.Any())
            {
                Console.WriteLine("No Courses");
                return;
            }
            foreach (Course c in Courses)
            {
                Console.WriteLine(c.Name);
                c.ShowAllTasks();
            }
        }
        public void AddTask(Task task, Course course)
        {
            if (Courses.Contains(course))
            {
                course.AddTask(task);
                return;
            }
            Console.WriteLine("Course does not exist");
        }
    }
}