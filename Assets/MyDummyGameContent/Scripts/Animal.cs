public class Animal
{
	public virtual string Name { get; set; }
	public virtual int Legs { get; set; }
}

public class Lion : Animal
{
	public override int Legs
	{
		get;
		set;
	} = 4;

	public override string Name
	{
		get;
		set;
	} = "Lion";
}

public class Sparrow : Animal
{
	public override int Legs
	{
		get;
		set;
	} = 2;

	public override string Name
	{
		get;
		set;
	} = "Sparrow";
}