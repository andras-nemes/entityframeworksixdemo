using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Cars.Domain;
using System.Diagnostics;

namespace Cars.Web.Database
{
	public class CarsDbContext : DbContext
	{
		public CarsDbContext() : base("DefaultConnection")
		{
            Database.Log = statements => Debug.WriteLine(statements);
		}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("domain");
            base.OnModelCreating(modelBuilder);
        }

		public DbSet<Car> Cars { get; set; }
	}
}