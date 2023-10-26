﻿using Entities.Models;
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

		public virtual DbSet<User> Users { get; set; }

		public virtual DbSet<Animal> Animals { get; set; }

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

			modelBuilder.Entity<User>();

			modelBuilder.Entity<Area>().ToTable(nameof(Area));
			modelBuilder.Entity<Cage>().ToTable(nameof(Cage));

			modelBuilder.Entity<Cage>().HasOne(c => c.Area)
				.WithMany(c => c.Cages)
				.HasForeignKey(c => c.AreaId);

			modelBuilder.Entity<Animal>().ToTable(nameof(Animal));

			modelBuilder.Entity<Animal>().HasOne(a => a.Cage)
				.WithMany(c => c.Animals)
				.HasForeignKey(a => a.CageId);
		}

		private string GetConnectionString()
		{
			IConfiguration configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", true, true)
				.Build();
			var strCon = configuration["ConnectionStrings:Default"] ?? string.Empty;
			return strCon;
		}
	}
}
