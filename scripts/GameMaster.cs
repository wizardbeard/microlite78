using System;
using System.Collections.Generic;
using UnityEngine;
using Microlite78.Classes;
using Microlite78.AdvancementTables;

namespace Microlite78
{
	// <summary>
	// Our game is controlled by a Game Master, and GM operations are expressed in this class.
	// 
	// TODO: each game level should roughly correspond with the XP level of the Player Character meaning there should be enough enemies, etc. to level up at least once per stage/scene/etc.
	// </summary>
	public class GameMaster : MonoBehaviour
	{
		private object _lockObj = new object ();
		
		// Microlite78
		public AdvancementDictionary advancementTable; 
		public BaseCharacter playerCharacter;

		// AllInOneGameKitELC
		public Health health;
		public ItemManager inventory;

		void Start ()
		{
			try {

				if (playerCharacter == null) {
					lock (_lockObj) {
						playerCharacter = this.gameObject.GetComponentInChildren (typeof(BaseCharacter)) as BaseCharacter;
					}
				}

				if (advancementTable == null && playerCharacter != null) {
					lock (_lockObj) {
						getAdvancementTable ();
					}
				}

				// Let's go to Level and apply stats from the Level 1 Advancement Table
				if (playerCharacter.level == 0) {
					levelUp ();
				}
			}
			catch (Exception e) {
				Util.LogException (e);
			}
		}

		void Update ()
		{
		}

		public GameMaster addXp (BaseCharacter playerCharacter, int xp)
		{
			try {
				// Add the XP
				playerCharacter.xp += xp;

				// Should we level up?
				this.canLevelUp();

			} catch (Exception e) {
				Util.LogException (e);
			}

			return this;
		}

		public GameMaster removeXp (int xp)
		{
			try {
				// Remove the XP
				playerCharacter.xp -= xp;

				if (playerCharacter.xp <= 0) {
					playerCharacter.xp = 0;
				}
			} catch (Exception e) {
				Util.LogException (e);
			}

			return this;
		}

		public GameMaster addHp (int hp)
		{
			try {
				// Add the HP
				playerCharacter.hp += hp;
			} catch (Exception e) {
				Util.LogException (e);
			}

			return this;
		}

		public GameMaster removeHp (int hp)
		{
			try {
				playerCharacter.hp -= hp;
			} catch (Exception e) {
				Util.LogException (e);
			}

			return this;
		}

		// <summary>
		// Level Up a Player Character
		//
		// TODO: implement logic based on numberOfLevels
		// </summary>
		public GameMaster levelUp (int numberOfLevels = 1)
		{
			if (playerCharacter.level == 20) {
				return this;
			}

			try {
				// TODO: examine the playerCharacter - and possibly use a lock - to levelup up according to the AdvancementTables

				object lockObj = new object ();
				lock (lockObj) {
					playerCharacter.level += numberOfLevels;

					// TODO: add modifiers from the advancementTable
					playerCharacter.hp = advancementTable [playerCharacter.level]["hp"]; // TODO: replace strings with constants
					playerCharacter.physicalCombatBonus = advancementTable [playerCharacter.level]["physicalCombatBonus"];
					playerCharacter.magicalCombatBonus = advancementTable [playerCharacter.level]["magicalCombatBonus"];
					playerCharacter.fighterBonus = advancementTable [playerCharacter.level]["fighterBonus"];
					playerCharacter.memorySlots = advancementTable [playerCharacter.level]["memorySlots"];
					playerCharacter.save = advancementTable [playerCharacter.level]["save"];
				}
			} catch (Exception e) {
				Util.LogException (e);
			}

			return this;
		}

		// TODO: modify stats bases on Advancement Tables including XP
		public GameMaster levelDown (int numberOfLevels = 1)
		{
			if (playerCharacter.level == 1) {
				return this;
			} else {
				try {
					object lockObj = new object ();
					lock (lockObj) {
						playerCharacter.level -= numberOfLevels;
					}
				} catch (Exception e) {
					Util.LogException (e);
				}
			}

			return this;
		}

		public GameMaster getAdvancementTable () 
		{

			if (this.advancementTable == null) {
				switch (playerCharacter.playerClass) {
				case PlayerBaseClasses.Fighter:
					this.advancementTable = BasicAdvancementTables.Fighter;
					break;
				case PlayerBaseClasses.MagicUser:
					this.advancementTable = BasicAdvancementTables.MagicUser;
					break;
				case PlayerBaseClasses.Cleric:
					this.advancementTable = BasicAdvancementTables.Cleric;
					break;
				case PlayerBaseClasses.Thief:
					this.advancementTable = BasicAdvancementTables.Thief;
					break;
				default:
					break;
				} 
			}

			return this;
		}

		public GameMaster canLevelUp () 
		{
			try {
				object lockObj = new object ();

				if (advancementTable == null) {
					lock (lockObj) {
						getAdvancementTable ();
					}
				}

				if (playerCharacter.xp >= advancementTable [playerCharacter.level]["xp"]) {
					this.levelUp();
				}
			}
			catch (Exception e) {
				Util.LogException (e);
			}

			return this;
		}
	}
}

