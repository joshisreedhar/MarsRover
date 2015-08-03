using System;

namespace MarsRover
{
	public class Rover
	{
		Location _location;
		public Rover (Location location)
		{
			_location = location;
		}

		public Location TurnLeft()
		{
			return _location.Left ();
				
		}

		public Location TurnRight()
		{
			return _location.Right ();
		}

		public Location MoveForward()
		{
			return _location.Forward ();
		}

		public Location MoveBack()
		{
			return _location.Back ();
		}
	}
}

