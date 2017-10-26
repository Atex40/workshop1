using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractObject : MonoBehaviour {

 	private Transform attractedTo;
    private float speed = 20f;
    public int earnedScore;

    private ParticleSystem psystem;
    public List<ParticleSystem> particles;

     void Start () {
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
     		EconomyManager.Instance().GetMoney();
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
            int tryhard = UnityEngine.Random.Range(0,particles.Count);
            psystem = Instantiate(particles[tryhard], gameObject.transform.position, Quaternion.identity);
            psystem.Play();
            //Destroy(psystem);
            SpawnerManag.Instance().RandoPop();
        }       

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
