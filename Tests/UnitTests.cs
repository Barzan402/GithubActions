namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Mustafa()
	{
		Assert.AreEqual(3, Program.Power("1", "2"));
		Assert.AreEqual(5, Program.Power("3", "2"));
		Assert.AreEqual(12, Program.Power("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Mustafa()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Mustafa()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
	}
}
