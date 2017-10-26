using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCube : MonoBehaviour {

	public float turnSpeed = 1.0f;
	public float rotationAngle = 90f;
	private float startAngleY;
	private float startAngleX;
	private float startAngleZ;
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
	private bool tourZRD = false;
	private bool tourXLU = false;
	private bool tourXLD = false;

	private bool isWaza = true;
	private Vector3 tmpDirWaza;

	void Start () 
	{
		startAngleY = transform.eulerAngles.y;
		startAngleZ = transform.eulerAngles.z;
		startAngleX = transform.eulerAngles.x;
	}
	
	void Update () 
	{
		if (UImanag.Instance().IsGameOn())
		{
			Debug.Log(transform.rotation.z);
			if (Input.GetMouseButtonDown(0))
			{
				startPos = Input.mousePosition;
			}
			if (Input.GetMouseButton(0)){
				direction = Input.mousePosition - startPos;
			}
			if (Input.GetMouseButtonUp(0)){
				direction.Normalize();
				if (direction.x > 0.2 && direction.y < 0.2 && direction.y > -0.2)
				{
					turnLeft = true;
				}
				else if (direction.x < -0.2 && direction.y < 0.2 && direction.y > -0.2)
				{
					turnRight = true;
				}
				else if (direction.y < -0.2 && direction.x > 0.2)
				{
					turnRightDown = true;
				}
				else if (direction.y > 0.2 && direction.x > 0.2)
				{
					turnLeftUp = true;
				}
				else if (direction.y < -0.2 && direction.x < -0.2)
				{
					turnLeftDown = true;
				}
				else if (direction.y > 0.2 && direction.x < -0.2)
				{
					turnRightUp = true;
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
				if (isWaza)
				{
					tmpDirWaza = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,transform.eulerAngles.z);
					startAngleZ = tmpDirWaza.z;
					isWaza = false;
				}
				transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime, Space.World);
				Debug.Log(transform.localRotation.eulerAngles.z);
				if ((transform.eulerAngles.z - startAngleZ) >= rotationAngle)
				{
					isWaza = true;
					Vector3 tmpDirZRU = new Vector3(tmpDirWaza.x,tmpDirWaza.y,tmpDirWaza.z + rotationAngle);
					// Debug.Log(transform.eulerAngles);
					// Debug.Log("ert" + tmpDirZRU);
					// transform.eulerAngles = tmpDirZRU;
					startAngleZ = transform.eulerAngles.z;
					turnRightUp = false;
				}
				if (transform.eulerAngles.z > 300) 
				{
					tourZRU = true;
					Debug.Log("Et non !");
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
			//if (turnRightDown)
			// {
			// 		transform.Rotate(-Vector3.forward * turnSpeed * Time.deltaTime, Space.World);
			// 		if (startAngleZ == 0)
			// 		{
			// 			startAngleZ = 360f;
			// 		}
			// 		if ((startAngleZ - transform.eulerAngles.z) >= rotationAngle)
			// 		{
			// 			Vector3 tmpDirZRD = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,startAngleZ - rotationAngle);
			// 			transform.eulerAngles = tmpDirZRD;
			// 			startAngleZ = transform.eulerAngles.z;
			// 			turnRightDown = false;
			// 		}
			// 		if (transform.eulerAngles.z < 30) 
			// 		{
			// 			tourZRD = true;
			// 		}
			// 		if (tourZRD && transform.eulerAngles.z < 360 && transform.eulerAngles.z > 340)
			// 		{
			// 			Vector3 tmpTourZRD = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,0);
			// 			transform.eulerAngles = tmpTourZRD;
			// 			startAngleZ = transform.eulerAngles.z;
			// 			tourZRD = false;
			// 			turnRightDown = false;
			// 		}
			// }
			// if (turnLeftDown)
			// {
			// 		transform.Rotate(-Vector3.right * turnSpeed * Time.deltaTime, Space.World);
			// 		if (startAngleX == 0)
			// 		{
			// 			startAngleX = 360f;
			// 		}
			// 		if ((startAngleX - transform.eulerAngles.x) >= rotationAngle)
			// 		{
			// 			Vector3 tmpDirXLD = new Vector3(startAngleX - rotationAngle, transform.eulerAngles.y,transform.eulerAngles.z );
			// 			transform.eulerAngles = tmpDirXLD;
			// 			startAngleX = transform.eulerAngles.x;
			// 			turnLeftDown = false;
			// 			Debug.Log("coucou toi");
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