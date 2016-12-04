namespace AdventOfCode.Core.Year2016.Day1.Facing
{
	public interface IFacing
	{
		IntVector2 Delta { get; }
		IFacing Left { get; }
		IFacing Right { get; }
	}
}
