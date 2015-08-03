using NUnit.Framework;
using System;
using MarsRover;

namespace RoverTests
{
	[TestFixture ()]
	public class RoverTest
	{
		[Test ()]
		public void Rover_When_Facing_North_Should_Turn_To_West_When_Asked_To_TurnLeft ()
		{
			Orientation northOrientation = OrientationGenerator.GetOrientation (Direction.North);
			Orientation westOrientation = OrientationGenerator.GetOrientation (Direction.West);

			Location location = new Location (new Position (2, 3), northOrientation);
			Location expectedLocation = new Location (new Position (2, 3), westOrientation);
			Rover rover = new Rover (location);
			Location actualLocation = rover.TurnLeft ();
			Assert.AreEqual (expectedLocation,actualLocation);
		}


		[Test ()]
		public void Rover_When_Facing_North_Should_Turn_To_East_When_Asked_To_TurnRight ()
		{
			Orientation northOrientation = OrientationGenerator.GetOrientation (Direction.North);
			Orientation eastOrientation = OrientationGenerator.GetOrientation (Direction.East);

			Location location = new Location (new Position (2, 3), northOrientation);
			Location expectedLocation = new Location (new Position (2, 3), eastOrientation);
			Rover rover = new Rover (location);
			Location actualLocation = rover.TurnRight ();
			Assert.AreEqual (expectedLocation,actualLocation);
		}

		[Test ()]
		public void Rover_Which_Is_East_When_Asked_To_MoveForward_Should_Move_One_Unit_Horizontally ()
		{
			Orientation eastOrientation = OrientationGenerator.GetOrientation (Direction.East);

			Location location = new Location (new Position (2, 3), eastOrientation);
			Location expectedLocation = new Location (new Position (3, 3), eastOrientation);
			Rover rover = new Rover (location);
			Location actualLocation = rover.MoveForward ();
			Assert.AreEqual (expectedLocation,actualLocation);
		}

		[Test ()]
		public void Rover_Which_Is_East_When_Asked_To_MoveBack_Should_Move_One_Unit_Backward_Horizontally ()
		{
			Orientation eastOrientation = OrientationGenerator.GetOrientation (Direction.East);

			Location location = new Location (new Position (2, 3), eastOrientation);
			Location expectedLocation = new Location (new Position (1, 3), eastOrientation);
			Rover rover = new Rover (location);
			Location actualLocation = rover.MoveBack ();
			Assert.AreEqual (expectedLocation,actualLocation);
		}

		[Test ()]
		public void Rover_Which_Is_North_When_Asked_To_MoveForward_Should_Move_One_Unit_Vertically ()
		{
			Orientation northOrientation = OrientationGenerator.GetOrientation (Direction.North);

			Location location = new Location (new Position (2, 3), northOrientation);
			Location expectedLocation = new Location (new Position (2, 4), northOrientation);
			Rover rover = new Rover (location);
			Location actualLocation = rover.MoveForward ();
			Assert.AreEqual (expectedLocation,actualLocation);
		}

		[Test ()]
		public void Rover_Which_Is_North_When_Asked_To_MoveBack_Should_Move_One_Unit_Backward_Vertically ()
		{
			Orientation northOrientation = OrientationGenerator.GetOrientation (Direction.North);

			Location location = new Location (new Position (2, 3), northOrientation);
			Location expectedLocation = new Location (new Position (2, 2), northOrientation);
			Rover rover = new Rover (location);
			Location actualLocation = rover.MoveBack ();
			Assert.AreEqual (expectedLocation,actualLocation);
		}
	}
}

