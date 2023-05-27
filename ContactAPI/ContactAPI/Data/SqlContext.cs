using ContactAPI.Data.Map;
using ContactAPI.Model;
using Microsoft.EntityFrameworkCore;


namespace ContactAPI.Data
{
    public class SqlContext : DbContext
    {
        IConfiguration _configuration;

        public SqlContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<ContactModel> Contato { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = _configuration.GetConnectionString("SqLite");
            optionsBuilder.UseSqlite(connectionstring);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
