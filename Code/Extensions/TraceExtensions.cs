using System.Collections.Generic;

namespace Sandbox;

public static class TraceExtensions
{
	public static SceneTraceResult RunRayTrace( this SceneTrace trace, Ray ray, float distance = 100f, params string[] tags )
	{
		return trace.Ray( ray, distance )
			.WithAnyTags( tags )
			.Run();
	}

	public static IEnumerable<SceneTraceResult> RunAllRayTrace( this SceneTrace trace, Ray ray, float distance = 100f, params string[] tags )
	{
		return trace.Ray( ray, distance )
			.WithAnyTags( tags )
			.RunAll();
	}
}
