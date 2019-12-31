using Microsoft.EntityFrameworkCore;

namespace Sharenet.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Shareable> Shareables { get; set; }
	}
}