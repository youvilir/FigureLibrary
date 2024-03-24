namespace FigureLibrary.Objects
{
	public class Triangle : Figure
	{
		#region Fields

		private readonly Lazy<bool> _isRightAngled;

		#endregion

		#region Properties

		public double SideA { get; }

		public double SideB { get; }

		public double SideC { get; }

		public bool IsRightAngled => _isRightAngled.Value;

		#endregion

		public Triangle(double sideA, double sideB, double sideC)
		{
			if (sideA <= 0 || sideB <= 0 || sideC <= 0)
				throw new ArgumentOutOfRangeException("Сторона не может быть меньше нуля");

			if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideC + sideB <= sideA)
				throw new ArgumentOutOfRangeException("Треугольник не существует");

			SideA = sideA;
			SideB = sideB;
			SideC = sideC;

			_isRightAngled = new Lazy<bool>(CheckIsRightAngled);
		}

		#region Methods

		/// <summary>
		/// Проверка на прямоугольность
		/// </summary>
		/// <returns></returns>
		private bool CheckIsRightAngled()
		{
			var sides = new[] { SideA, SideB, SideC }.OrderBy(side => side).ToArray();

			double hypotenuse = sides[2];
			double firstCathetus = sides[1];
			double secondCathetus = sides[0];

			return hypotenuse * hypotenuse == firstCathetus * firstCathetus + secondCathetus * secondCathetus;
		}

		protected sealed override double CalculateSquare()
		{
			var semiPerimeter = (SideA + SideB + SideC) / 2;

			return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
		}

		#endregion
	}
}
