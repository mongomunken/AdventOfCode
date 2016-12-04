using System;
using System.Collections.Generic;

namespace AdventOfCode.Core.Year2016.Day1.Action
{
	[Flags]
	public enum ActionParserFlags
	{
		None = 0, 
		OneWalkActionPerStep = 1, 
	}

	public class ActionParser
	{
		private string input;
		private ActionParserFlags flags;

		public ActionParser(string input, ActionParserFlags flags = ActionParserFlags.None)
		{
			this.input = input;
			this.flags = flags;
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

				if(flags.HasFlag(ActionParserFlags.OneWalkActionPerStep))
				{
					for(int i = 0; i < steps; i++)
					{
						yield return new WalkAction(1);
					}
				}
				else
				{
					yield return new WalkAction(steps);
				}
			}
		}
	}
}
