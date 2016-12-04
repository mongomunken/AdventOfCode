namespace AdventOfCode.Core.Year2016.Day1
{
	public struct IntVector2
	{
		public int X { get; set; }
		public int Y { get; set; }

		public IntVector2(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public static IntVector2 operator +(IntVector2 a, IntVector2 b)
		{
			return new IntVector2
			{
				X = a.X + b.X, 
				Y = a.Y + b.Y, 
			};
		}

		public static IntVector2 operator *(IntVector2 a, int b)
		{
			return new IntVector2
			{
				X = a.X * b, 
				Y = a.Y * b, 
			};
		}
	}
}
