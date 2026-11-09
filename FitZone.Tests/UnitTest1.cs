namespace FitZone.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			//A   Arrange
			int a = 5;
			int b = 10;


			//A   Act
			int sum = a + b;


			//A   Assert
			Assert.Equal(15, sum);

		}


		[Fact]
		public void Test2()
		{
			//A   Arrange
			int a = 5;
			int b = 5;


			//A   Act
			int sum = a + b;


			//A   Assert
			Assert.Equal(10, sum);

		}

	}
}
