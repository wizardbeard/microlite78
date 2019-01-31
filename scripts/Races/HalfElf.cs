using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microlite78.Races
{
	public class HalfElf : BaseRace
	{
		new public static readonly Microlite78.CharacterRaces race = CharacterRaces.HalfElf;

		// Use this for initialization
		void Start()
		{
			base.CallStart ();
			Debug.Log ("[HalfElf] playerCharacter: " + this.playerCharacter);
		}

		// Update is called once per frame
		void Update ()
		{

		}

		public override int GetCHA() {
			return base.GetCHA () + 1;
		}
	}
}