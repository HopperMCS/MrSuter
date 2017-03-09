using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontBelieveMeJustWatch : MonoBehaviour {
	// Left off at 16:21 in video
	int health = 100;
	int attackPower = 25;
	bool shieldOn = true;
	int shieldAmt = 15;

	void Start() {
	
		print("Health at start: " + health);

	}

	public void Attack() {

		int damageToInflict = GetAttackDamage (shieldOn, shieldAmt, attackPower);
		health -= damageToInflict;
		Debug.Log ("Health after attack: " + health);
	
	}

	public void Heal() {
		
		int healAmount = GetRandomNumber (); 
		health = health + healAmount;

		Debug.Log (healAmount + " health points restored.");
		Debug.Log ("Health after restoration: " + health);

	}

	private int GetAttackDamage(bool isShieldOn, int theShieldAmt, int theAttackPower) {
	
		int damage = 0;

		if (isShieldOn) {
			damage = theAttackPower - (int)((float)theShieldAmt * 0.10f);
		} else {
			damage = theAttackPower;
		}

		return damage;
	
	}

	private int GetRandomNumber() {
	
		return Random.Range (2, 10);
	
	}


//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
		
}
