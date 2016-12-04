using AdventOfCode.Core.Year2016.Day1;
using AdventOfCode.Core.Year2016.Day1.Action;
using AdventOfCode.Core.Year2016.Day1.Facing;
using System;

namespace AdventOfCode.Core.Solver
{
	public class Day1Part1Solver : ISolver
	{
		public string Solve(string input)
		{
			var actionParser = new ActionParser(input);
			var position = new IntVector2(0, 0);
			var facing = Facing.North;

			foreach (IAction action in actionParser.GetActions())
			{
				action.Invoke(ref position, ref facing);
			}

			int distance = Math.Abs(position.X) + Math.Abs(position.Y);

			return distance.ToString();
		}
	}
}
