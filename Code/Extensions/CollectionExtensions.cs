using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox;

public static class CollectionExtensions
{
	/// <summary>
	/// Shuffles the list.
	/// </summary>
	/// <param name="list">List to shuffle.</param>
	public static void Shuffle<T>( this IList<T> list )
	{
		var n = list.Count;
		while ( n > 1 )
		{
			n--;
			var k = Game.Random.Next( 0, n + 1 );
			(list[n], list[k]) = (list[k], list[n]);
		}
	}

	/// <summary>
	/// Shuffles the element into a random position on the list.
	/// </summary>
	/// <param name="list">List to shuffle into.</param>
	/// <param name="item">Element to insert</param>
	public static void ShuffleInto<T>( this IList<T> list, T item )
	{
		var n = list.Count;
		var randomIndex = Game.Random.Next( 0, n + 1 );
		list.Insert( randomIndex, item );
	}

	public static int HashCombine<T, TKey>( this IEnumerable<T> e, Func<T, TKey> selector )
	{
		return e.Aggregate( 0, ( current, el ) => HashCode.Combine( current, selector.Invoke( el ) ) );
	}
}
