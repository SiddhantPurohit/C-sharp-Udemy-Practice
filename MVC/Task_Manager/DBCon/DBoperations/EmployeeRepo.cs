using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerModels;

namespace DBCon.DBoperations
{
    public class EmployeeRepo
    {
        public int AddEmployee(EmployeeModel model)
        {
            using (var context = new EmployeeDBEntities()) 
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    EmployeeID = model.EmployeeID
                };

                context.Employee.Add(emp);
                context.SaveChanges();

                return emp.ID;

            }
        }
    }
}
