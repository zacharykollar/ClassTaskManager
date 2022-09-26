namespace ClassManagerApp
{
    public class Controller
    {
        private List<Course> Courses = new List<Course>();
        public void AddCourse(Course course)
        {
            Courses.Append(course);
        }
        public void AddCourse()
        {
            Console.WriteLine("Input Course Name");
            string? name = Console.ReadLine();
            while (name == null)
            {
                Console.WriteLine("Please Input a Course Name");
                name = Console.ReadLine();
            }
            try
            {
                Courses.Append(new Course(name));
            }
            catch
            {
                Console.WriteLine("Course Name Already Taken");
            }
        }
        public void RemoveCourse(Course course)
        {
            Courses.Remove(course);
        }
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