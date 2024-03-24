namespace FigureLibrary
{
	public abstract class Figure
	{
		#region Fields

		private readonly Lazy<double> _square;

		#endregion

		#region Properties

		/// <summary>
		/// Площадь фигуры
		/// </summary>
		public double Square => _square.Value;

		#endregion

		protected Figure()
		{
			_square = new Lazy<double>(CalculateSquare);
		}

		#region Methods

		/// <summary>
		/// Вычисление площади
		/// </summary>
		/// <returns></returns>
		protected abstract double CalculateSquare();

		#endregion
	}
}
