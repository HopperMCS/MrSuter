using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {

	int playerOneTowersRemaining = 2;
	int playerTwoTowersRemaining = 2;

	bool playerOneTowerDestroyed = false;
	bool playerTwoTowerDestroyed = false;

	float timer = 200;

	// Use this for initialization
	void Start () {

		if (playerOneTowerDestroyed || playerTwoTowerDestroyed) {
			if (playerOneTowerDestroyed) {
				Debug.Log ("Player two wins!!");
			} else {
				Debug.Log("Player one wins!!");
			}

		} else if (timer <= 0) {
			if(playerOneTowersRemaining < playerTwoTowersRemaining) {
				Debug.Log("Player two wins!!");
			} else if (playerTwoTowersRemaining < playerOneTowersRemaining) {
				Debug.Log("Player one wins!!");
			} else {
				Debug.Log("The game was a draw!!");
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
