using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace Microlite78
{
	// <summary>
	// Utility class to roll dice in a familiar paradigm; i.e., 2d6+0
	// During stat rolls, we want to drop the lowest value.
	// </summary>
	public static class DiceRoller
	{
		public static int roll (int numberOfDice, int modifier = 0, bool dropLowestResult = false, int sides = 6)
		{
			var values = new int[numberOfDice];
			int result = 0;

			for (int i = 0; i < numberOfDice; i++) {
				var r = UnityEngine.Random.Range (1, sides);

				values [i] = r;

				result += r;
			}

			result += modifier;

			if (dropLowestResult) {

				var sortedResults = values.OrderBy (i => i).ToArray ();

				return (result - sortedResults [0]);
			} else {
				return result;
			}
		}

		private class StatIntComparer : IComparer<int> {
			public int Compare ( int x, int y ) {
				return x.CompareTo (y);
			}
		}
	}
}