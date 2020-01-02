using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sharenet.Models
{
	public class User
	{
		private List<Shareable> shareables;
		[Key]
		public int Id { get; set; }
		public User()
		{
			shareables = new List<Shareable>();
		}

		public void Remove(Shareable s)
		{
			shareables.Remove(s);
		}

		public void Add(Shareable s)
		{
			shareables.Add(s);
			s.TransferTo(this);
		}

		public List<Shareable> GetShareables => shareables;
	}
}