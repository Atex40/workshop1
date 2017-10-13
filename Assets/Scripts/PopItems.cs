using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PopItems : MonoBehaviour {

	public List<GameObject> popRandom = new List<GameObject>();
    private float nbmaxprefab =0f;
    public float spawnInterval = 3.0f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("RandoPop", 0.001f, spawnInterval);
	}
	
	// Update is called once per frame
	void Update () {			

	}

	void RandoPop () {

				if (nbmaxprefab < 1000) 
      	{
    		int tempory = UnityEngine.Random.Range(0,popRandom.Count);
    		GameObject iGo;
    		iGo = Instantiate(popRandom[tempory], transform.position, transform.rotation);
        	nbmaxprefab += 1f;
  		}
	}
}
