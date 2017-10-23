using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCube : MonoBehaviour {

	public float turnSpeed = 1.0f;
	// private float x = 0;
	// private float y = 0;
	// private float z = 0;
	// private float time = 0.02f;
	private Vector3 direction;
	private Vector3 startPos;
	private bool turnRight = false;
	private bool turnLeft = false;
	private bool turnRightUp = false;
	private bool turnLeftUp = false;
	private bool turnRightDown = false;
	private bool turnLeftDown = false;

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
				if (direction.x > 0.2 && direction.y < 0.2 && direction.y > -0.2){
					//turnLeft = true;
					//turnLeft = false;
					StartCoroutine("WaitTime2");
				}
				else if (direction.x < -0.2 && direction.y < 0.2 && direction.y > -0.2){
					//turnRight = true;
					//turnRight = false;
					StartCoroutine("WaitTime4");
				}
				else if (direction.y < -0.2 && direction.x > 0.2){
					//turnRightDown = true;
					//turnRightDown = false;
					StartCoroutine("WaitTime5");
				}
				else if (direction.y > 0.2 && direction.x > 0.2){
					//turnLeftUp = true;
					//turnLeftUp = false;
					StartCoroutine("WaitTime6");
				}
				else if (direction.y < -0.2 && direction.x < -0.2){
					//turnLeftDown = true;
					//turnLeftDown = false;
					StartCoroutine("WaitTime3");
				}
				else if (direction.y > 0.2 && direction.x < -0.2){
					//turnRightUp = true;
					//turnRightUp = false;
					StartCoroutine("WaitTime");
				}

			}

			if (turnRight)
			{
				transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime, Space.World);
			}
			if (turnLeft)
			{
				transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime, Space.World);
			}
			if (turnRightUp)
			{
				transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime, Space.World);
			}
			if (turnLeftUp)
			{
				transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime, Space.World);
			}
			if (turnRightDown)
			{
				transform.Rotate(-Vector3.forward * turnSpeed * Time.deltaTime, Space.World);
			}
			if (turnLeftDown)
			{
				transform.Rotate(-Vector3.right * turnSpeed * Time.deltaTime, Space.World);
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
 	turnRightUp = true;
	yield return new WaitForSeconds(1);
	turnRightUp = false;
 //    	z += 45;
 //    	transform.rotation = Quaternion.Euler(x,y,z);
 //        yield return new WaitForSeconds(time);
 //        z += 45;
 //        transform.rotation = Quaternion.Euler(x,y,z);
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
 	turnLeft = true;
	yield return new WaitForSeconds(1);
	turnLeft = false;
 //    	y += 45;
 //    	transform.rotation = Quaternion.Euler(x,y,z);
 //        yield return new WaitForSeconds(time);
 //        y += 45;
 //        transform.rotation = Quaternion.Euler(x,y,z);
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
 	turnLeftDown = true;
	yield return new WaitForSeconds(1);
	turnLeftDown = false;
 //    	x -= 45;
 //    	transform.rotation = Quaternion.Euler(x,y,z);
 //        yield return new WaitForSeconds(time);
 //        x -= 45;
 //        transform.rotation = Quaternion.Euler(x,y,z);
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
	turnRight = true;
	yield return new WaitForSeconds(1);
	turnRight = false;
//     	y -= 45;
//     	transform.rotation = Quaternion.Euler(x,y,z);
//         yield return new WaitForSeconds(time);
//         y -= 45;
//         transform.rotation = Quaternion.Euler(x,y,z);
}

IEnumerator WaitTime5()
{
	turnRightDown = true;
	yield return new WaitForSeconds(1);
	turnRightDown = false;
//     	z -= 45;
//     	transform.rotation = Quaternion.Euler(x,y,z);
//         yield return new WaitForSeconds(time);
//         z -= 45;
//         transform.rotation = Quaternion.Euler(x,y,z);
}

IEnumerator WaitTime6()
{
	turnLeftUp = true;
	yield return new WaitForSeconds(1);
	turnLeftUp = false;
//     	x += 45;
//     	transform.rotation = Quaternion.Euler(x,y,z);
//         yield return new WaitForSeconds(time);
//         x += 45;
//         transform.rotation = Quaternion.Euler(x,y,z);
}
}
