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
	public class PetRepository : IPetRepository
	{
		PetzeyDbContext db = new PetzeyDbContext();
		public void AddPet(Pets pet)
		{
			db.Pets.Add(pet);
			db.SaveChanges();
		}

		public Pets GetPet(int id)
		{
			return db.Pets.Find(id);
		}

		public void DeletePet(Pets pet)
		{
			db.Pets.Remove(pet);
			db.SaveChanges();
		}

		public void UpdatePet(Pets pet)
		{
			db.Entry(pet).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			db.SaveChanges();
		}

		public List<Pets> GetAllPetByUserId(int id)
		{
			return (from pet in db.Pets
					where pet.PetOwnerId == id
					select pet).ToList();
		}
	}
}
