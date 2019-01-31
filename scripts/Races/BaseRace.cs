using UnityEngine;
using System.Collections.Generic;
using System;

namespace Microlite78.Races {
	public class BaseRace : MonoBehaviour {
		public static readonly Microlite78.CharacterRaces race;

		public GameObject playerCharacter;

		public static readonly Dictionary<CharacterRaces, System.Type> raceDictionary = new Dictionary<CharacterRaces, System.Type>(){
			{CharacterRaces.Human, typeof(Human)},
			{CharacterRaces.Dwarf, typeof(Human)},
			{CharacterRaces.Elf, typeof(Human)},
			{CharacterRaces.Gnome, typeof(Human)},
			{CharacterRaces.HalfElf, typeof(Human)},
			{CharacterRaces.HalfOrc, typeof(Human)},
			{CharacterRaces.Halfling, typeof(Human)}
		};

		void Start() {
			this.playerCharacter = this.gameObject;
			Debug.Log ("[BaseRace] playerCharacter: " + playerCharacter);
		}

		public void CallStart() {
			this.Start ();
		}

		public virtual int GetSTR () {
			return (this.gameObject.GetComponent<BaseCharacter>()).strength;		
		}

		public virtual int GetDEX () {
			return (this.gameObject.GetComponent<BaseCharacter>()).dexterity;
		}

		public virtual int GetMIND () {
			return (this.gameObject.GetComponent<BaseCharacter>()).mind;
		}

		public virtual int GetCHA () {
			return (this.gameObject.GetComponent<BaseCharacter>()).charisma;
		}

		public virtual int GetPCB () {
			return (this.gameObject.GetComponent<BaseCharacter> ()).physicalCombatBonus;
		}

		public virtual int GetMCB () {
			return (this.gameObject.GetComponent<BaseCharacter> ()).magicalCombatBonus;
		}

		public virtual int GetFB () {
			return (this.gameObject.GetComponent<BaseCharacter> ()).fighterBonus;
		}

		public virtual int GetMEM () {
			return (this.gameObject.GetComponent<BaseCharacter> ()).memorySlots;
		}

		public virtual int GetSave () {
			return (this.gameObject.GetComponent<BaseCharacter> ()).save;
		}

		public virtual int GetXP () {
			return (this.gameObject.GetComponent<BaseCharacter> ()).xp;
		}

		public override string ToString ()
		{
			return string.Format ("[BaseRace]");
		}
	}
}
