using System;

namespace MarsRover
{
	public static class OrientationGenerator
	{
		public static Orientation GetOrientation(Direction direction)
		{
			IMovementStratergy verticalMovement = new VerticalMovementStratergy ();
			IMovementStratergy horizontalMovement = new HorizantalMovementStratergy ();
			switch (direction) {
			case Direction.North:
				return new Orientation(Direction.West, Direction.East, verticalMovement );
			case Direction.East:
				return new Orientation (Direction.North, Direction.South,horizontalMovement);
			case Direction.South:
				return new Orientation (Direction.East, Direction.West,verticalMovement);
			case Direction.West:
				return new Orientation (Direction.South, Direction.North,horizontalMovement);
			default:
				return new Orientation (Direction.None, Direction.None,horizontalMovement);
					
			}
		}
	}
}

