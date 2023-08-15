using System;
using Microsoft.EntityFrameworkCore;
using RazorPagesCadastro.Models;

namespace RazorPagesCadastro.Context
{
	public class MyDbContext : DbContext
	{
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Student> Students { get; set; }

		public MyDbContext(DbContextOptions options) : base(options)
		{

		}
	}
}