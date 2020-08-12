using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clinic.Models;

namespace Clinic.DB_operations
{
    public class AppoinmentDB
    {
        public int AddAppoinment(AppoinmentInfo model)
        {
            using (var context = new Hospital_Simulation_DBEntities())
            {
                Appoinment2 ap = new Appoinment2()
                {
                    UserName = model.UserName,
                    ReportedIssue = model.ReportedIsuue,
                    DateOfAppoinment = model.DateOfAppoinment
                };

                context.Appoinment2.Add(ap);

                context.SaveChanges();

                return model.ID;
            }
        }

        public List<AppoinmentInfo> GetAppoinment()
        {
            using (var context = new Hospital_Simulation_DBEntities()) //connection to database
            {
                var result = context.Appoinment2 //Query from a table
                    .Select(x => new AppoinmentInfo()
                    {
                        ID = x.ID,
                        UserName = x.UserName,
                        ReportedIsuue = x.ReportedIssue,
                        DateOfAppoinment = x.DateOfAppoinment
                    }).ToList();

                return result;
            }

        }

        public bool DeleteAppoinment(int id)
        {
            using (var context = new Hospital_Simulation_DBEntities())
            {
                var task = context.Appoinment2.FirstOrDefault(x => x.ID == id);
                if (task != null)
                {
                    context.Appoinment2.Remove(task);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public AppoinmentInfo Detail(int id)
        {
            using (var context = new Hospital_Simulation_DBEntities())
            {
                var result = context.Appoinment2
                    .Where(x => x.ID == id) //Selecting a specific entry
                    .Select(x => new AppoinmentInfo()
                    {
                        ID = x.ID,
                        UserName = x.UserName,
                        ReportedIsuue = x.ReportedIssue,
                        DateOfAppoinment = x.DateOfAppoinment
                    }).FirstOrDefault();

                return result;
            }

        }

        public bool Edit(int id , AppoinmentInfo model)
        {
            using (var context = new Hospital_Simulation_DBEntities())
            {
                var Appoinment = context.Appoinment2.FirstOrDefault(x => x.ID == id);

                if (Appoinment != null)
                {
                    Appoinment.UserName = model.UserName;
                    Appoinment.ReportedIssue = model.ReportedIsuue;
                    Appoinment.DateOfAppoinment = model.DateOfAppoinment;
                }

                context.SaveChanges();

                return true;
            }
        }
    }
}