using System;

namespace MarsRover
{
	public class Location
	{
		Position _position;
		Orientation _orientation;
		public Location (Position position, Orientation orientation)
		{
			_position = position;
			_orientation = orientation;
		}

		public Location Left()
		{
			return  new Location(_position,OrientationGenerator.GetOrientation( _orientation.Left ()));
		}

		public Location Right()
		{
			return  new Location(_position,OrientationGenerator.GetOrientation( _orientation.Right ()));
		}

		public Location Forward()
		{
			return new Location (_orientation.Stratergy.Move (_position,1), _orientation);
		}

		public Location Back()
		{
			return new Location (_orientation.Stratergy.Move (_position,-1), _orientation);
		}

		public override bool Equals (object obj)
		{
			if (obj == null && !(obj is  Location)) {
				return false;
			}

			Location passedObject = obj as Location;

			return (passedObject._position.Equals(this._position)) && (passedObject._orientation.Equals(this._orientation));
		}
	}
}

