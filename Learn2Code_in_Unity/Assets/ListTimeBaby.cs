using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTimeBaby : MonoBehaviour {

	public GameObject cubePrefab;

	GameObject[] cubes = new GameObject[10];

	float spacer = 0.9f;

	// Use this for initialization
	void Start () {
//		"Stopped video at 14:21 at 9:12AM 3/8/17"

		for (int i = 0; i < cubes.Length; i++) {
			
			GameObject cube = Instantiate (cubePrefab);
			cubes [i] = cube;		
			cube.transform.position = new Vector3 (spacer * i, cube.transform.position.y);
//			cube.GetComponent<MeshRenderer> ().material.SetColor ("_Color",ctnBlue);

			int[] colors = { Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255) };
		

			colors [0] = colors [0] * i;
			colors [0] = colors [0] * i;
			colors [0] = colors [0] * i + 1;

			cube.GetComponent<Renderer> ().material.color = new Color (colors[0], colors[1], colors[2], 1);

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
