using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractObject : MonoBehaviour {

 	private Transform attractedTo;
    private float speed = 20f;
    public int earnedScore;

     void Start () {
        
     	// if(!UImanag.Instance().IsGameOn())
     	// {
     	// 	gameObject.SetActive(false);
     	// }
     }

     void FixedUpdate ()

     {
        UpSpeed ();         
        Vector3 direction = attractedTo.position - transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce((0.01f * speed) * direction);
     }

    void OnCollisionEnter(Collision collision){

    	// Debug.Log(collision.gameObject.tag);	

     	if (collision.gameObject.tag == gameObject.tag)
     	{
     		UImanag.Instance().AddScore(earnedScore);
     		EconomyManager.Instance().AddMoney();
            UImanag.Instance().CountVie(earnedScore);
     	}

    	else if (collision.gameObject.tag != gameObject.tag)
     	{
     		UImanag.Instance().LooseLife();
     	}

     	Destroy(gameObject);

     }

     void OnDestroy () 
     {
        if(UImanag.Instance().IsGameOn())
        {
     	  SpawnerManag.Instance().RandoPop();
        }
        
         AudioSource audio = GetComponent<AudioSource>();
         audio.Play();
     }

     public void SetTarget (Transform leCube) {

     	attractedTo = leCube;

     }

     void UpSpeed () {

     	if (UImanag.Instance().ScoreSpeed() >= 1000)
     	{
     		speed = 20f;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 2000)
     	{
     		speed = 30f;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 3000)
     	{
     		speed = 45f;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 5000)
     	{
     		speed = 60f;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 6000)
     	{
     		speed = 75f;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 8000)
     	{
     		speed = 100f;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 9000)
     	{
     		speed = 125f;
     	}

     	if (UImanag.Instance().ScoreSpeed() >= 10000)
     	{
     		speed = 150f;
     	}


     }

public GameObject LesObjets () {

return gameObject;

}
}
