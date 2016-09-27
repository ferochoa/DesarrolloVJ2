using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using System;

public class PlayerView : View {

    private const string ENEMY = "Enemy";
    public string COLLECTABLE1 = "Collectable1";
   

    Rigidbody rb;
    public float speed;


    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }

     internal void init()
    {
        rb = GetComponent<Rigidbody>();
        speed =200; // prueba, esto no va aca
       
    }

    void OnCollisionEnter(Collision col)
    {
       /* if(col.gameObject.tag == ENEMY)
        {
            viewDispatcher.Dispatch(GameEvents.ON_ENEMY_COLLISION);
        }*/
        if(col.gameObject.name == COLLECTABLE1)
        {
            viewDispatcher.Dispatch(GameEvents.ON_COLLECTABLE_COLLISION, COLLECTABLE1);
        }
    }

   

    public void playerGoLeft()
    {
       rb.AddForce(new Vector3(1, 0, 0) * speed, ForceMode.Force);

    }
    public void playerGoRight()
	{
        rb.AddForce(new Vector3(-1, 0, 0) * speed, ForceMode.Force);
    }
	public void playerGoFoward()
	{
        rb.AddForce(new Vector3(0, 0, -1) * speed, ForceMode.Force);
    }
	public void playerGoBackward()
	{
        rb.AddForce(new Vector3(0, 0, 1) * speed, ForceMode.Force);
    }
	public void playerJump()
	{
        rb.AddForce(new Vector3(0, 1, 0) * speed, ForceMode.Force);
    }
    public void getSpeed(float speed)
    {
        Debug.Log("Speed: "+speed);
    }
}
