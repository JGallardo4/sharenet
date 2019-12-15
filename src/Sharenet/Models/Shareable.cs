using System;

namespace Sharenet.Models
{
	public class Shareable
	{
		private bool InUse = false;
		private User custodian;

		public Shareable(User custodian)
		{
			if (custodian != null)
			{
				this.custodian = custodian;
			}
			else
			{
				throw new ArgumentNullException();
			}
		}

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
