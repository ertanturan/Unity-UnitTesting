using System;

public class StringUtilities
{
	public string ConcatenateStrings(string str1, string str2)
	{
		return str1 + str2;
	}

	public bool IsStringEmpty(string input)
	{
		return string.IsNullOrEmpty(input);
	}

	public string GetSubstring(string input, int startIndex, int length)
	{
		if (startIndex < 0 || startIndex >= input.Length)
		{
			throw new ArgumentOutOfRangeException(nameof(startIndex));
		}

		if (length <= 0 || startIndex + length > input.Length)
		{
			throw new ArgumentOutOfRangeException(nameof(length));
		}

		return input.Substring(startIndex, length);
	}
}