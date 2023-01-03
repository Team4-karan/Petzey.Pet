using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface_Repository
{
	public interface IPetOwnerRepository
	{
		void AddPetOwner(PetOwner petOwner);
		void RemovePetOwner(PetOwner petOwner);
		PetOwner GetPetOwner(int id);
		void UpdatePetOwner(PetOwner petOwner);
	}
}
