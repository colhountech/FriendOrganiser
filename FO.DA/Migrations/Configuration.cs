namespace FO.DA.Migrations
{
    using FO.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FO.DA.FO_DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FO.DA.FO_DBContext context)
        {
            
            // first param is how to identify if the entity already exists 
            // in the  database, and if so, do an update, otherwise insert
            // 2nd param are the entities to insert
            context.Friends.AddOrUpdate(
                f => f.Firstname,
                new Friend { Firstname = "1sdfas", Lastname = "asdfasfd" },
                new Friend { Firstname = "2sdfas", Lastname = "asdfasfd" },
                new Friend { Firstname = "3sdfas", Lastname = "asdfasfd" },
                new Friend { Firstname = "4sdfas", Lastname = "asdfasfd" },
                new Friend { Firstname = "5sdfas", Lastname = "asdfasfd" }
                );
            // Now open Tools > Nuget Package Manager > Package Manager Console and enter
            // Add-Migrations [name-of-migration]
            // eg.
            // Add-Migration "Initial Seed"
            // outcome:
            // Scaffolding migration 'Initial Seed'.
            // The Designer Code for this migration file includes a snapshot of your current
            // Code First model.This snapshot is used to calculate the changes to your model
            // when you scaffold the next migration.If you make additional changes to your
            // model that you want to include in this migration, then you can re - scaffold
            // it by running 'Add-Migration Initial Seed' again.

            // Always call [Add-Migration] when  you update the Model
            // then call [Update-Database] Command to update the database..see later

            // The New Migration files consist of 3 parts
            // 1. a class with "Inital Seed.cs" as a suffix, with 2 methodsL
            // Up() to Apply change 
            // Down() to Revert the changes
            // 2. a class with "Inital Seed.Designer.cs" as a suffix
            // this references the Source and Target Datbase. 
            // In this case Source is null 
            // 3. resx file
            // contains a hash to the Target database

        }
    }
}
