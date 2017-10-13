using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractObject : MonoBehaviour {

 	public GameObject attractedTo;
    public float speed = 5.0f;

     void Start () {}
     void FixedUpdate ()

     {
        Vector3 direction = attractedTo.transform.position - transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce((0.01f * speed) * direction);
 
     }

     void OnTriggerEnter () {

     	Destroy(gameObject);
     }

     void OnDestroy () 
     {
     	SpawnerManag.Instance().RandoPop();
     }
 }