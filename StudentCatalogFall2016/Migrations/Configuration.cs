namespace StudentCatalogFall2016.Migrations
{
    using Models.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentCatalogFall2016.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StudentCatalogFall2016.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //first param used to check if exists already: http://blogs.msdn.com/b/rickandy/archive/2013/02/12/seeding-and-debugging-entity-framework-ef-dbs.aspx
            context.Students.AddOrUpdate(s => s.Email, new StudentModel[]
                                         {
                                             new StudentModel
                                             {
                                                 Firstname = "Christian",
                                                 Lastname =  "Kirschberg",
                                                 Email = "ckirschberg@gmail.com",
                                                 MobilePhone = "61690509",
                                                 //ProfileImagePath = "/UserUploads/ProfileImages/dfdf6200-5331-4e9a-88a6-b21c01e35708.jpg" //requires the image to be located here
											 },
                                             new StudentModel
                                             {
                                                 Firstname = "Hans",
                                                 Lastname = "Hansen",
                                                 Email = "hans@hans.dk",
                                                 MobilePhone = "12345678",
                                                 //ProfileImagePath = "/UserUploads/ProfileImages/d0de098a-d55c-4638-b1b3-6fa69ad54358.jpg"
                                             },
                                             new StudentModel
                                             {
                                                 Firstname = "Jens",
                                                 Lastname = "Jensen",
                                                 Email = "jens@jens.dk",
                                                 MobilePhone = "12345638",
                                                 //ProfileImagePath = "/UserUploads/ProfileImages/98196844-5057-4573-a6d6-3712a9577e46.jpg"
                                             },
                                             new StudentModel
                                             {
                                                 Firstname = "Helle",
                                                 Lastname = "Hellesen",
                                                 Email = "helle@helle.dk",
                                                 MobilePhone = "12345632",
                                                 //ProfileImagePath = "/UserUploads/ProfileImages/4934ca3f-b243-42f3-902e-60e421d523ab.jpg"
                                             },
                                             new StudentModel
                                             {
                                                 Firstname = "Berit",
                                                 Lastname = "Beritsen",
                                                 Email = "berit@berit.dk",
                                                 MobilePhone = "12345631",
                                                 //ProfileImagePath = "/UserUploads/ProfileImages/88e1a78c-2944-4e1d-a162-8dc95fceead6.jpg"
                                             },
                                             new StudentModel
                                             {
                                                 Firstname = "Allan",
                                                 Lastname = "Allansen",
                                                 Email = "allan@allan.dk",
                                                 MobilePhone = "12345632",
                                                 //ProfileImagePath = "/UserUploads/ProfileImages/25b8920c-164e-47ce-9678-e1debd581531.jpg"
                                             },
                                             new StudentModel
                                             {
                                                 Firstname = "Jesper",
                                                 Lastname = "Jespersen",
                                                 Email = "jesper@jesper.dk",
                                                 MobilePhone = "12315631",
                                                 //ProfileImagePath = "/UserUploads/ProfileImages/06975321-feba-4964-9de8-0921b75be780.jpg"
                                             }
                                         });

            context.CompentencyHeaderModels.AddOrUpdate(h => h.CompetencyHeaderModelId, new CompetencyHeaderModel[]
                                                             {
                                                                 new CompetencyHeaderModel
                                                                 {
                                                                     CompetencyHeaderModelId = 1,
                                                                     Name="Design"
                                                                 },
                                                                 new CompetencyHeaderModel{
                                                                     CompetencyHeaderModelId = 2,
                                                                     Name="Computer programming"
                                                                 },
                                                                 new CompetencyHeaderModel
                                                                 {
                                                                     CompetencyHeaderModelId = 3,
                                                                     Name="Software"
                                                                 }
                                                             });



            context.CompentencyMocdels.AddOrUpdate(c => c.CompetencyModelId, new CompetencyModel[]
                                                                {
                                                                    new CompetencyModel
                                                                    {
                                                                        CompetencyModelId = 1,
                                                                        CompetencyHeaderModelId = 1,
                                                                        Name = "Fashion"
                                                                    },
                                                                    new CompetencyModel
                                                                    {
                                                                        CompetencyModelId = 2,
                                                                        CompetencyHeaderModelId = 1,
                                                                        Name = "Sewing"
                                                                    },

                                                                    new CompetencyModel
                                                                    {
                                                                        CompetencyModelId = 3,
                                                                        CompetencyHeaderModelId = 2,
                                                                        Name = "Java"
                                                                    },
                                                                    new CompetencyModel
                                                                    {
                                                                        CompetencyModelId = 4,
                                                                        CompetencyHeaderModelId = 2,
                                                                        Name = "MySQL"
                                                                    },
                                                                    new CompetencyModel
                                                                    {
                                                                        CompetencyModelId = 5,
                                                                        CompetencyHeaderModelId = 3,
                                                                        Name = "Microsoft Office"
                                                                    },
                                                                });


        }
    }
}
