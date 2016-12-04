using AdventOfCode.Core.Year2016.Day1.Facing;

namespace AdventOfCode.Core.Year2016.Day1.Action
{
	public interface IAction
	{
		void Invoke(ref IntVector2 position, ref IFacing facing);
	}
}
