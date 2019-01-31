using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microlite78.Races
{
	public class Human : BaseRace
	{
		new public static readonly Microlite78.CharacterRaces race = CharacterRaces.Human;

		// Use this for initialization
		void Start()
		{
			base.CallStart ();
			Debug.Log ("[Human] playerCharacter: " + this.playerCharacter);
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}

		public override int GetSTR() {
			return base.GetSTR() + 1;
		}

		public override int GetMIND() {
			return base.GetMIND () + 1;
		}
	}
}