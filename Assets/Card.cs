using UnityEngine;
using System.Collections;



//This script is attached to the Card Game object
//The solution file contains some ideas
//on variable names and comments I would use
//to describe how it works


//Card Class
//Used to define the behaviour of a single card
//Assumes a card can display one of 2 sprites so it can either appear turned over (showing its back) or its Rank/Suit



public class Card : MonoBehaviour {

	public	Sprite	FrontSprite;	//Sprite to use for the front of the card, assigned in IDE inspector
	public	Sprite	BackSprite;		//Sprite to use for the back of the card, assigned in IDE inspector

	public	bool	ShowCard;		//To Flip the card (show its value) set the ShowCard State true, also works in IDE via inspector
									//Potential improvement, add a setter method so external code does not need to access Card variables directly
									//Would also allow for the possibilty to not use update to check card each render, as setter could be used to update 
									//SR.sprite when it updates the state variable

	SpriteRenderer	SR;				//Copy of reference to SpriteRenderer stored here,for rapid access later 


	//Start() Unity calls this before the first Update see https://unity3d.com/learn/tutorials/topics/scripting/awake-and-start
	void Start () {
		SR = GetComponent<SpriteRenderer> ();	//Grab Copy of sprite renderer component
		ShowCard=false;			//Show back of card when it starts up
	}


	//Update() Unity calls this before every render see see https://unity3d.com/learn/tutorials/topics/scripting/awake-and-start
	void Update () {
		if (ShowCard) {		//Check which side of the card to show
			SR.sprite = FrontSprite;		//Show the front, if card does not show in game ensure FrontSprite is set in inspector.
		} else {
			SR.sprite = BackSprite;			//Show the back, if card does not show in game ensure BackSprite is set in inspector.
		}
	}
}
