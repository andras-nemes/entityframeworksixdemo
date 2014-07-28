using Cars.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cars.Web.Database
{
	public class UserManagementDbContext : IdentityDbContext<ApplicationUser>
	{
		public UserManagementDbContext()
			: base("DefaultConnection")
		{

		}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("identity");
            base.OnModelCreating(modelBuilder);
        }
	}
}