using System.Collections.Generic;

namespace Sandbox;

public static class TraceExtensions
{
	/// <summary>
	/// Run a ray trace to the following distance.
	/// </summary>
	/// <returns>Result of the trace.</returns>
	public static SceneTraceResult RunRayTrace( this SceneTrace trace, Ray ray, float distance = 100f, params string[] withTags )
	{
		return trace.Ray( ray, distance )
			.WithAnyTags( withTags )
			.Run();
	}

	/// <summary>
	/// Run a ray trace to the following distance.
	/// </summary>
	/// <returns>Results of the trace.</returns>
	public static IEnumerable<SceneTraceResult> RunAllRayTrace( this SceneTrace trace, Ray ray, float distance = 100f, params string[] withTags )
	{
		return trace.Ray( ray, distance )
			.WithAnyTags( withTags )
			.RunAll();
	}
}
