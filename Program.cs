// See https://aka.ms/new-console-template for more information
Console.WriteLine("HI");
Course course = new Course("Math");
Controller.CourseList.Add(course);
course.TaskList.Add(new Task("first"));
course.TaskList.Add(new Task("second"));
course.TaskList.Add(new Task("third"));
foreach(Course c in Controller.CourseList)
{
    Console.WriteLine(c);
    foreach(Task t in c.TaskList)
    {
        Console.WriteLine(t);
    }
}