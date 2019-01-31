using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microlite78.Races
{
	public class Dwarf : BaseRace
	{
		new public static readonly Microlite78.CharacterRaces race = CharacterRaces.Dwarf;

		// Use this for initialization
		void Start()
		{
			base.CallStart ();
			Debug.Log ("[Dwarf] playerCharacter: " + this.playerCharacter);
		}

		// Update is called once per frame
		void Update ()
		{

		}

		public override int GetSTR() {
			return base.GetSTR() + 2;
		}
	}
}
