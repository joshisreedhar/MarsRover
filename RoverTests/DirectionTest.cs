using NUnit.Framework;
using System;
using MarsRover;

namespace RoverTests
{
	[TestFixture ()]
	public class DirectionTest
	{
		[Test ()]
		public void Orientation_Which_Is_East_When_Asked_For_Its_Right_Should_Return_North_Direction ()
		{
			Orientation east = new Orientation (Direction.North, Direction.South,new VerticalMovementStratergy());
			Assert.AreEqual (Direction.North, east.Left ());
		}

		[Test ()]
		public void Orientation_Which_Is_East_When_Asked_For_Its_Right_Should_Return_South_Direction ()
		{
			Orientation east = new Orientation (Direction.North, Direction.South, new VerticalMovementStratergy());
			Assert.AreEqual (Direction.South, east.Right ());
		}
			
	}
}

