using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerModels;

namespace DBCon.DBoperations
{
    public class ManagerRepo
    {
        public int AddManager (ManagerModel model)
        {
            using ( var context = new ManagerDBEntities())
            {
                Manager man = new Manager()
                {
                    ID = model.ID,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    EmployeeID = model.EmployeeID
                };

                context.Managers.Add(man);
                context.SaveChanges();

                return man.ID;
            }
        }
    }
}
