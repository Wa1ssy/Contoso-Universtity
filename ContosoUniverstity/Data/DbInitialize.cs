﻿using ContosoUniverstity.Models;

namespace ContosoUniverstity.Data
{
    public class DbInitialize
    {
        public static void Initialize(SchoolContext context)
        {
            //teeb kindlaks et andmebaas tehakse, või oleks olemas
            context.Database.EnsureCreated();

            //kui õpilaste tabelis juba on õpilasi, väljub funktsioonist
            if (context.Instructors.Any())
            {
                return;
            }
            //objekt õpilastega, mis lisatakse siis, kui õpilasi sisestatud ei ole

            var students = new Student[]
            {
                new Student {FirstMidName="Artur" , LastName="Petrovski",EnrollmentDate=DateTime.Parse("2069-04-20")},
                new Student {FirstMidName="Meredith" , LastName="Alonso",EnrollmentDate=DateTime.Parse("2009-05-21")},
                new Student {FirstMidName="Marko" , LastName="Vasiljev",EnrollmentDate=DateTime.Parse("2007-09-25")},
                new Student {FirstMidName="Allan" , LastName="Lond",EnrollmentDate=DateTime.Parse("2054-12-31")},
                new Student {FirstMidName="James" , LastName="Bond",EnrollmentDate=DateTime.Parse("2007-09-30")},
                new Student {FirstMidName="John" , LastName="Wick",EnrollmentDate=DateTime.Parse("2002-09-25")},
                new Student {FirstMidName="Vasya" , LastName="Pupkin",EnrollmentDate=DateTime.Parse("2021-5-01")},
                new Student {FirstMidName="Caesar" , LastName="Salatov",EnrollmentDate=DateTime.Parse("2012-01-23")},
                new Student {FirstMidName="Playboi" , LastName="Carti",EnrollmentDate=DateTime.Parse("2010-02-07")},
                new Student {FirstMidName="Cristiano" , LastName="Ronaldo",EnrollmentDate=DateTime.Parse("1999-03-16")},
            };

            //iga õpilane lisatakse ükshaaval läbi foreach tsükli
            foreach (Student student in students)
            {
                context.Students.Add(student);
            }
            //ja andmebaasi muudatused salvestatakse
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050, Title="Keemia", Credits=3},
                new Course{CourseID=3212, Title="Inglise Keel",Credits=3},
                new Course{CourseID=4041, Title="Vene Keel",Credits=1},
                new Course{CourseID=1056, Title="Matemaatika",Credits=2},
                new Course{CourseID=7544, Title="Calculus",Credits=2},
                new Course{CourseID=8264, Title="Trigonomeetria",Credits=3},
                new Course{CourseID=7467, Title="Muusika",Credits=3},
                new Course{CourseID=1111, Title="Kirjandus",Credits=4},
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            if(context.Enrollments.Any()) { return; }

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1, CourseID=1050, Grade=Grade.A},
                new Enrollment{StudentID=1, CourseID=3212, Grade=Grade.C},
                new Enrollment{StudentID=1, CourseID=4041, Grade=Grade.B},

                new Enrollment{StudentID=2, CourseID=1056, Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=7544, Grade=Grade.F},
                new Enrollment{StudentID=2, CourseID=7544, Grade=Grade.F},

                new Enrollment{StudentID=3, CourseID=1111},

                new Enrollment{StudentID=4, CourseID=1111},
                new Enrollment{StudentID=4, CourseID=7467, Grade=Grade.F},

                new Enrollment{StudentID=5, CourseID=8264, Grade=Grade.C},

                new Enrollment{StudentID=6, CourseID=1111},

                new Enrollment{StudentID=7, CourseID=1050, Grade=Grade.A},

                new Enrollment{StudentID=10, CourseID=3212, Grade=Grade.A},
            };
            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();

            if (context.Instructors.Any() ) { return; }
            var instructors = new InstructorExists[]
            {
                new InstructorExists
                {
                    LastName = "Guy",
                    FirstMidName = "Shirt",
                    HireDate = DateTime.Parse("2069-04-20"),
                },
                 new InstructorExists
                {
                    LastName = "Guy1",
                    FirstMidName = "Shirt1",
                },
            };
            context.Instructors.AddRange(instructors);
            context.SaveChanges();

            if (context.Departments.Any() ) { return; }
            var departments = new Department[]
            {
                new Department
                {
                    Name = "IT",
                    Budget = 0,
                    StartDate = DateTime.Parse("2024-09-01"),
                    InstructorId = 1,
                    Aadress = "Pae 25",
                },
                new Department
                {
                    Name = "English",
                    Budget = 1000,
                    StartDate = DateTime.Parse("2024-08-02"),
                    InstructorId = 2,
                    Aadress = "Pae 14"
                },
            };
            context.Departments.AddRange(departments);
            context.SaveChanges();
        }
    } 
}
