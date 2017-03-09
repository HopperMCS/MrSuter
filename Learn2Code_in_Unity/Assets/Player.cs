using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Stopped video at 15:42
public class Player : Humanoid {

	private int spinAttackDamage = 10;

	public override int Attack() {
		return attackDamage + spinAttackDamage;
	}


}
