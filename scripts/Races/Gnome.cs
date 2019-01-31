using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microlite78.Races
{
	public class Gnome : BaseRace
	{
		new public static readonly Microlite78.CharacterRaces race = CharacterRaces.Gnome;

		// Use this for initialization
		void Start()
		{
			base.CallStart ();
			Debug.Log ("[Gnome] playerCharacter: " + this.playerCharacter);
		}

		// Update is called once per frame
		void Update ()
		{

		}

		public override int GetSTR() {
			return base.GetSTR() + 1;
		}

		public override int GetDEX() {
			return base.GetDEX () + 1;
		}
	}
}
