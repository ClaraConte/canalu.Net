using Microsoft.EntityFrameworkCore;

namespace canalu.Models
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }
        public DbSet<RolesActions> RolesActions { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Commerces> Commerces { get; set; }
    }
}
