using System;

public class ArrayProcessor
{
	public int[] DoubleArrayValues(int[] array)
	{
		if (array == null)
		{
			throw new ArgumentNullException(nameof(array));
		}

		for (int i = 0; i < array.Length; i++)
		{
			array[i] *= 2;
		}

		return array;
	}
}