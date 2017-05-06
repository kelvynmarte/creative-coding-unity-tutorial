using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

	public GameObject cubePrefab;
	// Use this for initialization
	void Start () {
		int totalCubes = 12;
		float totalDistance = 5.0f;

		for (int i = 0; i < totalCubes; i++) {
			float perc = i / (float)totalCubes;
			float x = perc * totalDistance;
			float y = 5.0f;
			float z = 0.0f;

			GameObject newCube = (GameObject) Instantiate (cubePrefab, new Vector3 (x, y, z), Quaternion.identity);
			CubeRotation cubeRotation = newCube.GetComponent<CubeRotation> ();
			cubeRotation.SetSize (1-perc);
			cubeRotation.rotateSpeed = perc;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
