namespace FigureLibrary.Objects
{
	public class Circle : Figure
	{
		#region Properties

		public double Radius { get; }

		#endregion

		public Circle(double radius)
		{
			Console.WriteLine("Circle");
			if (radius <= 0)
				throw new ArgumentOutOfRangeException("Радиус не может быть меньше нуля");

			Radius = radius;

		}

		#region Methods

		protected sealed override double CalculateSquare()
		{
			return Math.PI * Radius * Radius;
		}

		#endregion
	}
}
