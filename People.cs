using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	public enum Professions
	{
		Writer,
		Engineer,
		Doctor,
		Teacher
	}
	public class People
	{
		public int ID { get; set; } 
		public string Name  { get; set; }
		public Professions ProfessionName { get; set; }
		public decimal Salary { get; set; }
		public string City { get; set; }
		
	}
	public class Post
	{
		public int PostId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		
	}


	public class DatabaseContext : DbContext
	{
		public DbSet<People> Peoples { get; set; }
		public DbSet<Post> Posts { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<People>()
				.Property(e => e.ProfessionName)
				.HasColumnName("Profession");
		}
	}
	

}
