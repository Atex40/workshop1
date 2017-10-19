using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractObject : MonoBehaviour {

 	private Transform attractedTo;
    public float speed = 5.0f;

     void Start () {}
     void FixedUpdate ()

     {
        Vector3 direction = attractedTo.position - transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce((0.01f * speed) * direction);
 
     }

    void OnCollisionEnter(Collision collision){

    	Debug.Log(collision.gameObject.tag);	

     	if (collision.gameObject.tag == gameObject.tag)
     	{
     		UImanag.Instance().AddScore();
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
 }