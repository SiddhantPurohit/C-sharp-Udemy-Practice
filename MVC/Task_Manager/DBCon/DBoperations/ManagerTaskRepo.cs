using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerModels;

namespace DBCon.DBoperations
{
    public class ManagerTaskRepo
    {
        public int AddTask(ManagerTaskModel model)
        {
            using (var context = new ManagerDBEntities())
            {
                MangerTask Mtask = new MangerTask()
                {
                    ID = model.ID,
                    Task = model.Task,
                    Duration = model.Duration,
                    Description = model.Description,
                    EmployeeID = model.EmployeeID
                };

                context.MangerTasks.Add(Mtask);
                context.SaveChanges();

                return Mtask.ID;
            }
        }

        public List<ManagerTaskModel> GetManagerTask()
        {
            using(var context = new ManagerDBEntities())
            {
                var result = context.MangerTasks
                    .Select( mt => new ManagerTaskModel()
                    {
                        ID = mt.ID,
                        Task = mt.Task,
                        Duration = mt.Duration,
                        Description = mt.Description,
                        EmployeeID = mt.EmployeeID
                    }).ToList();

                return result;

            }
        }
    }   
}
