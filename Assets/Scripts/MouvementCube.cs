using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCube : MonoBehaviour {
	float x;

	void Start () {
	
	}
	
	void Update () {
		Turn();
	}

	void Turn () {

	if (Input.GetKeyDown("a")){
		Debug.Log(Input.GetKeyDown("a"));
//		transform.rotation = Quartenion(0,0,90);
		}	
	}
}
