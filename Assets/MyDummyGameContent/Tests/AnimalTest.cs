using NUnit.Framework;

[TestFixture]
public class AnimalTest
{
	[Test]
	[Category("Mammals")]
	public void Animal_HasFourLegs()
	{
		Animal lion = new();
		lion.Legs = 4;
		lion.Name = "Lion";

		Assert.That(lion.Legs, Is.EqualTo(4));
	}

	[Test]
	[Category("Birds")]
	public void Animal_HasTwoLegs()
	{
		Animal pigeon = new();
		pigeon.Legs = 2;
		pigeon.Name = "Pigeion";

		Assert.That(pigeon.Legs, Is.EqualTo(2));
	}
}