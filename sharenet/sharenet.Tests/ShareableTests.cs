using System;
using Xunit;

using sharenet.Models;

namespace sharenet.Tests
{
	public class ShareableTests
	{
		[Fact]
		public void SetInUse_Works()
		{
			/// arrange
			Shareable s = new Shareable();

			/// assert
			Assert.False(s.IsInUse());

			/// act
			s.SetInUse();

			/// assert
			Assert.True(s.IsInUse());
		}

		[Fact]
		public void SetAvailabe_Works()
		{
			/// arrange
			Shareable s = new Shareable();

			/// assert
			Assert.True(s.IsAvailable());

			/// act
			s.SetInUse();

			/// assert
			Assert.False(s.IsAvailable());

			/// act
			s.SetAvailable();

			/// assert
			Assert.True(s.IsAvailable());
		}
	}
}
