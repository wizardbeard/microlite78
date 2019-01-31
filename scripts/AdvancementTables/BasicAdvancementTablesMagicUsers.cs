using System;
using System.Collections.Generic;

namespace Microlite78.AdvancementTables
{
	// <summary>
	// Advancement Tables determine the bonuses and XP thresholds for each level (1 - 20)
	// for each playable Class.
	//
	// The "hp" stat for each level is determined by a dice roll, and this dice is rolled once
	// per game.  This means that each game we play will have variations; some larger than others.
	// </summary>
	public static partial class BasicAdvancementTables
	{
		public static AdvancementDictionary MagicUser = new AdvancementDictionary () { 
			// MagicUser - Level 1
			{1, new Dictionary<string, int> () {
					{ "hp", DiceRoller.roll(1, 0, false, 4) },	// 1d4
					{ "physicalCombatBonus", 0 },
					{ "magicalCombatBonus", 0 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 1 },
					{ "save", 16 },
					{ "xp", 0 },
				}},

			// MagicUser - Level 2
			{2, new Dictionary<string, int> (){
					{ "hp", DiceRoller.roll(2, 0, false, 4) },	// 2d4
					{ "physicalCombatBonus", 0 },
					{ "magicalCombatBonus", 0 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 2 },
					{ "save", 15 },
					{ "xp", 2500 },
				}},

			// MagicUser - Level 3
			{3, new Dictionary<string, int>(){
					{ "hp", DiceRoller.roll(3, 0, false, 4) },	// 3d4
					{ "physicalCombatBonus", 0 },
					{ "magicalCombatBonus", 1 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 3 },
					{ "save", 14 },
					{ "xp", 5000 },
				}},

			// MagicUser - Level 4
			{4, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(4, 0, false, 4) },	// 4d4
					{ "physicalCombatBonus", 1 },
					{ "magicalCombatBonus", 2 },
					{ "fighterBonus", 2 },
					{ "memorySlots", 4 },
					{ "save", 13 },
					{ "xp", 10000 },
				}},

			// MagicUser - Level 5
			{5, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(5, 0, false, 4) },	// 5d4
					{ "physicalCombatBonus", 1 },
					{ "magicalCombatBonus", 3 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 5 },
					{ "save", 11 },
					{ "xp", 20000 },
				}},

			// MagicUser - Level 6
			{6, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(6, 0, false, 4) },	// 6d4
					{ "physicalCombatBonus", 1 },
					{ "magicalCombatBonus", 4 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 6 },
					{ "save", 10 },
					{ "xp", 40000 },
				}},

			// MagicUser - Level 7
			{7, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(7, 0, false, 4) },	// 7d4
					{ "physicalCombatBonus", 1 },
					{ "magicalCombatBonus", 5 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 7 },
					{ "save", 9 },
					{ "xp", 80000 },
				}},

			// MagicUser - Level 8
			{8, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(8, 0, false, 4) },	// 8d4
					{ "physicalCombatBonus", 2 },
					{ "magicalCombatBonus", 5 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 8 },
					{ "save", 8 },
					{ "xp", 120000 },
				}},

			// MagicUser - Level 9
			{9, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 0, false, 4) },	// 9d4
					{ "physicalCombatBonus", 2 },
					{ "magicalCombatBonus", 6 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 9 },
					{ "save", 8 },
					{ "xp", 270000 },
				}},

			// MagicUser - Level 10
			{10, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(10, 0, false, 4) },	// 10d4
					{ "physicalCombatBonus", 2 },
					{ "magicalCombatBonus", 7 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 10 },
					{ "save", 8 },
					{ "xp", 420000 },
				}},

			// MagicUser - Level 11
			{11, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 0, false, 4) },	// 11d4
					{ "physicalCombatBonus", 3 },
					{ "magicalCombatBonus", 7 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 12 },
					{ "save", 7 },
					{ "xp", 570000 },
				}},

			// MagicUser - Level 12
			{12, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 1, false, 4) },	// 11d4+1
					{ "physicalCombatBonus", 3 },
					{ "magicalCombatBonus", 8 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 14 },
					{ "save", 7 },
					{ "xp", 720000 },
				}},

			// MagicUser - Level 13
			{13, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 2, false, 4) },	// 11d4+2
					{ "physicalCombatBonus", 4 },
					{ "magicalCombatBonus", 8 },
					{ "fighterBonus", 5 },
					{ "memorySlots", 17 },
					{ "save", 7 },
					{ "xp", 870000 },
				}},

			// MagicUser - Level 14
			{14, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 3, false, 4) },	// 11d4+3
					{ "physicalCombatBonus", 4 },
					{ "magicalCombatBonus", 8 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 20 },
					{ "save", 6 },
					{ "xp", 1020000 },
				}},

			// MagicUser - Level 15
			{15, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 4, false, 4) },	// 11d4+4
					{ "physicalCombatBonus", 4 },
					{ "magicalCombatBonus", 9 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 23 },
					{ "save", 6 },
					{ "xp", 1170000 },
				}},

			// MagicUser - Level 16
			{16, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 5, false, 4) },	// 11d4+5
					{ "physicalCombatBonus", 5 },
					{ "magicalCombatBonus", 9 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 26 },
					{ "save", 6 },
					{ "xp", 1320000 },
				}},

			// MagicUser - Level 17
			{17, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 6, false, 4) },	// 11d4+6
					{ "physicalCombatBonus", 5 },
					{ "magicalCombatBonus", 9 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 29 },
					{ "save", 5 },
					{ "xp", 1470000 },
				}},

			// MagicUser - Level 18
			{18, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 7, false, 4) },	// 11d4+7
					{ "physicalCombatBonus", 5 },
					{ "magicalCombatBonus", 10 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 32 },
					{ "save", 5 },
					{ "xp", 1620000 },
				}},

			// MagicUser - Level 19
			{19, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 8, false, 4) },	// 11d4+8
					{ "physicalCombatBonus", 5 },
					{ "magicalCombatBonus", 10 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 35 },
					{ "save", 5 },
					{ "xp", 1770000 },
				}},

			// MagicUser - Level 20
			{20, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(11, 9, false, 4) },	// 11d4+9
					{ "physicalCombatBonus", 5 },
					{ "magicalCombatBonus", 10 },
					{ "fighterBonus", 0 },
					{ "memorySlots", 38 },
					{ "save", 5 },
					{ "xp", 1920000 },
				}},
		};
	}
}

