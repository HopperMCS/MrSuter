using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : MonoBehaviour {

	int bottles = 99; 
	string part1 = " bottles of beer on the wall, ";
	string part2 = " bottles of beer. ";
	string part3 = " Take one down and pass it around, ";
	string part4 = " bottles of beer on the wall.";
	// Use this for initialization
	void Start () {
		while (bottles >= 0) {
			string verse1 = bottles + part1 + bottles + part2 + "\n" + part3 + (bottles--) + part4;
			Debug.Log(verse1);
		}
	}
				
	// Update is called once per frame
	void Update () {
		
	}
}
