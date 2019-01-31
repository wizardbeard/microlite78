using UnityEngine;
using System.Collections.Generic;
using System;

namespace Microlite78.Classes
{
	public class PlayerBaseClass : MonoBehaviour
	{
		public static readonly Microlite78.PlayerBaseClasses playerClass;

		public GameObject playerCharacter;

		public static readonly Dictionary<PlayerBaseClasses, System.Type> raceDictionary = new Dictionary<PlayerBaseClasses, System.Type>(){
			{PlayerBaseClasses.Fighter, typeof(Fighter)},
			{PlayerBaseClasses.MagicUser, typeof(MagicUser)},
			{PlayerBaseClasses.Cleric, typeof(Cleric)},
			{PlayerBaseClasses.Thief, typeof(Thief)},
		};

		void Start() {
			this.playerCharacter = this.gameObject;
			Debug.Log ("[BaseClass] playerCharacter: " + playerCharacter);
		}

		void Update() {
			
		}
	}
}

