using Microsoft.EntityFrameworkCore;
using System;

namespace GlonassSoftTest
{
	public class DbInteractor : DbContext
	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
			.UseSqlite(@"Data Source = UserStats.db;");
		}
		public DbSet<UserStats> UserStats { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserStats>().HasData(
			new UserStats() { Id = Guid.NewGuid(), EmploymentDate = new DateTime(2022, 4, 12), Name = "Xарламов Д.Д." },
			new UserStats() { Id = Guid.NewGuid(), EmploymentDate = new DateTime(2022, 6, 17), Name = "Сергеев С.Т." },
			new UserStats() { Id = Guid.NewGuid(), EmploymentDate = new DateTime(2022, 9, 1), Name = "Смирнов А.В." },
			new UserStats() { Id = Guid.NewGuid(), EmploymentDate = new DateTime(2021, 3, 19), Name = "Куприенко Л.В." },
			new UserStats() { Id = Guid.NewGuid(), EmploymentDate = new DateTime(2023, 3, 15), Name = "Волкова А.В." }
			);
		}
	}
}
