using NUnit.Framework;

[TestFixture]
public class StringUtilitiesTest
{
	[Test]
	public void ConcatenateStrings_WhenCalled_ReturnsMergedString()
	{
		// 1. Arrange

		string firstString = "Hello ";
		string secondString = "world !";

		string expectedResult = "Hello world !";
		StringUtilities utils = new();

		// 2. Act

		string result = utils.ConcatenateStrings(firstString, secondString);

		// 3.Assert

		Assert.That(result, Is.Not.Empty);
		Assert.That(result, Is.Not.Null);
		Assert.That(result, Is.EqualTo(expectedResult));
	}


	[Ignore("The feature is still on development so the test is ignored !")]
	public void GetSubstring_WhenStartIndexIsBelowZero_ThrowsArgumentException()
	{
		string inputString = "Hello World !";
		int startIndex = -1;
		int length = 5;

		StringUtilities utils = new();

		Assert.That(() =>
		{
			utils.GetSubstring(inputString, startIndex, length);
		}, Throws.Exception);
	}
}