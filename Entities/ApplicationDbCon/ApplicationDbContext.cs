using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Entities.ApplicationDbCon
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext() { }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public ApplicationDbContext(string connection)
		{
			this.Database.SetConnectionString(connection);
		}

  		public virtual DbSet<Area> Areas { get; set; }

		public virtual DbSet<Cage> Cages { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(GetConnectionString());
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Area>().ToTable(nameof(Area));
			modelBuilder.Entity<Cage>().ToTable(nameof(Cage));

			modelBuilder.Entity<Cage>().HasOne(c => c.Area)
				.WithMany(c => c.Cages)
				.HasForeignKey(c => c.AreaId);
		}

		private string GetConnectionString()
		{
			IConfiguration configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", true, true)
				.Build();
			var strCon = configuration["ConnectionStrings:Default"];
			return strCon;
		}
	}
}
