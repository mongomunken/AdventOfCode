namespace AdventOfCode.Core.Year2016.Day1.Facing
{
	public abstract class Facing : IFacing
	{
		public abstract IntVector2 Delta { get; }
		public abstract IFacing Left { get; }
		public abstract IFacing Right { get; }

		private Facing()
		{
		}

		public static IFacing North { get; } = new NorthFacing();
		public static IFacing East { get; } = new EastFacing();
		public static IFacing South { get; } = new SouthFacing();
		public static IFacing West { get; } = new WestFacing();

		private class NorthFacing : Facing
		{
			public override IntVector2 Delta { get; } = new IntVector2(0, -1);
			public override IFacing Left => West;
			public override IFacing Right => East;
		}

		private class EastFacing : Facing
		{
			public override IntVector2 Delta { get; } = new IntVector2(1, 0);
			public override IFacing Left => North;
			public override IFacing Right => South;
		}

		private class SouthFacing : Facing
		{
			public override IntVector2 Delta { get; } = new IntVector2(0, 1);
			public override IFacing Left => East;
			public override IFacing Right => West;
		}

		private class WestFacing : Facing
		{
			public override IntVector2 Delta { get; } = new IntVector2(-1, 0);
			public override IFacing Left => South;
			public override IFacing Right => North;
		}
	}
}
