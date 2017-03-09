using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Stopped video at 3:53

public class Humanoid : MonoBehaviour { // : MonoBehaviour { 

	protected int health;
	protected int attackDamage;
	protected float movementSpeed;

	public virtual void TakeDamage(int damageToTake) {
		health -= damageToTake;
	}

	public virtual int Attack() {
		return attackDamage;
	}

	public virtual void Move() {

		transform.Translate (Vector3.forward * Time.deltaTime);

	}
		
	public void Die() {
	
	}
}
