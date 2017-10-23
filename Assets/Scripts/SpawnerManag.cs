using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManag : MonoBehaviour {	

	public List<GameObject> spawnItems = new List<GameObject>();
	public Transform[] spawnPoints;
	private float nbmaxprefab =0f;
	public Transform mainCube;
	private GameObject iGo;

	private static SpawnerManag instance ;
    public static SpawnerManag Instance ()
    {
        return instance;
    }

	void Awake ()
    {
        if (instance != null)
        {
            Destroy (gameObject);
        }
        else 
        {
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {
		RandoPop();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void RandoPop () {

		if (nbmaxprefab < 1000) 
    	{
    		int tempory = UnityEngine.Random.Range(0,spawnItems.Count);
    		int spwn = UnityEngine.Random.Range(0, spawnPoints.Length);
    		iGo = Instantiate(spawnItems[tempory], spawnPoints[spwn].position, Quaternion.identity);
        	nbmaxprefab += 1f;
        	iGo.GetComponent<AttractObject>().SetTarget(mainCube);
  		}
	}
}
