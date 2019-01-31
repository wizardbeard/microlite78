using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microlite78.Races
{
	public class Halfling : BaseRace
	{
		new public static readonly Microlite78.CharacterRaces race = CharacterRaces.Halfling;

		// Use this for initialization
		void Start()
		{
			base.CallStart ();
			Debug.Log ("[Halfling] playerCharacter: " + this.playerCharacter);
		}

		// Update is called once per frame
		void Update ()
		{

		}

		public override int GetDEX() {
			return base.GetDEX () + 2;
		}
	}
}
