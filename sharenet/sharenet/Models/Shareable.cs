using System;

namespace sharenet.Models
{
	public class Shareable
	{
		private bool InUse = false;
		private User custodian;

		public bool IsInUse() => InUse;

		public bool IsAvailable() => !InUse;

		public void SetInUse() => InUse = true;

		public void SetAvailable() => InUse = false;

		public User GetCustodian() => custodian;

		public void TransferTo(User user)
		{
			if (custodian != user)
			{
				TransferTo(user);
			}
			custodian.Remove(this);
			custodian = user;
		}
	}
}
