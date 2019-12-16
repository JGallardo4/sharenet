using System;
using NUnit.Framework;

using Sharenet.Models;

namespace Sharenet.Tests.Models
{
	[TestFixture]
	public class ShareableTests
	{
		[Test]
		public void Null_Checking()
		{
			// arrange
			User u = null;

			// assert
			Assert.That(
				() => {Shareable s = new Shareable(u);},
				Throws.ArgumentNullException
			);
		}

		[Test]
		public void SetInUse_Works()
		{
			// arrange
			Shareable s = new Shareable(new User());

			// assert
			Assert.False(s.IsInUse());

			// act
			s.SetInUse();

			// assert
			Assert.True(s.IsInUse());
		}

		[Test]
		public void SetAvailabe_Works()
		{
			// arrange
			Shareable s = new Shareable(new User());

			// assert
			Assert.True(s.IsAvailable());

			// act
			s.SetInUse();

			// assert
			Assert.False(s.IsAvailable());

			// act
			s.SetAvailable();

			// assert
			Assert.True(s.IsAvailable());
		}
	}
}
