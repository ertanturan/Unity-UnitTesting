using NUnit.Framework;

[TestFixture]
public class ArrayProcessorTest
{
	[Test]
	public void DoubleArrayValues_WhenGivenIntegerArray_ReturnsDoubledValues()
	{
		ArrayProcessor arrayProcessor = new();
		int[] inputArray = {1, 2, 3, 4, 5};

		int[] result = arrayProcessor.DoubleArrayValues(inputArray);
		int[] expectedResult = {2, 4, 6, 8, 10};


		Assert.That(result, Is.Not.Empty);
		Assert.That(result, Is.Not.Null);
		Assert.That(result.Length, Is.EqualTo(expectedResult.Length));
		Assert.That(result, Is.EqualTo(expectedResult));

		Assert.That(result, Does.Contain(2));
		Assert.That(result, Does.Contain(4));
		Assert.That(result, Does.Contain(6));
		Assert.That(result, Does.Contain(8));
		Assert.That(result, Does.Contain(10));
	}
}