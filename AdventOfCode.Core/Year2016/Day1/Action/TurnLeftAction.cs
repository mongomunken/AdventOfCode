using AdventOfCode.Core.Year2016.Day1.Facing;

namespace AdventOfCode.Core.Year2016.Day1.Action
{
	public class TurnLeftAction : IAction
	{
		public void Invoke(ref IntVector2 position, ref IFacing facing)
		{
			facing = facing.Left;
		}
	}
}
