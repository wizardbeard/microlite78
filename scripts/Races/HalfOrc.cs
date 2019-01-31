using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microlite78.Races
{
	public class HalfOrc : BaseRace
	{
		new public static readonly Microlite78.CharacterRaces race = CharacterRaces.HalfOrc;

		// Use this for initialization
		void Start()
		{
			base.CallStart ();
			Debug.Log ("[HalfOrc] playerCharacter: " + this.playerCharacter);
		}

		// Update is called once per frame
		void Update ()
		{

		}

		public override int GetSTR() {
			return base.GetSTR () + 2;
		}

		public override int GetDEX() {
			return base.GetDEX () + 2;
		}

		public override int GetCHA() {
			return base.GetCHA () - 2;
		}
	}
}
