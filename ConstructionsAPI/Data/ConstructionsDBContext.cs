using Microsoft.EntityFrameworkCore;
using ConstructionsAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Data
{
    public class ConstructionsDBContext : DbContext
    {
        public DbSet<Object> Object { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Brigade> Brigade { get; set; }
        public DbSet<Composition_brigade> Composition_brigade { get; set; }
        public DbSet<Counterparty> Counterparty { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Equipment_order_agreement> Equipment_order_agreement { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Materials_Objects> Materials_Objects { get; set; }
        public DbSet<Materials_ordering_agreement> Materials_ordering_agreement { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Sales_contract> Sales_contract { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Technics> Technics { get; set; }
        public DbSet<Technics_Objects> Technics_Objects { get; set; }
        public DbSet<Type_object> Type_object { get; set; }
        public DbSet<Type_technics> Type_technics { get; set; }
        public ConstructionsDBContext(DbContextOptions<ConstructionsDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
