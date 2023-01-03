using Data.DataAccess_layer;
using Domain.Entity;
using Domain.Interface_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
	public class PetOwnerRepository : IPetOwnerRepository
	{
		PetzeyDbContext db = new PetzeyDbContext();
		public void AddPetOwner(PetOwner petOwner)
		{
			db.PetOwners.Add(petOwner);
			db.SaveChanges();
		}

		public PetOwner GetPetOwner(int id)
		{
			return db.PetOwners.Find(id);
		}

		public void RemovePetOwner(PetOwner petOwner)
		{
			db.PetOwners.Remove(petOwner);
			db.SaveChanges();
		}

		public void UpdatePetOwner(PetOwner petOwner)
		{
			db.Entry(petOwner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			db.SaveChanges();
		}
	}
}
