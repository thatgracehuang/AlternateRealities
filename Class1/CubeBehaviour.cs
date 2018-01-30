using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

	float xpos = 0;
	public float xspeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//	Vector3 temp;
	//	temp = transform.position;
	//	temp.x += 0.1f;
	//	transform.position = temp;

		float myheight = transform.position.y;
		float mycolor = myheight / 10.0f;

		GetComponent<MeshRenderer> ().material.color = new Color (mycolor, 1- mycolor, mycolor/2);
		transform.localScale = new Vector3 (1 - mycolor, mycolor*2 , 1 - mycolor);
	}
}
