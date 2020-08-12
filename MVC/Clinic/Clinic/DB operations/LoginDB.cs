using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clinic.Models;

namespace Clinic.DB_operations
{
    public class LoginDB
    {
        public int AddLogin (Logininfo model)
        {
            using ( var context =  new Hospital_Simulation_DBEntities())
            {
                UserLogin log = new UserLogin()
                {
                    UserName = model.UserName,
                    Password = model.Password,
                    AppoinmetID = model.AppoinmetID
                };

                context.UserLogins.Add(log);

                context.SaveChanges();

                return model.ID;
            }
        }
    }
}