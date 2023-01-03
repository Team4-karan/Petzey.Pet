using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
	public class PetOwner
	{
		public int PetOwnerId { get; set; }
		public string ParentName { get; set; }
		public string Email { get; set; }
		public long MobileNo { get; set; }
		public string Address { get; set; }
	}
}
