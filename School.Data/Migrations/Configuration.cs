namespace School.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<School.Data.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(School.Data.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.SchoolSet.AddOrUpdate(
            //  //p => p.SchoolCode,
            //  //new Business.School.SchoolInformation { SchoolCode = "SCH0001",SchoolName="Shingu Computer College"
            //  }
             
            //);

        }
    }
}
