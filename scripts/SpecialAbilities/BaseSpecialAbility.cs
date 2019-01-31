using System;
using UnityEngine;

namespace Microlite78.SpecialAbilities
{
	public class BaseSpecialAbility: MonoBehaviour
	{
		public GameObject source;
		public GameObject target;

		void Start() {
			Manifest ();
		}

		void Update() {
			
		}

		public void Setup() {
		
		}

		public virtual void Manifest() {
			Debug.Log ("Special Ability: " + this.name + ", source: " + source.name + ", target: " + target.name);
		}
	}
}

