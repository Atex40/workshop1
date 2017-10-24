using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCube : MonoBehaviour {

	public float turnSpeed = 1.0f;
	public float rotationAngle = 90f;
	private float startAngleY;
	private float startAngleX;
	private float startAngleZ;
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
	private bool tourYL = false;
	private bool tourYR = false;
	private bool tourZRU = false;
	private bool tourXLU = false;
	private bool tourZRD = false;
	private bool tourXLD = false;

	void Start () {

		startAngleY = transform.eulerAngles.y;
		startAngleZ = transform.eulerAngles.z;
		startAngleX = transform.eulerAngles.x;
	
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
					turnLeft = true;
					//turnLeft = false;
					//StartCoroutine("WaitTime2");
				}
				else if (direction.x < -0.2 && direction.y < 0.2 && direction.y > -0.2){
					turnRight = true;
					//turnRight = false;
					//StartCoroutine("WaitTime4");
				}
				else if (direction.y < -0.2 && direction.x > 0.2){
					turnRightDown = true;
					//turnRightDown = false;
					//StartCoroutine("WaitTime5");
				}
				else if (direction.y > 0.2 && direction.x > 0.2){
					turnLeftUp = true;
					//turnLeftUp = false;
					//StartCoroutine("WaitTime6");
				}
				else if (direction.y < -0.2 && direction.x < -0.2){
					turnLeftDown = true;
					//turnLeftDown = false;
					//StartCoroutine("WaitTime3");
				}
				else if (direction.y > 0.2 && direction.x < -0.2){
					turnRightUp = true;
					//turnRightUp = false;
					//StartCoroutine("WaitTime");
				}

			}

			if (turnRight)
			{
				
					transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime, Space.World);
					if ((transform.eulerAngles.y - startAngleY) >= rotationAngle)
					{
						Vector3 tmpDirYL = new Vector3(transform.eulerAngles.x,startAngleY + rotationAngle,transform.eulerAngles.z);
						transform.eulerAngles = tmpDirYL;
						startAngleY = transform.eulerAngles.y;
						turnRight = false;
					}
					if (transform.eulerAngles.y > 300) 
					{
						tourYL = true;
					}
					if (tourYL && transform.eulerAngles.y > 0 && transform.eulerAngles.y < 20)
					{
						Vector3 tmpTourYL = new Vector3(transform.eulerAngles.x,0,transform.eulerAngles.z);
						transform.eulerAngles = tmpTourYL;
						startAngleY = transform.eulerAngles.y;
						tourYL = false;
						turnRight = false;
					}

			}
			if (turnLeft)
			{
					transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime, Space.World);
					if (startAngleY == 0)
					{
						startAngleY = 360f;
					}
					if ((startAngleY - transform.eulerAngles.y) >= rotationAngle)
					{
						Vector3 tmpDirYR = new Vector3(transform.eulerAngles.x,startAngleY - rotationAngle,transform.eulerAngles.z);
						transform.eulerAngles = tmpDirYR;
						startAngleY = transform.eulerAngles.y;
						turnLeft = false;
					}
					if (transform.eulerAngles.y < 30) 
					{
						tourYR = true;
					}
					if (tourYR && transform.eulerAngles.y < 360 && transform.eulerAngles.y > 340)
					{
						Vector3 tmpTourYR = new Vector3(transform.eulerAngles.x,0,transform.eulerAngles.z);
						transform.eulerAngles = tmpTourYR;
						startAngleY = transform.eulerAngles.y;
						tourYR = false;
						turnLeft = false;
					}
			}
			if (turnRightUp)
			{
					transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime, Space.World);
					if ((transform.eulerAngles.z - startAngleZ) >= rotationAngle)
					{
						Vector3 tmpDirZRU = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,startAngleZ + rotationAngle);
						transform.eulerAngles = tmpDirZRU;
						startAngleZ = transform.eulerAngles.z;
						turnRightUp = false;
					}
					if (transform.eulerAngles.z > 300) 
					{
						tourZRU = true;
					}
					if (tourZRU && transform.eulerAngles.z > 0 && transform.eulerAngles.z < 20)
					{
						Vector3 tmpTourZRU = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,0);
						transform.eulerAngles = tmpTourZRU;
						startAngleZ = transform.eulerAngles.z;
						tourZRU = false;
						turnRightUp = false;
					}
			}
			// if (turnLeftUp)
			// {
			// 		transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime, Space.World);
			// 		if ((transform.eulerAngles.x - startAngleX) >= rotationAngle)
			// 		Debug.Log(transform.eulerAngles.x);
			// 		{
			// 			Vector3 tmpDirXLU = new Vector3(startAngleX + rotationAngle,transform.eulerAngles.y,transform.eulerAngles.z);
			// 			transform.eulerAngles = tmpDirXLU;
			// 			startAngleX = transform.eulerAngles.x;
			// 			turnLeftUp = false;
			// 		}
			// 		if (transform.eulerAngles.x > 300) 
			// 		{
			// 			tourXLU = true;
			// 		}
			// 		if (tourXLU && transform.eulerAngles.x > 0 && transform.eulerAngles.x < 20)
			// 		{
			// 			Vector3 tmpTourXLU = new Vector3(0,transform.eulerAngles.y,transform.eulerAngles.z);
			// 			transform.eulerAngles = tmpTourXLU;
			// 			startAngleX = transform.eulerAngles.x;
			// 			tourXLU = false;
			// 			turnLeftUp = false;
			// 		}
			// }
			if (turnRightDown)
			{
					transform.Rotate(-Vector3.forward * turnSpeed * Time.deltaTime, Space.World);
					if (startAngleZ == 0)
					{
						startAngleZ = 360f;
					}
					if ((startAngleZ - transform.eulerAngles.z) >= rotationAngle)
					{
						Vector3 tmpDirZRD = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,startAngleZ + rotationAngle);
						transform.eulerAngles = tmpDirZRD;
						startAngleZ = transform.eulerAngles.z;
						turnRightDown = false;
					}
					if (transform.eulerAngles.z < 30) 
					{
						tourZRD = true;
					}
					if (tourZRD && transform.eulerAngles.z < 360 && transform.eulerAngles.z > 340)
					{
						Vector3 tmpTourZRD = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,0);
						transform.eulerAngles = tmpTourZRD;
						startAngleZ = transform.eulerAngles.z;
						tourZRD = false;
						turnRightDown = false;
					}
			}
			// if (turnLeftDown)
			// {
			// 		transform.Rotate(-Vector3.right * turnSpeed * Time.deltaTime, Space.World);
			// 		if (startAngleX == 0)
			// 		{
			// 			startAngleX = 360f;
			// 		}
			// 		if ((startAngleX - transform.eulerAngles.x) >= rotationAngle)
			// 		{
			// 			Vector3 tmpDirXLD = new Vector3(startAngleX + rotationAngle,transform.eulerAngles.y,transform.eulerAngles.z);
			// 			transform.eulerAngles = tmpDirXLD;
			// 			startAngleX = transform.eulerAngles.x;
			// 			turnLeftDown = false;
			// 		}
			// 		if (transform.eulerAngles.x < 30) 
			// 		{
			// 			tourXLD = true;
			// 		}
			// 		if (tourXLD && transform.eulerAngles.x < 360 && transform.eulerAngles.x > 340)
			// 		{
			// 			Vector3 tmpTourXLD = new Vector3(0,transform.eulerAngles.y,transform.eulerAngles.z);
			// 			transform.eulerAngles = tmpTourXLD;
			// 			startAngleX = transform.eulerAngles.x;
			// 			tourXLD = false;
			// 			turnLeftDown = false;
			// 		}
			// }
		}
	}
}

// 	//void Turn () 
// 	//{
// //
// //	if (Input.GetKeyDown("a")){
// //		Debug.Log(Input.GetKeyDown("a"));
// //		StartCoroutine(WaitTime());
// //		}	
// //	}

// IEnumerator WaitTime()
//  {
//  	turnRightUp = true;
// 	yield return new WaitForSeconds(1);
// 	turnRightUp = false;
//  //    	z += 45;
//  //    	transform.rotation = Quaternion.Euler(x,y,z);
//  //        yield return new WaitForSeconds(time);
//  //        z += 45;
//  //        transform.rotation = Quaternion.Euler(x,y,z);
//  }

//     //void Turn2 () 
//     //{
// //
// //	if (Input.GetKeyDown("z")){
// //		Debug.Log(Input.GetKeyDown("z"));
// //		StartCoroutine(WaitTime2());
// //		}	
// //	}

// IEnumerator WaitTime2()
//  {
//  	turnLeft = true;
// 	yield return new WaitForSeconds(1);
// 	turnLeft = false;
//  //    	y += 45;
//  //    	transform.rotation = Quaternion.Euler(x,y,z);
//  //        yield return new WaitForSeconds(time);
//  //        y += 45;
//  //        transform.rotation = Quaternion.Euler(x,y,z);
//  }

//     //void Turn3 () 
//     //{
// //
// //	if (Input.GetKeyDown("e")){
// //		Debug.Log(Input.GetKeyDown("e"));
// //		StartCoroutine(WaitTime3());
// //		}	
// //	}

// IEnumerator WaitTime3()
//  {
//  	turnLeftDown = true;
// 	yield return new WaitForSeconds(1);
// 	turnLeftDown = false;
//  //    	x -= 45;
//  //    	transform.rotation = Quaternion.Euler(x,y,z);
//  //        yield return new WaitForSeconds(time);
//  //        x -= 45;
//  //        transform.rotation = Quaternion.Euler(x,y,z);
//  }

//     //void Turn4 () 
//   //  {
// //
// 	//if (Input.GetKeyDown("r")){
// 	//	Debug.Log(Input.GetKeyDown("r"));
// 	//	StartCoroutine(WaitTime4());
// 	//	}	
// 	//}

// IEnumerator WaitTime4()
// {
// 	turnRight = true;
// 	yield return new WaitForSeconds(1);
// 	turnRight = false;
// //     	y -= 45;
// //     	transform.rotation = Quaternion.Euler(x,y,z);
// //         yield return new WaitForSeconds(time);
// //         y -= 45;
// //         transform.rotation = Quaternion.Euler(x,y,z);
// }

// IEnumerator WaitTime5()
// {
// 	turnRightDown = true;
// 	yield return new WaitForSeconds(1);
// 	turnRightDown = false;
// //     	z -= 45;
// //     	transform.rotation = Quaternion.Euler(x,y,z);
// //         yield return new WaitForSeconds(time);
// //         z -= 45;
// //         transform.rotation = Quaternion.Euler(x,y,z);
// }

// IEnumerator WaitTime6()
// {
// 	turnLeftUp = true;
// 	yield return new WaitForSeconds(1);
// 	turnLeftUp = false;
// //     	x += 45;
// //     	transform.rotation = Quaternion.Euler(x,y,z);
// //         yield return new WaitForSeconds(time);
// //         x += 45;
// //         transform.rotation = Quaternion.Euler(x,y,z);
// }
