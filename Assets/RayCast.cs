using UnityEngine;
using System.Collections;


//This script is attached to the Main Camera
//For your workshop task you must rename the variables (tVariable) to use meaningful names reflecting what they are storing
//Comment the code (at least 1 comment per line) to explain what each line is meant to do
//Add any helpful debug code


public class RayCast : MonoBehaviour {
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray tVariable1 = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D	tVariable2 = Physics2D.Raycast (tVariable1.origin,tVariable1.direction);
			if (tVariable2.collider != null) {
				Card tVariable3 = tVariable2.collider.gameObject.GetComponent<Card> ();
				tVariable3.ShowCard = !tVariable3.ShowCard;
				Debug.Log (string.Format("Ray Cast Hit {0}",tVariable3.name));
			}
		}
	}
}
