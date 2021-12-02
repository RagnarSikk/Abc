using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Data.People;

namespace Abc.Infra
{
    public class TrainingDbContentInitializer : DbInitializer
    {
        public static void Initialize(TrainingDbContext db)
        {
            addPersons(db);
        }

        private static void addPersons(TrainingDbContext db)
        {
            if (db.Persons.Any()) return;

            var persons = new PersonData[] {
                new() {
                    FirstMidName = "Carson", LastName = "Alexander", Email = "carson.alexander@gmail.com", PhoneNumber = "554433212"
                },
            };

            db.Persons.AddRange(persons);
            db.SaveChanges();
        }
    }
}
