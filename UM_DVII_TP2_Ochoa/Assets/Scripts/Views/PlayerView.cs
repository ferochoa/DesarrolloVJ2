using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class PlayerView : View {

    private const string ENEMY = "Enemy";
    private const string COLLECTABLE = "Collectable";
    Rigidbody rb;
    public float speed;


    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }

     void init()
    {
        rb = GetComponent<Rigidbody>();
        speed = 50;
    }

    void OnCollision(Collision coll)
    {
        if(coll.gameObject.tag == ENEMY)
        {
            viewDispatcher.Dispatch(GameEvents.ON_ENEMY_COLLISION);
        }
        if(coll.gameObject.tag == COLLECTABLE)
        {
            viewDispatcher.Dispatch(GameEvents.ON_COLLECTABLE_COLLISION);
        }
    }




    public void playerGoLeft()
    {
         Debug.Log("El player se ha movido a la izquierda");

        rb.AddForce(new Vector3(1, 0, 0) * speed, ForceMode.Force);

    }
    public void playerGoRight()
	{
		Debug.Log("El player se ha movido a la derecha ");
	}
	public void playerGoFoward()
	{
	    Debug.Log("El player se ha movido hacia adelante");
	}
	public void playerGoBackward()
	{
		Debug.Log("El player se ha movido hacia atras");
	}
	public void playerJump()
	{
		Debug.Log("El player se ha saltado");
	}
   
}
