using Codify.DataAccess.Admin.Configuration;
using Codify.Entity.Admin;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Codify.DataAccess.Admin
{
    public class CodifyDataContext : DbContext
    {
        public CodifyDataContext() : base("name = CodifyDataContext") { }
        public DbSet<Role> role { get; set; }
        public DbSet<Application> application { get; set; }
        public DbSet<ApplicationRole> applicationRole { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<UserApplicationRole> userApplicationRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new RoleConfiguration<Role>());
            modelBuilder.Configurations.Add(new ApplicationConfiguration<Application>());
            modelBuilder.Configurations.Add(new ApplicationRoleConfiguration<ApplicationRole>());
            modelBuilder.Configurations.Add(new UserConfiguration<User>());
            modelBuilder.Configurations.Add(new UserApplicationRoleConfiguration<UserApplicationRole>());
            base.OnModelCreating(modelBuilder);
        }

    }
}
