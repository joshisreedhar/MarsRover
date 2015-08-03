using System;

namespace MarsRover
{
	public class Orientation
	{
		Direction _left;
		Direction _right;
		IMovementStratergy _movementStratergy;
		public Orientation (Direction left, Direction right, IMovementStratergy movementStratergy)
		{
			_left = left;
			_right = right;
			_movementStratergy = movementStratergy;
		}

		public Direction Left()
		{
			return _left;
		}

		public Direction Right()
		{
			return _right;
		}

		public IMovementStratergy Stratergy
		{
			get{
				return _movementStratergy;
			}
		}

		public override bool Equals (object obj)
		{
			if (obj == null && !(obj is  Orientation)) {
				return false;
			}

			Orientation passedObject = obj as Orientation;

			return (passedObject._left.Equals(this._left)) && (passedObject._right.Equals(this._right));
		}
	}
}

