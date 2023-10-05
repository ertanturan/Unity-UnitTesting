using System;

public class EventPublisher
{
	public event EventHandler SomethingHappened;

	public void DoSomething()
	{
		// ... do something ...

		// Raise the event
		OnSomethingHappened();
	}

	protected virtual void OnSomethingHappened()
	{
		SomethingHappened?.Invoke(this, EventArgs.Empty);
	}
}