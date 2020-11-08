namespace Memberships.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Memberships.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            //automatic migrations for sake of this project - strictly NOT to do
            AutomaticMigrationsEnabled = true;
            // we don't want to loose data, for the sake of this project only is true
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Memberships.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
