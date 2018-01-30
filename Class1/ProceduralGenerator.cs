using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGenerator : MonoBehaviour {
	public GameObject myCube;
	GameObject[] all_cubes;
	public int numCubes;
	public float offsetX = 0;
	public float offsetY = 0;
	// Use this for 
	void Start () {
		numCubes = 10;
		int k = 0;
		all_cubes = new GameObject[numCubes*numCubes];


for (int j=0; j<numCubes; j++){
		for (int i=0;i<numCubes;i++){
			all_cubes[k] = GameObject.Instantiate (myCube, new Vector3 (i,0,j), Quaternion.identity);
			k++;
		}
	}

		//GameObject.Instantiate (myCube as Object, Vector3.zero, Quaternion.identity);
	}
	//Perlin noise
	// Update is called once per frame
	void Update () {	
		offsetX++;
		offsetY ++;	
		for(int i = 0; i < all_cubes.Length; i++){

			float  noise = Mathf.PerlinNoise(2.1f, i*0.01f)*10.0f;

			//Makes things glitchy
			//float  noise = Mathf.PerlinNoise(offsetX*0.5f, offsetY*0.5f)*10.0f;

			float  newy = Mathf.Sin((Time.time)-i) + noise;

			//Makes some cubes move away once they reach a particular height
			all_cubes[i].transform.position = new Vector3 (all_cubes[i].transform.position.x, newy, all_cubes[i].transform.position.z);
			if (all_cubes[i].transform.position.y > 4.5){
				all_cubes[i].transform.position = new Vector3 ((all_cubes[i].transform.position.x + 0.1f), newy, all_cubes[i].transform.position.z);
			}
		
		}

	}
}
