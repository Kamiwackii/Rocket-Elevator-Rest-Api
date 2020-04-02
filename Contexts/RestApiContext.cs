using Microsoft.EntityFrameworkCore;

namespace restapi.Contexts 
{
    public class RestApiContext : DbContext
    {
        public RestApiContext(DbContextOptions<RestApiContext> options) : base(options)
        {
        }

        // Tables
        public virtual DbSet<Battery> Batteries { get; set; }
        public virtual DbSet<Column> Columns { get; set; }
        public virtual DbSet<Elevator> Elevators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Battery>()
                .ToTable("batteries")
                .HasKey(b => b.id);
            modelBuilder.Entity<Battery>()
                .Property(x => x.certificate_operations)
                .HasColumnType("blob");
            
            modelBuilder.Entity<Column>()
                .ToTable("columns")
                .HasKey(c => c.id);
            modelBuilder.Entity<Column>()
                .HasIndex(e => e.battery_id);
            modelBuilder.Entity<Column>().Property<long?>("battery_id");
            modelBuilder.Entity<Column>().HasOne(c => c.Battery).WithMany(p => p.Columns).HasForeignKey(d => d.battery_id);
            
            modelBuilder.Entity<Elevator>()
                .ToTable("elevators")
                .HasKey(x => x.id);
            modelBuilder.Entity<Elevator>()
                .HasIndex(e => e.column_id);
            modelBuilder.Entity<Elevator>().Property<long?>("column_id");
            modelBuilder.Entity<Elevator>().HasOne(c => c.Column).WithMany(p => p.Elevators).HasForeignKey(d => d.column_id);
        }
    }
}