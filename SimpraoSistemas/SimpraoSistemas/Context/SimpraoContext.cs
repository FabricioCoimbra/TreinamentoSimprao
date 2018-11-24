using Microsoft.EntityFrameworkCore;
using SimpraoSistemas.Models;

namespace SimpraoSistemas.Context
{
	public class SimpraoContext : DbContext
	{
		public SimpraoContext()
		{
		}

		public SimpraoContext(DbContextOptions<SimpraoContext> options) : base(options)
		{
			Database.EnsureCreated();
		}

		public virtual DbSet<Login> Login { get; set; }
	}
}
