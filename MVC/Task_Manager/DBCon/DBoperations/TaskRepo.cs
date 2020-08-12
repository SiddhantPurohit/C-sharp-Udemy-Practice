using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerModels;

namespace DBCon.DBoperations
{
    public class TaskRepo
    {
        
        public int AddTask(TaskModel tmodel) //The data is received from the user
        {
            using (var context = new EmployeeDBEntities()) //for connecting database
            {
                Task task = new Task() //create a new instance of class and store data coming from user into it
                {
                    ID = tmodel.ID,
                    Task1 = tmodel.Task1,
                    Duration = tmodel.Duration,
                    Description = tmodel.Description,
                    EmployeeID = tmodel.EmployeeID
                };

                context.Task.Add(task); //adding the data into databse table

                context.SaveChanges(); //saving the changes and data goes to database

                return task.ID;

            }
        }

        public List<TaskModel> GetTask()
        {
            using (var context = new EmployeeDBEntities()) //connection to database
            {
                var result = context.Task   //Query from a table
                    .Select(x => new TaskModel()
                    {
                        ID = x.ID,
                        Task1 = x.Task1,
                        Duration = x.Duration,
                        Description = x.Description,
                        EmployeeID = x.EmployeeID
                    }).ToList();

                return result;
            }

        }

        public bool DeleteTask(int id)
        {
            using (var context = new EmployeeDBEntities())
            {
                var task = context.Task.FirstOrDefault(x => x.ID == id);
                if(task != null)
                {
                    context.Task.Remove(task);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }

        public TaskModel Detail(int id)
        {
            using (var context = new EmployeeDBEntities()) 
            {
                var result = context.Task   
                    .Where(x => x.ID == id) //Selecting a specific entry
                    .Select(x => new TaskModel()
                    {
                        ID = x.ID,
                        Task1 = x.Task1,
                        Duration = x.Duration,
                        Description = x.Description,
                        EmployeeID = x.EmployeeID
                    }).FirstOrDefault();

                return result;
            }

        }
    }
}
