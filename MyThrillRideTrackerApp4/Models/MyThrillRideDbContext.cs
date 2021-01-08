using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyThrillRideTrackerApp4.Models
{
	// Had to use EF Core 3.0.3, 3.1 EF Core broke DbContext and options 1/8/21
	public class MyThrillRideDbContext : DbContext
	{
		public MyThrillRideDbContext(DbContextOptions<MyThrillRideDbContext> options)
			: base(options)
		{
		}
		public DbSet<Park> Parks { get; set; }
		public DbSet<Ride> Rides { get; set; }
		public DbSet<Visit> Visits { get; set; }
		public DbSet<VisitRide> VisitRides { get; set; }
		public DbSet<ImageFileName> ImageFileNames { get; set; }


	}
}
