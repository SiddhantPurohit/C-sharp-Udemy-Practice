using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using Clinic.Models;

namespace Clinic.DB_operations
{
    public class DiagonosticsDB
    {
        public int AddDiagonostics (DiagonosticsInfo model)
        {
            using (var context = new Hospital_Simulation_DBEntities())
            {
                Diagonostics1 D = new Diagonostics1()
                {
                    UserName = model.UserName,
                    Temperature = model.Temperature,
                    BloodSugar = model.BloodSugar,
                    BloodPressure = model.BloodPressure,
                };

                context.Diagonostics1.Add(D);

                context.SaveChanges();

                return model.ID;
            }
        }
        public DiagonosticsInfo Detail(string UserName)
        {
            using (var context = new Hospital_Simulation_DBEntities())
            {
                var result = context.Diagonostics1
                    .Where(x => x.UserName == UserName) //Selecting a specific entry
                    .Select(x => new DiagonosticsInfo()
                    {
                        ID = x.ID,
                        UserName = x.UserName,
                        Temperature = x.Temperature,
                        BloodSugar = x.BloodSugar,
                        BloodPressure = x.BloodPressure,

                    }).FirstOrDefault();

                return result;
            }

        }
    }
}