using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Data.DataAccess_layer
{
	public class PetzeyDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=tcp:team4pet.database.windows.net,1433;Initial Catalog=Petzeydb;Persist Security Info=False;User ID=Karankumar;Password=Petzey@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		}

		public DbSet<Pets> Pets { get; set; }
		public DbSet<PetOwner> PetOwners { get; set; }
		
	}
}
