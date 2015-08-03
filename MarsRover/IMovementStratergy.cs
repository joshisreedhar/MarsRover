using System;

namespace MarsRover
{
	public interface IMovementStratergy
	{
		Position Move(Position currentPosition, int unitsToMove);
	}
}

