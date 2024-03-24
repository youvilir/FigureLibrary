using FigureLibrary.Objects;

namespace Figure.Tests
{
	[TestFixture]
	public class CircleTests
	{
		[Test]
		[TestCase(0)]
		[TestCase(-10)]
		[TestCase(-0.2)]
		public void WhenRadiusIsNotValid_ThenExceptionIsThrown(double radius)
		{
			Assert.Catch<ArgumentOutOfRangeException>(() =>
			{
				var circle = new Circle(radius);
			});
		}

		[Test]
		[TestCase(1)]
		[TestCase(10)]
		[TestCase(0.2)]
		public void WhenRadiusIsValid_ThenReturnSuccess(double radius)
		{
			Assert.DoesNotThrow(() =>
			{
				var circle = new Circle(radius);
			});
		}

		[Test]
		[TestCase(1)]
		[TestCase(10)]
		[TestCase(0.2)]
		public void WhenRadiusIsValid_ThenCalculatedSquareIsRigth(double radius)
		{
			var circle = new Circle(radius);
			var square = Math.PI * radius * radius;

			Assert.That(circle.Square, Is.EqualTo(square));
		}
	}
}