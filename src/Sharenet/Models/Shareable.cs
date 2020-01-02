using System;
using System.ComponentModel.DataAnnotations;

namespace Sharenet.Models
{
	public class Shareable
	{
		private bool InUse = false;
		private User User;
		[Key]
		public int Id { get; set; }

		public Shareable(User user)
		{
			if (user != null)
			{
				this.User = user;
			}
			else
			{
				throw new ArgumentNullException();
			}
		}

		public Shareable()
		{
		}

		public bool IsInUse() => InUse;

		public bool IsAvailable() => !InUse;

		public void SetInUse() => InUse = true;

		public void SetAvailable() => InUse = false;

		public User GetCustodian() => User;

		public void TransferTo(User newUser)
		{
			if (newUser == null) throw new ArgumentNullException();

			if (newUser != User)
			{
				User.Remove(this);
				User = newUser;
			}
			else
			{
				throw new ArgumentException("User is already the current custodian");
			}
		}
	}
}
