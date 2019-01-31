using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microlite78 
{
	public class Rotator : MonoBehaviour 
	{
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			rotateSprite ();
		}

		private void rotateSprite ()
		{
			gameObject.transform.Rotate (new Vector3 (){ x = 0.0f, y = 1.0f, z = 0.01f });
		}
	}
}