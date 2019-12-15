using System;
using NUnit.Framework;

using Sharenet.Models;

namespace Sharenet.Tests.Models
{
	[TestFixture]
	public class UserTests
	{
		[Test]
		public void Transfer_Works()
		{
			/// arrange
			User a = new User();
			User b = new User();
			Shareable s = new Shareable(a);

			// assert
			Assert.AreEqual(a, s.GetCustodian());
			Assert.Contains(s, a.GetShareables);

			// act
			s.TransferTo(b);

			// assert
			Assert.AreEqual(b, s.GetCustodian());
			Assert.Contains(s, b.GetShareables);
		}
	}
}
