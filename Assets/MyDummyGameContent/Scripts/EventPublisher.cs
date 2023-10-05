using System;
using UnityEngine;
using UnityEngine.Events;

public class EventPublisher : MonoBehaviour
{
	public UnityEvent<object, EventArgs> SomethingHappened;

	public void DoSomething()
	{
		// ... do something ...

		// Fire the event
		OnSomethingHappened();
	}

	protected virtual void OnSomethingHappened()
	{
		SomethingHappened?.Invoke(this, EventArgs.Empty);
	}
}