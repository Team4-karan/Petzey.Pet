using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface_Repository
{
	public interface IPetRepository
	{
		void AddPet(Pets pet);
		void UpdatePet(Pets pet);
		Pets GetPet(int id);
		void DeletePet(Pets pet);
		List<Pets> GetAllPetByUserId(int id);
	}
}
