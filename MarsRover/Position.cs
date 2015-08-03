using System;

namespace MarsRover
{
	public class Position
	{
		int _xCoordinate;
		int _yCoordinate;
		public Position (int xCoordinate, int yCoordinate)
		{
			_xCoordinate = xCoordinate;
			_yCoordinate = yCoordinate;
		}

		public Position MoveHorizontally(int unitsToMove)
		{
			_xCoordinate += unitsToMove;
			return this;
		}

		public Position MoveVerticaly(int unitsToMove)
		{
			_yCoordinate += unitsToMove;
			return this;
		}

		public override bool Equals (object obj)
		{
			if(obj == null && !(obj is Position))
			{
				return false;
			}

			Position passedPosition = obj as Position;

			return (passedPosition._xCoordinate == this._xCoordinate) &&  (passedPosition._yCoordinate == this._yCoordinate);
		}

	}
}

