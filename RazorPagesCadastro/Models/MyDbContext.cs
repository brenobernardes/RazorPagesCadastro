using System;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesCadastro.Models
{
	public class MyDbContext : DbContext
	{
		public DbSet<Teacher> Teachers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("MyDb");
		}
	}
}

