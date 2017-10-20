using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractObject : MonoBehaviour {

 	private Transform attractedTo;
    public float speed = 50.0f;

     void Start () {
     	if(!UImanag.Instance().IsGameOn())
     	{
     		gameObject.SetActive(false);
     	}
     }
     void FixedUpdate ()

     {
        Vector3 direction = attractedTo.position - transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce((0.01f * speed) * direction);
        UpSpeed ();
 
     }

    void OnCollisionEnter(Collision collision){

    	Debug.Log(collision.gameObject.tag);	

     	if (collision.gameObject.tag == gameObject.tag)
     	{
     		UImanag.Instance().AddScore();
     		EconomyManager.Instance().AddMoney();
     	}

    	else if (collision.gameObject.tag != gameObject.tag)
     	{
     		UImanag.Instance().LooseLife();
     	}

     	Destroy(gameObject);

     }

     void OnDestroy () 
     {
     	SpawnerManag.Instance().RandoPop();
     }

     public void SetTarget (Transform leCube) {

     	attractedTo = leCube;

     }

     void UpSpeed () {

     	if (UImanag.Instance().ScoreSpeed() >= 1000)
     	{
     		speed = 80;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 2000)
     	{
     		speed = 110;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 3000)
     	{
     		speed = 175;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 5000)
     	{
     		speed = 230;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 6000)
     	{
     		speed = 300;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 8000)
     	{
     		speed = 380;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 9000)
     	{
     		speed = 450;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 10000)
     	{
     		speed = 600;
     	}


     }
 }