using System;
using System.Linq;
using System.Collections.Generic;

namespace Sandbox;

public static class CollectionExtensions
{
	/// <summary>
	/// Randomizes the order of the elements in the given list in-place
	/// using the Fisher–Yates shuffle algorithm.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="list">
	/// The list whose elements will be shuffled. Its order is modified directly.
	/// </param>
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
	/// Inserts an element into the list at a random position.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="list">The list to insert into.</param>
	/// <param name="item">The element to insert at a random index.</param>
	public static void ShuffleInto<T>( this IList<T> list, T item )
	{
		var n = list.Count;
		var randomIndex = Game.Random.Next( 0, n + 1 );
		list.Insert( randomIndex, item );
	}

	/// <summary>
	/// Combines the hash codes of all elements in the sequence by applying
	/// the given selector and aggregating with <see cref="HashCode.Combine"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the sequence.</typeparam>
	/// <typeparam name="TKey">The type returned by the selector function.</typeparam>
	/// <param name="e">The sequence of elements to hash.</param>
	/// <param name="selector">A function that selects the value to hash for each element.</param>
	/// <returns>A combined hash code representing the sequence.</returns>
	public static int HashCombine<T, TKey>( this IEnumerable<T> e, Func<T, TKey> selector )
	{
		return e.Aggregate( 0, ( current, el ) => HashCode.Combine( current, selector.Invoke( el ) ) );
	}
}
