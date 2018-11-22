using DentalOffice.Models;
using System;
using System.Linq;

namespace DentalOffice.Data
{
    public static class DbInitializer
    {

        public static void Initialize(DentalOfficeDBContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
            new Customer{Firstname="Nilsson",Lastname="Alexander",Street="Gröna gatan 23",Zip="55555",City="Linköping",Phone="173524",Email="nilsson@telia.se",SocialSecurity="80-03-03-9393"}

            };
            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();

            var visits = new Visit[]
            {
            new Visit{visitID=1,customerID=1,dentistID=1,visitDate=DateTime.Parse("2018-10-21"),notes="Fina tänder ..",image1="Tand1.jpg",image2="Tand2.jpg",image3="Tand3.jpg",author="Ingrid Nilsson"}

            };
            foreach (Visit c in visits)
            {
                context.Visit.Add(c);
            }
            context.SaveChanges();

            var dentists = new Dentist[]
            {
            new Dentist{Firstname="Andersson",Lastname="Erik",Street="Norra gatan 56B",Zip="23355",City="Linköping",Phone="131222",Email="andersson@dentalgroup.se",SocialSecurity="73-11-21-2325"}

            };
            foreach (Dentist d in dentists)
            {
                context.Dentist.Add(d);
            }
            context.SaveChanges();

            var logins = new Login[]
            {
            new Login{loginID=1,Username="Erik",Password="Panda",Role="Dentist"}

            };
            foreach (Login l in logins)
            {
                context.Login.Add(l);
            }
            context.SaveChanges();

            var dentistavailables = new DentistAvailable[]
            {
            new DentistAvailable{dentistavailableID=1,dentistID=1,fromDatetime=DateTime.Parse("2018-10-21"),toDatetime=DateTime.Parse("2018-10-21")}

            };
            foreach (DentistAvailable da in dentistavailables)
            {
                context.DentistAvailable.Add(da);
            }
            context.SaveChanges();
        }


    }
}
