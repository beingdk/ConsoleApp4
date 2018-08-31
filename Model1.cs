namespace ConsoleApp4
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=Model1")
		{
		}

		public virtual DbSet<Mydetail> Mydetails { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Mydetail>()
				.Property(e => e.name)
				.IsUnicode(false);

			modelBuilder.Entity<Mydetail>()
				.Property(e => e.address)
				.IsUnicode(false);

			modelBuilder.Entity<Mydetail>()
				.Property(e => e.city)
				.IsUnicode(false);

			modelBuilder.Entity<Mydetail>()
				.Property(e => e.salary)
				.HasPrecision(13, 4);
		}
	}
}
