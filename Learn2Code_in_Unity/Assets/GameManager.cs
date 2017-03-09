using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Zombie zombie = new Zombie ();
		Player player = new Player ();

		player.TakeDamage(zombie.Attack ());
		player.TakeDamage (zombie.AcidPukeAttack ());

		player.Die ();

		Zombie[] zombies = new Zombie[100];

		for (int x = 0; x < zombies.Length; x++) {
			zombies [x] = new Zombie ();
			Debug.Log ("Creating zombie #: " + x);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
