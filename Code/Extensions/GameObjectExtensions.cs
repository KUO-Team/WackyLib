namespace Sandbox;

public static class GameObjectExtensions
{
	/// <summary>
	/// Clones and network spawns this GameObject.
	/// </summary>
	/// <param name="gameObject">GameObject to spawn.</param>
	/// <param name="owner">Connection to set as the owner.</param>
	/// <param name="config">Clone configuration.</param>
	/// <returns>Spawned GameObject</returns>
	public static GameObject Spawn( this GameObject gameObject, Connection owner, CloneConfig config = default )
	{
		var go = gameObject.Clone( config );
		go.NetworkSpawn( owner );

		return go;
	}
}
