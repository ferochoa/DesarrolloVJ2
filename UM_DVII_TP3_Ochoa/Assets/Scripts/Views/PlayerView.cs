using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;


public class PlayerView : View {

    private const string ENEMY = "Enemy";
    public string COLLECTABLE1 = "Collectable1"; 
	public string COLLECTABLE2 = "Collectable2";
	public string COLLECTABLE3 = "Collectable3"; 

    private Rigidbody rb;
    private float speed;



    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }

     internal void init()
    {
        rb = GetComponent<Rigidbody>();
        
       
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
    public void updateSpeed(float speed)
    {
		this.speed = speed;
        Debug.Log("Speed: "+speed);
    }

	public void updateHealth(float health)
	{
		Debug.Log ("Health: " + health);

	}
}
