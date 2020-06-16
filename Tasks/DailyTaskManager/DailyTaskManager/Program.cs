using System;
using System.Collections.Generic;

namespace DailyTaskManager
{
    public class Task
    {
        public string NameOfTask { get; set; }
        public int HoursSpent { get; set; }
        public string Description { get; set; }

        public DateTime TimeOfReport;

        public Task(string nameOFTask, int hourSpent, string description)
        {
            this.Description = description;
            this.HoursSpent = hourSpent;
            this.Description = description;
            TimeOfReport = DateTime.Now;
        }
    }

    public class TaskManagement
    {
        public string AdminPassword = "GETTASKRESULTS"; 

        public List<Task> TaskRecord = new List<Task>();

        public void AddTask(string nameOFTask, int hourSpent, string description)
        {
            var task = new Task(nameOFTask, hourSpent, description);
            TaskRecord.Add(task);
        }
        public void GetTaskResult()
        {
            var report = new System.Text.StringBuilder(); //This is used to create a mutable string.
            report.AppendLine("Task\t\tTimespent\t\tNote");
            foreach (var t in TaskRecord)
            {
                report.AppendLine($"{t.NameOfTask}\t{t.HoursSpent}\t{t.Description}");
            }
            Console.WriteLine(report);
        }       
    }
    class Program
    {
        static void Main(string[] args)
        {
            var taskmanagement = new TaskManagement();

            bool conti = true;

            while(conti)
            {
                Console.WriteLine("Hello Are You Admin or User" +
                "Press 1 to select User" +
                "Press 2 to select Admin" +
                "Press 3 to exit application");

                var selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                    label1:
                        Console.WriteLine("Hello User Provide details to report your Task");
                        Console.WriteLine("Enter the Task Name you want to report");
                        string nameoftask = Console.ReadLine();
                        Console.WriteLine("Enter the number of hours spent on this task");
                        int hoursspent = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the description on the work");
                        string DEScription = Console.ReadLine();

                        taskmanagement.AddTask(nameoftask, hoursspent, DEScription);

                        Console.WriteLine("Task Added Sucessfully");

                        Console.WriteLine("Do you want to add another Task" +
                            "Enter 1 for yes & 2 for no");
                        int Moretask = Convert.ToInt32(Console.ReadLine());
                        if (Moretask == 1)
                        { 
                            goto label1;
                        }
                        else
                            Console.WriteLine("Have a nice day!!");
                        break;

                    case 2:
                        Console.WriteLine("Hello admin please provide your password");
                        string password = Console.ReadLine();
                        if (password == taskmanagement.AdminPassword)
                        {
                            Console.WriteLine("Welcome here is the list of all the tasks of the users");
                            taskmanagement.GetTaskResult();
                        }
                        else
                        {
                            Console.WriteLine("Your Password is Incorrect");
                        }
                        break;

                    case 3:
                        conti = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }           
        }
    }
}
