using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microlite78.Races
{
	public class Elf : BaseRace
	{
		new public static readonly Microlite78.CharacterRaces race = CharacterRaces.Elf;

		// Use this for initialization
		void Start()
		{
			base.CallStart ();
			Debug.Log ("[Elf] playerCharacter: " + this.playerCharacter);
		}

		// Update is called once per frame
		void Update ()
		{

		}

		public override int GetMIND() {
			return base.GetMIND() + 2;
		}
	}
}
