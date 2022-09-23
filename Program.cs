// See https://aka.ms/new-console-template for more information
using ClassManagerApp;

Course course = new Course("Math");
Controller.AddCourse(course);
course.AddTask(new Task("first"));
course.AddTask(new Task("second"));
course.AddTask(new Task("third"));
Controller.ShowCourseTasks();
while (true)
{
    string ex = Console.ReadLine();
    switch (ex)
    {
        case "ShowCourseTasks":
            Controller.ShowCourseTasks();
            break;
        case "AddCourse":
            Controller.AddCourse();
            break;
        case "AddTask":
            Controller.AddTask();
            break;
        case "Exit":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Command");
            break;
    }
}