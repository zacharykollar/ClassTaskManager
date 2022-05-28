// See https://aka.ms/new-console-template for more information
Console.WriteLine("HI");
Course course = new Course();
course.TaskList.Add(new Task("first"));
course.TaskList.Add(new Task("second"));
course.TaskList.Add(new Task("third"));  
foreach(Task t in course.TaskList)
{
    Console.WriteLine(t.Name);
}