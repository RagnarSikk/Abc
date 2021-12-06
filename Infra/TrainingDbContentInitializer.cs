using System.Linq;
using Abc.Data.People;

namespace Abc.Infra
{
    public class TrainingDbContentInitializer : DbInitializer
    {
        public static void Initialize(TrainingDbContext db)
        {
            addPersons(db);
            addPersonRoles(db);
            addPersonRoleTypes(db);
        }

        private static void addPersons(TrainingDbContext db)
        {
            if (db.Persons.Any()) return;
            
            addItem(new PersonData()
            {
                Id = "1",
                FirstMidName = "Carson",
                LastName = "Alexander",
                Email = "carson.alexander@gmail.com",
                PhoneNumber = "554433212",
                Gender = "Male"
            }, db);

            addItem(new PersonData()
            {
                Id = "2",
                FirstMidName = "Allan",
                LastName = "Rivers",
                Email = "allan.rivers@gmail.com",
                PhoneNumber = "54897611",
                Gender = "Male"
            }, db);

            addItem(new PersonData()
            {
                Id = "3",
                FirstMidName = "Amy",
                LastName = "Hale",
                Email = "amy.hale@gmail.com",
                PhoneNumber = "54321123",
                Gender = "Female"
            }, db);
        }
        private static void addPersonRoles(TrainingDbContext db)
        {
            if(db.PersonRoles.Any()) return;
            addItem(new PersonRoleData()
            {
                PersonId = "1",
                PersonRoleTypeId = "1",
                Certificate = "Coach"
            }, db);

            addItem(new PersonRoleData()
            {
                PersonId = "2",
                PersonRoleTypeId = "1",
                Certificate = "Coach"
            }, db);
        }
        private static void addPersonRoleTypes(TrainingDbContext db)
        {
            if (db.PersonRoleTypes.Any()) return;
            addItem(new PersonRoleTypeData()
            {
                Id = "1",
                Name = "Coach",
                Code = "C1"
            }, db);

            addItem(new PersonRoleTypeData()
            {
                Id = "2",
                Name = "Nutritionist",
                Code = "N1"
            }, db);

            addItem(new PersonRoleTypeData()
            {
                Id = "3",
                Name = "Therapist",
                Code = "T1"
            }, db);

            addItem(new PersonRoleTypeData()
            {
                Id = "4",
                Name = "Physiotherapist",
                Code = "P1"
            }, db);

            addItem(new PersonRoleTypeData()
            {
                Id = "5",
                Name = "Athlete",
                Code = "A1"
            }, db);

            addItem(new PersonRoleTypeData()
            {
                Id = "6",
                Name = "Administrator",
                Code = "A2"
            }, db);
        }
    }
}
