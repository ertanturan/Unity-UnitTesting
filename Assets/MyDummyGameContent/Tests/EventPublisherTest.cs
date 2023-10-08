using System;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

[TestFixture]
public class EventPublisherTest
{
	private GameObject testerObject;

	[SetUp]
	public void Setup()
	{
		testerObject = new GameObject("Tester Object");
	}

	[TearDown]
	public void Teardown()
	{
		Object.DestroyImmediate(testerObject);
	}

	[Test]
	public void DoSomething_WhenCalled_InvokesEvent()
	{
		EventPublisher eventPublisher = testerObject.AddComponent<EventPublisher>();
		eventPublisher.SomethingHappened = new UnityEvent<object, EventArgs>();

		bool isEventInvoked = false;

		eventPublisher.SomethingHappened.AddListener((arg0, args) =>
		{
			isEventInvoked = true;
		});

		eventPublisher.DoSomething();

		Assert.That(isEventInvoked, Is.True);
	}
}