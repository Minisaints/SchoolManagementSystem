namespace SchoolManagementSystem.Migrations
{
    using SchoolManagementSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolManagementSystem.Data.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolManagementSystem.Data.SchoolContext context)
        {
            context.Pupils.AddOrUpdate(
                p => p.id,
                   new Pupil
                   {
                       FirstName = "Craig",
                       LastName = "Taylor",
                       Age = 25,
                       Telephone = "07769351018",
                       Year = 11,
                       Classid = 1,
                       id = 0,
                       Grade = "A+",
                       AddedBy = "Admin",
                       AddedDate = DateTime.Now
                   },
                   new Pupil
                   {
                       FirstName = "Natasha",
                       LastName = "Ferguson",
                       Age = 22,
                       Telephone = "07865481018",
                       Year = 1,
                       Classid = 2,
                       id = 1,
                       Grade = "F+",
                       AddedBy = "Admin",
                       AddedDate = DateTime.Now
                   },

                   new Pupil
                   {
                       FirstName = "Novah",
                       LastName = "Taylor",
                       Age = 3,
                       Telephone = "07788558855",
                       Year = 4,
                       Classid = 2,
                       id = 2,
                       Grade = "C+",
                       AddedBy = "Admin",
                       AddedDate = DateTime.Now
                   }

                   );

            context.Class.AddOrUpdate(
               p => p.id,
                  new Classes
                  {
                      ClassSubject = "Science",
                      ClassTutor = "Mr Stevenson",
                      id = 1,
                      AddedBy = "Admin",
                      AddedDate = DateTime.Now
                  },
                  new Classes
                  {
                      ClassSubject = "English",
                      ClassTutor = "Mr Johnson",
                      id = 2,
                      AddedBy = "Admin",
                      AddedDate = DateTime.Now
                  },
                  new Classes
                  {
                      ClassSubject = "Mathematics",
                      ClassTutor = "Miss Fanny",
                      id = 3,
                      AddedBy = "Admin",
                      AddedDate = DateTime.Now
                  }

                  );

            context.Staffs.AddOrUpdate(
               p => p.id,
                  new Staff
                  {
                      TutorFirstName = "Michael",
                      TutorLastName = "Stevenson",
                      AddedBy = "Admin",
                      id  = 1,
                      Age = 32,
                      AddedDate = DateTime.Now
                  },
                  new Staff
                  {
                      TutorFirstName = "Steven",
                      TutorLastName = "Parkinson",
                      AddedBy = "Admin",
                      id = 2,
                      Age = 54,
                      AddedDate = DateTime.Now
                  },
                  new Staff
                  {
                      TutorFirstName = "Fiona",
                      TutorLastName = "Jizz",
                      AddedBy = "Admin",
                      id = 3,
                      Age = 23,
                      AddedDate = DateTime.Now
                  }

                  );
        }
    }
}
