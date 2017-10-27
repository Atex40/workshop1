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

	private bool isWaza = false;
	private bool isWesh = false;
	private Vector3 tmpDirRight;
	private Vector3 tmpDirRightUp;
	private Vector3 tmpDirLeftUp;
	private int rotYIdx = 1;
	private int rotXIdx = 1;
	private int rotZIdx = 1;
	private bool okMoveR = true;
	private bool okMoveL = true;

	void Start () 
	{
		startAngleY = transform.eulerAngles.y;
		startAngleZ = transform.eulerAngles.z;
		startAngleX = transform.eulerAngles.x;
		tmpDirRight = transform.InverseTransformDirection(Vector3.up) * rotationAngle;
		tmpDirRightUp = transform.InverseTransformDirection(Vector3.forward) * rotationAngle;
		tmpDirLeftUp = transform.InverseTransformDirection(Vector3.right) * rotationAngle;

	}
	
	void Update () 
	{
		if (UImanag.Instance().IsGameOn())
		{
			if (Input.GetMouseButtonDown(0))
			{
				startPos = Input.mousePosition;
			}
			if (Input.GetMouseButton(0)){
				direction = Input.mousePosition - startPos;
			}
			if (Input.GetMouseButtonUp(0)){
				direction.Normalize();
				if (direction.x > 0.2 && direction.y < 0.2 && direction.y > -0.2 && okMoveR == true)
				{
					turnLeft = true;
					okMoveL = false;
				}
				else if (direction.x < -0.2 && direction.y < 0.2 && direction.y > -0.2 && okMoveL == true)
				{
					turnRight = true;
					okMoveR = false;
				}
				// else if (direction.y < -0.2 && direction.x > 0.2)
				// {
				// 	turnRightDown = true;
				// }
				// else if (direction.y > 0.2 && direction.x > 0.2)
				// {
				// 	turnLeftUp = true;
				// }
				// else if (direction.y < -0.2 && direction.x < -0.2)
				// {
				// 	turnLeftDown = true;
				// }
				// else if (direction.y > 0.2 && direction.x < -0.2)
				// {
				// 	turnRightUp = true;
				// }
			}

			// if (turnLeft)
			// {
			// 	iTween.RotateBy(gameObject, iTween.Hash("y", -0.25, "easeType", "easeInOutBack","delay", .4));
			// 	turnLeft = false;
			// 	okMoveL = true;
			// }

			// if (turnRight)
			// {
			// 	iTween.RotateBy(gameObject, iTween.Hash("y", 0.25, "easeType", "easeInOutBack","delay", .4));
			// 	turnRight = false;
			// 	okMoveR = true;
			// }

			// else if (Input.GetKeyDown("p"))
			// {
			// 	iTween.RotateBy(gameObject, iTween.Hash("z", 0.25));
			// }

			// else if (Input.GetKeyDown("t"))
			// {
			// 	iTween.RotateBy(gameObject, iTween.Hash("x", 0.25));
			// }
				

			// if (turnRight)
			// {
			// 	transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.FromToRotation(Vector3.right, Vector3.forward), turnSpeed * Time.deltaTime);
				// if (transform.rotation == Quaternion.Euler(-tmpDirRight))
				// {
					// rotYIdx ++;
					// tmpDirRight = (transform.InverseTransformDirection(Vector3.up) * rotYIdx) * rotationAngle;
					// tmpDirRightUp = transform.InverseTransformDirection(Vector3.forward) * rotationAngle;
					// tmpDirLeftUp = transform.InverseTransformDirection(Vector3.right) * rotationAngle;
				// 	turnRight = false;
				// }
		//	}

			// if (Input.GetKeyDown("p"))
			// {
			// 	turnRight = false;
			// 	turnRightUp = true;
			// 	turnLeftUp = false;
			// }

			// if (turnRightUp)
			// {
			// 	transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler(transform.InverseTransformDirection(Vector3.up) * rotationAngle), turnSpeed * Time.deltaTime);
			// 	if (transform.rotation == Quaternion.Euler(transform.InverseTransformDirection(Vector3.up)))
			// 	{
			// 		// rotXIdx ++;
			// 		// tmpDirRight = transform.InverseTransformDirection(Vector3.up) * rotationAngle;
			// 		// tmpDirRightUp = (transform.InverseTransformDirection(Vector3.forward) * rotXIdx) * rotationAngle;
			// 		// tmpDirLeftUp = transform.InverseTransformDirection(Vector3.right) * rotationAngle;
			// 		turnRightUp = false;
			// 	}
			// }

			// if (Input.GetKeyDown("t"))
			// {
			// 	turnRight = false;
			// 	turnRightUp = false;
			// 	turnLeftUp = true;
			// }

			// if (turnLeftUp)
			// {
			// 	transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler(tmpDirLeftUp), turnSpeed * Time.deltaTime);
			// 	if (transform.rotation == Quaternion.Euler(tmpDirLeftUp))
			// 	{
			// 		rotZIdx ++;
			// 		// tmpDirRight = transform.InverseTransformDirection(Vector3.up) * rotationAngle;
			// 		// tmpDirRightUp = transform.InverseTransformDirection(Vector3.forward) * rotationAngle;
			// 		tmpDirLeftUp = (transform.InverseTransformDirection(Vector3.right) * rotZIdx) * rotationAngle;
			// 		turnLeftUp = false;
			// 	}
			// }

			//OLD

			if (turnRight)
			{
					transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime, Space.World);
					if ((transform.eulerAngles.y - startAngleY) >= rotationAngle)
					{
						Vector3 tmpDirYL = new Vector3(transform.eulerAngles.x,startAngleY + rotationAngle,transform.eulerAngles.z);
						transform.eulerAngles = tmpDirYL;
						startAngleY = transform.eulerAngles.y;
						turnRight = false;
						okMoveR = true;
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
						okMoveR = true;
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
						okMoveL = true;
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
						okMoveL = true;
					}
			}
		}
	}
}
