using Domain.Entity;

namespace PetAPITesting
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void CheckPet()
		{
			Pets pet = new Pets();
			int actual = pet.PetsId;
			int expected = pet.PetsId;
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void CheckPetOwner()
		{
			PetOwner peto = new PetOwner();
			int actual = peto.PetOwnerId;
			int expected = peto.PetOwnerId;
			Assert.AreEqual(expected, actual);
		}
	}
}