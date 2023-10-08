using System.Collections;
using NUnit.Framework;

[TestFixture]
public class MasthOperationsTest
{
	[Test]
	[TestCaseSource(nameof(AddTestCases))]
	public void Add_WhenCalled_ReturnsSum(int a, int b, int expectedResult)
	{
		int result = MathOperations.Add(a, b);

		Assert.That(result, Is.EqualTo(expectedResult));
	}

	[Test]
	public void MultiplyByTwo_WhenCalled_ReturnsDoubledValue(
		[Range(1, 2)] int a, [Values(2, 4, 6, 8, 10)] int expectedResult)
	{
		int result = MathOperations.MultiplyByTwo(a);

		Assert.That(result, Is.EqualTo(expectedResult));
	}

	private static IEnumerable AddTestCases()
	{
		yield return new TestCaseData(2, 5, 7);
		yield return new TestCaseData(1, 2, 3);
		yield return new TestCaseData(20, 30, 50);
		yield return new TestCaseData(20, 30, 50);
		yield return new TestCaseData(20, 30, 50);
		yield return new TestCaseData(20, 30, 50);
		yield return new TestCaseData(20, 30, 50);
		yield return new TestCaseData(20, 30, 50);
		yield return new TestCaseData(20, 30, 50);
	}
}