using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

	public GameObject cubePrefab;
	// Use this for initialization
	void Start () {
		int totalCubes = 20;
		float totalDistance = 2.0f;

		for (int i = 0; i < totalCubes; i++) {
			float perc = i / (float)totalCubes;

			float sin = Mathf.Sin (perc * Mathf.PI/2);

			float x = 1.8f + sin * totalDistance;
			float y = 5.0f;
			float z = 0.0f;

			GameObject newCube = (GameObject) Instantiate (cubePrefab, new Vector3 (x, y, z), Quaternion.identity);
			CubeRotation cubeRotation = newCube.GetComponent<CubeRotation> ();
			cubeRotation.SetSize ((1-perc) * 0.6f);
			cubeRotation.rotateSpeed = .4f + perc * 3.2f; // perc
		}



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
