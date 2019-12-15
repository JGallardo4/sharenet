using System;
using System.Collections.Generic;

namespace Sharenet.Models
{
	public class User
	{
		private List<Shareable> shareables;

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