using FigureLibrary.Objects;

namespace Figure.Tests
{
	[TestFixture]
	public class TriangleTests
	{
		[Test]
		[TestCase(0, 1, 2)]
		[TestCase(-10, 1, 2)]
		[TestCase(1, -0.2, 15)]
		[TestCase(1, 2, 3)]
		public void WhenParametrsAreNotValid_ThenExceptionIsThrown(double sideA, double sideB, double sideC)
		{
			Assert.Catch<ArgumentOutOfRangeException>(() =>
			{
				var triangle = new Triangle(sideA, sideB, sideC);
			});
		}

		[Test]
		[TestCase(3, 4, 6)]
		[TestCase(6, 8, 10)]
		[TestCase(14, 13, 6)]
		[TestCase(9, 9, 4)]
		[TestCase(6, 6, 6)]
		public void WhenParametrsAreValid_ThenReturnSuccess(double sideA, double sideB, double sideC)
		{
			Assert.DoesNotThrow(() =>
			{
				var triangle = new Triangle(sideA, sideB, sideC);
			});
		}

		[Test]
		[TestCase(3, 4, 6)]
		[TestCase(6, 8, 10)]
		[TestCase(14, 13, 6)]
		[TestCase(9, 9, 4)]
		[TestCase(6, 6, 6)]
		public void WhenParametrsAreValid_ThenCalculatedSquareIsRigth(double sideA, double sideB, double sideC)
		{
			var triangle = new Triangle(sideA, sideB, sideC);
			var semiPerimeter = (sideA + sideB + sideC) / 2;
			var square = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

			Assert.That(triangle.Square, Is.EqualTo(square));
		}

		[Test]
		[TestCase(3, 4, 5)]
		[TestCase(6, 8, 10)]
		[TestCase(16, 12, 20)]
		[TestCase(12, 9, 15)]
		public void WhenParametrsForRightTriangle_ThenReturnRightTriangle(double sideA, double sideB, double sideC)
		{
			var triangle = new Triangle(sideA, sideB, sideC);

			Assert.That(triangle.IsRightAngled, Is.True);
		}

		[Test]
		[TestCase(3, 4, 6)]
		[TestCase(14, 13, 6)]
		[TestCase(9, 9, 4)]
		[TestCase(6, 6, 6)]
		public void WhenParametrsForNonRightTriangle_ThenReturnTriangle(double sideA, double sideB, double sideC)
		{
			var triangle = new Triangle(sideA, sideB, sideC);

			Assert.That(triangle.IsRightAngled, Is.False);
		}
	}
}
