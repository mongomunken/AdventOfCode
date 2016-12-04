using System;
using System.Collections.Generic;

namespace AdventOfCode.Core.Year2016.Day1.Action
{
	public class ActionParser
	{
		private string input;

		public ActionParser(string input)
		{
			this.input = input;
		}

		public IEnumerable<IAction> GetActions()
		{
			string[] instructions = input.Split(new string[] { ", " }, StringSplitOptions.None);

			foreach (string instruction in instructions)
			{
				char turn = instruction[0];
				int steps = int.Parse(instruction.Substring(1));

				switch (turn)
				{
					case 'L':
					yield return new TurnLeftAction();
					break;
					case 'R':
					yield return new TurnRightAction();
					break;
					default:
					throw new InvalidOperationException();
				}

				yield return new WalkAction(steps);
			}
		}
	}
}
