// See https://aka.ms/new-console-template for more information
Course course = new Course("Math");
Controller.CourseList.Add(course);
course.AddTask(new Task("first"));
course.AddTask(new Task("second"));
course.AddTask(new Task("third"));
foreach(Course c in Controller.CourseList)
{
    Console.WriteLine(c);
    foreach(Task t in c.TaskList)
    {
        Console.WriteLine(t);
    }
}