using FO.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FO.DA
{

    /*
     *  Using Code First Data Migration:
     *  
     *  To create the database we first need to do a code-first migration
     *  
     *  Tools > Package Manager > NuGet Package Manager Console
     *  Choose the Data Access Project from pulldown
     *  Enable-Migrations
     *   
     *  We get the following output...
     *  Checking if the context targets an existing database...
     *  A new Migrations folder appears, containing the Configuration.cs class containing a ctor and Seed()
     */
    public class FO_DBContext : DbContext
    {
        public FO_DBContext() : base("FriendOrganiserDB")
        {

        }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // to prevent pluralizing Table Names, keep singular tables
            // remove a convension
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Fluent API - IF not using [DataAnnotations]
            //modelBuilder.Entity<Friend>()
            //.Property((f => f.Firstname))
            //.IsRequired()
            //.HasMaxLength(50);
            // 
            // Move to FriendConfiguration
            //modelBuilder.Configurations.Add(new FriendConfiguration());


        }
    }
    public class FriendConfiguration : EntityTypeConfiguration<Friend>
    {
        public FriendConfiguration()
        {
            Property((f => f.Firstname))
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}
