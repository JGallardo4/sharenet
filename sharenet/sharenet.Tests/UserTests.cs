using System;
using Xunit;

using sharenet.Models;

namespace sharenet.Tests
{
	public class UserTests
	{
		[Fact]
		public void Transfer_Works()
		{
			/// arrange
			User a = new User();
			User b = new User();
			Shareable s = new Shareable();

			// assert
			Assert.Null(s.GetCustodian());

			// act
			a.Add(s);

			// assert
			Assert.Equal(a, s.GetCustodian());
			Assert.Contains(s, a.GetShareables);

			// act
			s.TransferTo(b);

			// assert
			Assert.Equal(b, s.GetCustodian());
			Assert.Contains(s, b.GetShareables);
		}
	}
}
