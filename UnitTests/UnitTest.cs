global using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WackyLib.Tests;

[TestClass]
public class TestInit
{
	[AssemblyInitialize]
	public static void ClassInitialize( TestContext context )
	{
		Sandbox.Application.InitUnitTest<TestInit>( false );
	}

	[AssemblyCleanup]
	public static void AssemblyCleanup()
	{
		Sandbox.Application.ShutdownUnitTest();
	}
}
