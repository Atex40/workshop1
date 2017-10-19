using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCube : MonoBehaviour {

	private float x = 0;
	private float y = 0;
	private float z = 0;
	private float time = 0.2f;

	void Start () {
	
	}
	
	void Update () {
		Turn();
		Turn2();
		Turn3();
	}

	void Turn () {

	if (Input.GetKeyDown("a")){
		Debug.Log(Input.GetKeyDown("a"));
		StartCoroutine(WaitTime());
		}	
	}

	IEnumerator WaitTime()
    {
    	z += 45;
    	transform.rotation = Quaternion.Euler(x,y,z);
        yield return new WaitForSeconds(time);
        z += 45;
        transform.rotation = Quaternion.Euler(x,y,z);
    }

    	void Turn2 () {

	if (Input.GetKeyDown("z")){
		Debug.Log(Input.GetKeyDown("z"));
		StartCoroutine(WaitTime2());
		}	
	}

	IEnumerator WaitTime2()
    {
    	y += 45;
    	transform.rotation = Quaternion.Euler(x,y,z);
        yield return new WaitForSeconds(time);
        y += 45;
        transform.rotation = Quaternion.Euler(x,y,z);
    }

        	void Turn3 () {

	if (Input.GetKeyDown("e")){
		Debug.Log(Input.GetKeyDown("e"));
		StartCoroutine(WaitTime2());
		}	
	}

	IEnumerator WaitTime3()
    {
    	x += 45;
    	transform.rotation = Quaternion.Euler(x,y,z);
        yield return new WaitForSeconds(time);
        x += 45;
        transform.rotation = Quaternion.Euler(x,y,z);
    }
}
