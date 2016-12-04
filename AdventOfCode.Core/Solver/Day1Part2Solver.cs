using AdventOfCode.Core.Year2016.Day1;
using AdventOfCode.Core.Year2016.Day1.Action;
using AdventOfCode.Core.Year2016.Day1.Facing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Core.Solver
{
	public class Day1Part2Solver : ISolver
	{
		public string Solve(string input)
		{
			var actionParser = new ActionParser(input, ActionParserFlags.OneWalkActionPerStep);
			var position = new IntVector2(0, 0);
			var facing = Facing.North;
			var visitedPositions = new List<IntVector2>();

			foreach (IAction action in actionParser.GetActions())
			{
				action.Invoke(ref position, ref facing);

				if(action is WalkAction)
				{
					if(visitedPositions.Contains(position))
					{
						break;
					}

					visitedPositions.Add(position);
				}
			}

			int distance = Math.Abs(position.X) + Math.Abs(position.Y);

			return distance.ToString();
		}
	}
}
