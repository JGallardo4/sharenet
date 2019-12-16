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
			Assert.That(a, Is.EqualTo(s.GetCustodian()));
			Assert.That(a.GetShareables, Contains.Item(s));

			// act
			s.TransferTo(b);

			// assert
			Assert.That(b, Is.EqualTo(s.GetCustodian()));
			Assert.That(b.GetShareables, Contains.Item(s));
		}
	}
}
