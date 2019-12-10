namespace sharenet.Models
{
	public class Shareable
	{
		private bool InUse = false;

		public bool IsInUse()
		{
			return InUse;
		}

		public bool IsAvailable()
		{
			return !InUse;
		}

		public void SetInUse()
		{
			InUse = true;
		}

		public void SetAvailable()
		{
			InUse = false;
		}
	}
}
