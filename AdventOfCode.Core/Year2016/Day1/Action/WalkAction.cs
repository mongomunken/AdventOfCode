using AdventOfCode.Core.Year2016.Day1.Facing;

namespace AdventOfCode.Core.Year2016.Day1.Action
{
	public class WalkAction : IAction
	{
		private int steps;

		public WalkAction(int steps)
		{
			this.steps = steps;
		}

		public void Invoke(ref IntVector2 position, ref IFacing facing)
		{
			position += facing.Delta * steps;
		}
	}
}
