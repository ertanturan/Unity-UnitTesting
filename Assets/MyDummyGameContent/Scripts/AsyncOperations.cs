using System.Threading.Tasks;

public class AsyncOperations
{
	public async Task<int> DelayedAddAsync(int a, int b, int delayMilliseconds)
	{
		await Task.Delay(delayMilliseconds);
		return a + b;
	}
}