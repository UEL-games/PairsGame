using UnityEngine;
using System.Collections;



//This script is attached to the Card Game object
//For your workshop task you must rename the variables to use meaningful names
//Comment the code to explain what each line is meant to do
//Add any helpful debug code



public class Card : MonoBehaviour {

	public	Sprite	FrontSprite;
	public	Sprite	BackSprite;

	public	bool	ShowCard;

	SpriteRenderer	SR;

	void Start () {
		SR = GetComponent<SpriteRenderer> ();	
	}
	
	void Update () {
		if (ShowCard) {
			SR.sprite = FrontSprite;
		} else {
			SR.sprite = BackSprite;
		}
	}
}
