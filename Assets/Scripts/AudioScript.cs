using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

	public AudioSource pow;
	public AudioSource atry;


	// public ParticleSystem psystem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision){

    	// Debug.Log(collision.gameObject.tag);	

     	if (collision.gameObject.tag == gameObject.tag)
     	{
     		pow.Play();
     		// psystem.Play();
     	}

    	else if (collision.gameObject.tag != gameObject.tag)
     	{
     		atry.Play();
     		// psystem.Play();
     	}
    }
}
