﻿using System.Linq;
using Abc.Data.Others;
using Abc.Data.People;
using Abc.Domain.Others;

namespace Abc.Infra
{
    public class TrainingDbContentInitializer : DbInitializer
    {
        public static void Initialize(TrainingDbContext db)
        {
            addPersons(db);
            addPersonRoles(db);
            addPersonRoleTypes(db);
            addServices(db);
            addServiceTypes(db);
            addBodyMetricTypes(db);
            addBodyMetrics(db);
            addEquipments(db);
        }


        private static void addEquipments(TrainingDbContext db)
        {
            if (db.Equipments.Any()) return;
            addItem(new EquipmentData()
            {
                AmountInUsing = 1,
                AmountAvailable = 2,

            }, db);
            addItem(new EquipmentData()
            {
                AmountInUsing = 3,
                AmountAvailable = 4,

            }, db);
        }

        private static void addBodyMetrics(TrainingDbContext db)
        {
            if (db.BodyMetrics.Any()) return;
            addItem(new BodyMetricData()
            {
                Value = 60,
                BodyMetricTypeId = "2",
                PersonId = "3"
            }, db);
            addItem(new BodyMetricData()
            {
                Value = 163.5,
                BodyMetricTypeId = "1",
                PersonId = "3"
            }, db);
            addItem(new BodyMetricData()
            {
                Value = 85,
                BodyMetricTypeId = "2",
                PersonId = "2"
            }, db);
            addItem(new BodyMetricData()
            {
                Value = 163.5,
                BodyMetricTypeId = "1",
                PersonId = "2"
            }, db);
            addItem(new BodyMetricData()
            {
                Value = 100,
                BodyMetricTypeId = "2",
                PersonId = "1"
            }, db);
            addItem(new BodyMetricData()
            {
                Value = 193.5,
                BodyMetricTypeId = "1",
                PersonId = "1"
            }, db);
        }

        private static void addBodyMetricTypes(TrainingDbContext db)
        {
            if (db.BodyMetricTypes.Any()) return;
            addItem(new BodyMetricTypeData()
            {
                Id = "1",
                Name = "Height",
                Definition = "cm"
            }, db);
            addItem(new BodyMetricTypeData()
            {
                Id = "2",
                Name = "Weight",
                Definition = "kg"
            }, db);
        }

        private static void addServices(TrainingDbContext db)
        {
            if (db.Services.Any()) return;
            addItem(new ServiceData()
            {
                PersonRoleTypeId = "1",
                ServiceTypeId = "1",
            }, db);
            addItem(new ServiceData()
            {
                PersonRoleTypeId = "1",
                ServiceTypeId = "3",
            }, db);
            addItem(new ServiceData()
            {
                PersonRoleTypeId = "4",
                ServiceTypeId = "5",
            }, db);
        }

        private static void addServiceTypes(TrainingDbContext db)
        {
             if(db.ServiceTypes.Any()) return;
             addItem(new ServiceTypeData()
             {
                 Id = "1",
                 Name = "Personal Training",
                 Code = "T1",
             },db);
             addItem(new ServiceTypeData()
             {
                 Id = "2",
                 Name = "HIIT",
                 Code = "T2",
             }, db);
             addItem(new ServiceTypeData()
             {
                 Id = "3",
                 Name = "Cardio training",
                 Code = "T3",
             }, db);
             addItem(new ServiceTypeData()
             {
                 Id = "4",
                 Name = "Strength training",
                 Code = "T4",
             }, db);
             addItem(new ServiceTypeData()
             {
                 Id = "5",
                 Name = "Massage",
                 Code = "M1",
             }, db);
             addItem(new ServiceTypeData()
             {
                 Id = "6",
                 Name = "Nutrition counseling",
                 Code = "N1",
             }, db);
             addItem(new ServiceTypeData()
             {
                 Id = "7",
                 Name = "Taping and splinting",
                 Code = "P1",
             }, db);
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
            addItem(new PersonData()
            {
                Id = "4",
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
            addItem(new PersonRoleData()
            {
                PersonId = "3",
                PersonRoleTypeId = "5"
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
