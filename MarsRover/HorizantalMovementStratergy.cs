using System;

namespace MarsRover
{
	public class HorizantalMovementStratergy:IMovementStratergy
	{
		public Position Move (Position currentPostion,int unitsToMove)
		{
			return currentPostion.MoveHorizontally (unitsToMove);
		}
	}
}

