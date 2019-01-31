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
		// TODO: replace with actual values from the SRD
		public static AdvancementDictionary Thief = new AdvancementDictionary () { 
			// Fighter - Level 1
			{1, new Dictionary<string, int> () {
					{ "hp", DiceRoller.roll(1, 0, false, 10) },	// 1d10
					{ "physicalCombatBonus", 0 },
					{ "magicalCombatBonus", 0 },
					{ "fighterBonus", 1 },
					{ "memorySlots", 0 },
					{ "save", 14 },
					{ "xp", 0 },
				}},

			// Fighter - Level 2
			{2, new Dictionary<string, int> (){
					{ "hp", DiceRoller.roll(2, 0, false, 10) },	// 2d10
					{ "physicalCombatBonus", 0 },
					{ "magicalCombatBonus", 0 },
					{ "fighterBonus", 1 },
					{ "memorySlots", 0 },
					{ "save", 13 },
					{ "xp", 2000 },
				}},

			// Fighter - Level 3
			{3, new Dictionary<string, int>(){
					{ "hp", DiceRoller.roll(3, 0, false, 10) },	// 3d10
					{ "physicalCombatBonus", 1 },
					{ "magicalCombatBonus", 0 },
					{ "fighterBonus", 1 },
					{ "memorySlots", 0 },
					{ "save", 12 },
					{ "xp", 4000 },
				}},

			// Fighter - Level 4
			{4, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(4, 0, false, 10) },	// 4d10
					{ "physicalCombatBonus", 2 },
					{ "magicalCombatBonus", 1 },
					{ "fighterBonus", 2 },
					{ "memorySlots", 0 },
					{ "save", 11 },
					{ "xp", 8000 },
				}},

			// Fighter - Level 5
			{5, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(5, 0, false, 10) },	// 5d10
					{ "physicalCombatBonus", 3 },
					{ "magicalCombatBonus", 1 },
					{ "fighterBonus", 2 },
					{ "memorySlots", 0 },
					{ "save", 10 },
					{ "xp", 16000 },
				}},

			// Fighter - Level 6
			{6, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(6, 0, false, 10) },	// 6d10
					{ "physicalCombatBonus", 4 },
					{ "magicalCombatBonus", 1 },
					{ "fighterBonus", 2 },
					{ "memorySlots", 0 },
					{ "save", 9 },
					{ "xp", 32000 },
				}},

			// Fighter - Level 7
			{7, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(7, 0, false, 10) },	// 7d10
					{ "physicalCombatBonus", 5 },
					{ "magicalCombatBonus", 1 },
					{ "fighterBonus", 3 },
					{ "memorySlots", 0 },
					{ "save", 8 },
					{ "xp", 65000 },
				}},

			// Fighter - Level 8
			{8, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(8, 0, false, 10) },	// 8d10
					{ "physicalCombatBonus", 5 },
					{ "magicalCombatBonus", 2 },
					{ "fighterBonus", 3 },
					{ "memorySlots", 0 },
					{ "save", 7 },
					{ "xp", 130000 },
				}},

			// Fighter - Level 9
			{9, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 0, false, 10) },	// 9d10
					{ "physicalCombatBonus", 6 },
					{ "magicalCombatBonus", 2 },
					{ "fighterBonus", 3 },
					{ "memorySlots", 0 },
					{ "save", 7 },
					{ "xp", 250000 },
				}},

			// Fighter - Level 10
			{10, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 2, false, 10) },	// 9d10+2
					{ "physicalCombatBonus", 7 },
					{ "magicalCombatBonus", 2 },
					{ "fighterBonus", 4 },
					{ "memorySlots", 0 },
					{ "save", 6 },
					{ "xp", 370000 },
				}},

			// Fighter - Level 11
			{11, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 4, false, 10) },	// 9d10+4
					{ "physicalCombatBonus", 7 },
					{ "magicalCombatBonus", 3 },
					{ "fighterBonus", 4 },
					{ "memorySlots", 0 },
					{ "save", 6 },
					{ "xp", 490000 },
				}},

			// Fighter - Level 12
			{12, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 6, false, 10) },	// 9d10+6
					{ "physicalCombatBonus", 8 },
					{ "magicalCombatBonus", 3 },
					{ "fighterBonus", 4 },
					{ "memorySlots", 0 },
					{ "save", 5 },
					{ "xp", 610000 },
				}},

			// Fighter - Level 13
			{13, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 8, false, 10) },	// 9d10+8
					{ "physicalCombatBonus", 8 },
					{ "magicalCombatBonus", 4 },
					{ "fighterBonus", 5 },
					{ "memorySlots", 0 },
					{ "save", 5 },
					{ "xp", 730000 },
				}},

			// Fighter - Level 14
			{14, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 10, false, 10) },	// 9d10+10
					{ "physicalCombatBonus", 8 },
					{ "magicalCombatBonus", 4 },
					{ "fighterBonus", 5 },
					{ "memorySlots", 0 },
					{ "save", 4 },
					{ "xp", 850000 },
				}},

			// Fighter - Level 15
			{15, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 12, false, 10) },	// 9d10+12
					{ "physicalCombatBonus", 9 },
					{ "magicalCombatBonus", 4 },
					{ "fighterBonus", 5 },
					{ "memorySlots", 0 },
					{ "save", 4 },
					{ "xp", 970000 },
				}},

			// Fighter - Level 16
			{16, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 14, false, 10) },	// 9d10+14
					{ "physicalCombatBonus", 9 },
					{ "magicalCombatBonus", 5 },
					{ "fighterBonus", 6 },
					{ "memorySlots", 0 },
					{ "save", 3 },
					{ "xp", 1210000 },
				}},

			// Fighter - Level 17
			{17, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 16, false, 10) },	// 9d10+16
					{ "physicalCombatBonus", 9 },
					{ "magicalCombatBonus", 5 },
					{ "fighterBonus", 6 },
					{ "memorySlots", 0 },
					{ "save", 3 },
					{ "xp", 1330000 },
				}},

			// Fighter - Level 18
			{18, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 18, false, 10) },	// 9d10+18
					{ "physicalCombatBonus", 10 },
					{ "magicalCombatBonus", 5 },
					{ "fighterBonus", 6 },
					{ "memorySlots", 0 },
					{ "save", 2 },
					{ "xp", 1450000 },
				}},

			// Fighter - Level 19
			{19, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 20, false, 10) },	// 9d10+20
					{ "physicalCombatBonus", 10 },
					{ "magicalCombatBonus", 5 },
					{ "fighterBonus", 7 },
					{ "memorySlots", 0 },
					{ "save", 2 },
					{ "xp", 1570000 },
				}},

			// Fighter - Level 20
			{20, new Dictionary<string, int>() {
					{ "hp", DiceRoller.roll(9, 22, false, 10) },	// 9d10+22
					{ "physicalCombatBonus", 10 },
					{ "magicalCombatBonus", 5 },
					{ "fighterBonus", 7 },
					{ "memorySlots", 0 },
					{ "save", 2 },
					{ "xp", 1690000 },
				}},
		};
	}
}

