using Data.Repository;
using Domain.Entity;
using Domain.Interface_Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.OData;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PetController : ControllerBase
	{
		IPetOwnerRepository ORepo = new PetOwnerRepository();
		IPetRepository PRepo = new PetRepository();

		[HttpPost]
		[Route("AddPetOwner")]
		public ActionResult AddPetOwner(PetOwner petOwner)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid Input");
			ORepo.AddPetOwner(petOwner);

			return Created("api/Pet{PetOwner.PetOwnerId}", petOwner);
		}

		[HttpPost]
		[Route("AddPet")]
		public ActionResult AddPet(Pets pet)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid Input");
			PRepo.AddPet(pet);

			return Created("api/Pet{Pet.PetId}", pet);
		}

		[HttpDelete]
		[Route("RemovePetOwner/{id}")]
		public ActionResult<PetOwner> DeletePetOwner(int id)
		{
			var res = ORepo.GetPetOwner(id);
			if (res == null)
				return NotFound();
			ORepo.RemovePetOwner(res);
			return Ok();
		}

		[HttpDelete]
		[Route("RemovePet/{id}")]
		public ActionResult<Pets> DeletePet(int id)
		{
			var res = PRepo.GetPet(id);
			if (res == null)
				return NotFound();
			PRepo.DeletePet(res);
			return Ok();
		}

		[HttpPut]
		[Route("UpdatePetOwner")]
		public ActionResult UpdatePetOwner(PetOwner petOwner)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid Input");
			ORepo.UpdatePetOwner(petOwner);
			return Ok();
		}

		[HttpPut]
		[Route("UpdatePet")]
		public ActionResult UpdatePet(Pets pet)
		{
			if (!ModelState.IsValid)
				return BadRequest("Invalid Input");
			PRepo.UpdatePet(pet);
			return Ok();
		}

		[HttpGet]
		[Route("PetOwner/{id}")]
		public ActionResult<PetOwner> GetPetOwner(int id)
		{
			var res = ORepo.GetPetOwner(id);
			if (res == null)
				return NotFound();
			return Ok(res);
		}

		[HttpGet]
		[Route("{id}")]
		public ActionResult<Pets> GetPet(int id)
		{
			var res = PRepo.GetPet(id);
			if (res == null)
				return NotFound();
			return Ok(res);
		}

		[HttpGet]
		[Route("AllPet/UserId/{id}")]
		public ActionResult<List<Pets>> GetPetByUserId(int id)
		{
			var res = PRepo.GetAllPetByUserId(id);
			if (res == null)
				return NotFound();
			return Ok(res);
		}
}
}
