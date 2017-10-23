using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCube : MonoBehaviour {

	private float x = 0;
	private float y = 0;
	private float z = 0;
	// private float r = 0;
	private float time = 0.2f;
	private Vector3 direction;
	private Vector3 startPos;

	void Start () {
	
	}
	
	void Update () {
		//Turn();
		//Turn2();
		//Turn3();
		//Turn4();

		if (UImanag.Instance().IsGameOn()){
			if (Input.GetMouseButtonDown(0)){
				startPos = Input.mousePosition;
			}
			if (Input.GetMouseButton(0)){
				direction = Input.mousePosition - startPos;
			}
			if (Input.GetMouseButtonUp(0)){
				direction.Normalize();
				if (direction.x > 0 && direction.y < 0.3 && direction.y > -0.3){
					StartCoroutine("WaitTime2");
				}
				if (direction.x < 0 && direction.y < 0.3 && direction.y > -0.3){
					StartCoroutine("WaitTime4");
				}
				if (direction.y < 0 && direction.x < 0.5 && direction.x > -0.5){
					StartCoroutine("WaitTime3");
				}
				if (direction.y > 0 && direction.x < 0.5 && direction.x > -0.5){
					StartCoroutine("WaitTime");
				}
			}
		}

	}

	//void Turn () 
	//{
//
//	if (Input.GetKeyDown("a")){
//		Debug.Log(Input.GetKeyDown("a"));
//		StartCoroutine(WaitTime());
//		}	
//	}

	IEnumerator WaitTime()
    {
    	z += 45;
    	transform.rotation = Quaternion.Euler(x,y,z);
        yield return new WaitForSeconds(time);
        z += 45;
        transform.rotation = Quaternion.Euler(x,y,z);
    }

    //void Turn2 () 
    //{
//
//	if (Input.GetKeyDown("z")){
//		Debug.Log(Input.GetKeyDown("z"));
//		StartCoroutine(WaitTime2());
//		}	
//	}

	IEnumerator WaitTime2()
    {
    	Debug.Log("Time2");
    	y += 45;
    	transform.rotation = Quaternion.Euler(x,y,z);
        yield return new WaitForSeconds(time);
        y += 45;
        transform.rotation = Quaternion.Euler(x,y,z);
    }

    //void Turn3 () 
    //{
//
//	if (Input.GetKeyDown("e")){
//		Debug.Log(Input.GetKeyDown("e"));
//		StartCoroutine(WaitTime3());
//		}	
//	}

	IEnumerator WaitTime3()
    {
    	x += 45;
    	transform.rotation = Quaternion.Euler(x,y,z);
        yield return new WaitForSeconds(time);
        x += 45;
        transform.rotation = Quaternion.Euler(x,y,z);
    }

    //void Turn4 () 
  //  {
//
	//if (Input.GetKeyDown("r")){
	//	Debug.Log(Input.GetKeyDown("r"));
	//	StartCoroutine(WaitTime4());
	//	}	
	//}

	IEnumerator WaitTime4()
    {
    	y -= 45;
    	transform.rotation = Quaternion.Euler(x,y,z);
        yield return new WaitForSeconds(time);
        y -= 45;
        transform.rotation = Quaternion.Euler(x,y,z);
    }
}
