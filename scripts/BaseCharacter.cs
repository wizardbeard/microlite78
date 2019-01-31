using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Microlite78.Races;
using Microlite78.Classes;
using Microlite78.SpecialAbilities;

namespace Microlite78
{
	public class BaseCharacter : MonoBehaviour
	{

		public GameMaster gameMaster;

		public string characteName;
		public CharacterRaces characterRace;
		public PlayerBaseClasses playerClass;
		public int level = 0;
		public int xp = 0;
		public int hp = 0;

		public int physicalCombatBonus = 0;
		public int magicalCombatBonus = 0;
		public int fighterBonus = 0;
		public int memorySlots = 0;
		public int save = 0;

		public int strength = 0;
		public int dexterity = 0;
		public int mind = 0;
		public int charisma = 0;

		/// <summary>
		/// Throws UnassignedReferenceException if parent gameObject doesn't have an attached SpriteRender.
		/// </summary>
		public SpriteRenderer spriteRenderer;

		public BaseRace racialModifiers;

		public PlayerBaseClass classModifiers;

		public List<BaseSpecialAbility> specialAbilities = new List<BaseSpecialAbility>();

		// Use this for initialization
		void Start ()
		{
			if (gameMaster == null) {
				gameMaster = this.gameObject.GetComponentsInParent<GameMaster> ()[0];
			}

			// Random character generation on startup.
			rollRandomRace ();
			rollRandomStats ();
			rollRandomClass ();

			Debug.Log ("Spawning character: " + ToString ());
			Debug.Log ("Racial Bonuses: " + RaceToString());


			// Initialize Sprite based on Character:
			if (spriteRenderer != null) {
				Debug.Log (spriteRenderer.gameObject);
			}

			// Level up from 0
//			gameMaster.levelUp();

			// Set Health object
			gameMaster.health = this.gameObject.GetComponentInChildren(typeof(Health)) as Health;
			Debug.Log (String.Format ("[Health] {0}", gameMaster.health));

			// Set the Number of Hearts to the randomly generated stats from above:
			gameMaster.health.currentHealth = this.hp;
			gameMaster.health.health.numberOfHearts = this.hp;

			// TODO: Randomly generate equipment.

			// TODO: Randomly generate skills, feats, etc.
		}
	
		// Update is called once per frame
		void Update ()
		{
			//rotateSprite ();
		}

		public override string ToString ()
		{
			return string.Format ("[BaseCharacter]"
			+ " Name: " + characteName
			+ ", Race: " + characterRace
			+ ", Class: " + playerClass
			+ ", STR: " + strength
			+ ", DEX: " + dexterity
			+ ", MIND: " + mind
			+ ", CHA: " + charisma);
		}

		public string RaceToString ()
		{
			return string.Format ("[{6}][{7}] Name: {0}, XP: {13}, Race: {1}, STR: {2}, DEX: {3}, MIND: {4}, CHA: {5}, PCB: {8}, MCB: {9}, FB: {10}, Mem. Slots: {11}, Save: {12}", 
				characteName, 
				characterRace, 
				racialModifiers.GetSTR(), 
				racialModifiers.GetDEX(), 
				racialModifiers.GetMIND(), 
				racialModifiers.GetCHA(),
				characterRace,
				playerClass,
				racialModifiers.GetPCB(),
				racialModifiers.GetMCB(),
				racialModifiers.GetFB(),
				racialModifiers.GetMEM(),
				racialModifiers.GetSave(),
				racialModifiers.GetXP());
		}

		public void rollRandomStats ()
		{
			strength = DiceRoller.roll (4, 0, true);
			dexterity = DiceRoller.roll (4, 0, true);
			mind = DiceRoller.roll (4, 0, true);
			charisma = DiceRoller.roll (4, 0, true);
		}

		public void rollRandomRace ()
		{
			var randomIndex = UnityEngine.Random.Range (0, Enum.GetNames (typeof(CharacterRaces)).Length);

			characterRace = (CharacterRaces)randomIndex;

			switch (characterRace) {
			case CharacterRaces.Human:
				racialModifiers = this.gameObject.AddComponent<Human> ();
				break;
			case CharacterRaces.Dwarf:
				racialModifiers = this.gameObject.AddComponent<Dwarf> ();
				break;
			case CharacterRaces.Elf:
				racialModifiers = this.gameObject.AddComponent<Elf> ();
				break;
			case CharacterRaces.Gnome:
				racialModifiers = this.gameObject.AddComponent<Gnome> ();
				break;
			case CharacterRaces.HalfElf:
				racialModifiers = this.gameObject.AddComponent<HalfElf> ();
				break;
			case CharacterRaces.HalfOrc:
				racialModifiers = this.gameObject.AddComponent<HalfOrc> ();
				break;
			case CharacterRaces.Halfling:
				racialModifiers = this.gameObject.AddComponent<Halfling> ();
				break;
			default:
				break;
			}
		}

		public void rollRandomClass() {
			var randomIndex = UnityEngine.Random.Range (0, Enum.GetNames (typeof(PlayerBaseClasses)).Length);

			playerClass = (PlayerBaseClasses)randomIndex;

			switch (playerClass) {
			case PlayerBaseClasses.Fighter:
				classModifiers = this.gameObject.AddComponent<Fighter> ();
				break;
			case PlayerBaseClasses.MagicUser:
				classModifiers = this.gameObject.AddComponent<MagicUser> ();
				break;
			case PlayerBaseClasses.Cleric:
				classModifiers = this.gameObject.AddComponent<Cleric> ();
				break;
			case PlayerBaseClasses.Thief:
				classModifiers = this.gameObject.AddComponent<Thief> ();
				break;
			default:
				break;
			}
		}

		private void rotateSprite ()
		{
			spriteRenderer.transform.Rotate (new Vector3 (){ x = 10.0f, y = 10.0f, z = 10.0f });
		}
	}
}