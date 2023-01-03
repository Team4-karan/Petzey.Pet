using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Domain.Entity
{
	public class Pets
	{
		public int PetsId { get; set; }
		public string petName { get; set; }
		public string species { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Age { get; set; }
		public string BloodGroup { get; set; }
		public int PetOwnerId { get; set; }
	}
}