using System;

namespace MarsRover
{
	public class VerticalMovementStratergy:IMovementStratergy
	{
		public Position Move (Position currentPostion,int unitsToMove)
		{
			return currentPostion.MoveVerticaly (unitsToMove);
		}
	}
}
