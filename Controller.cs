namespace ClassManagerApp
{
    public static class Controller
    {
        public static List<Course> CourseList = new List<Course>();
        static Dictionary<string, Course> CourseDict = new Dictionary<string, Course>();
        public static void AddCourse(Course c)
        {
            CourseDict.Add(c.Name, c);
        }
        public static void AddCourse()
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
                CourseDict.Add(name, new Course(name));
            }
            catch
            {
                Console.WriteLine("Course Name Already Taken");
            }
        }
        public static void RemoveCourse(Course c)
        {
            CourseList.Remove(c);
        }
        public static void ShowCourseTasks()
        {
            if (!CourseDict.Any())
            {
                Console.WriteLine("No Courses");
                return;
            }
            foreach (KeyValuePair<string, Course> c in CourseDict)
            {
                Console.WriteLine(c.Key);
                c.Value.ShowAllTasks();
            }
        }
        public static void AddTask()
        {
            Console.WriteLine("Input Course Name");
            string c = Console.ReadLine();
            Console.WriteLine("Input Task Name");
            string t = Console.ReadLine();
            AddTask(t, c);
        }
        public static void AddTask(Task task, string course)
        {
            if (CourseDict.ContainsKey(course))
            {
                Course? c = null;
                CourseDict.TryGetValue(course, out c);
                c.AddTask(task);
                return;
            }
            Console.WriteLine("Course does not exist");
        }
        public static void AddTask(string task, string course)
        {
            if (CourseDict.ContainsKey(course))
            {
                Console.WriteLine(CourseDict[course]);
                CourseDict[course].AddTask(new Task(task));
                return;
            }
            Console.WriteLine("Course does not exist");
        }
    }
}