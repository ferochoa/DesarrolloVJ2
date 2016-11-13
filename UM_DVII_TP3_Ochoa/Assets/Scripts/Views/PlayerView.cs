using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;


public class PlayerView : View {

    
   
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
	   viewDispatcher.Dispatch (GameEvents.ON_UPDATE_PLAYER_POSITION, this.transform.position);
    }
    public void playerGoRight()
	{
        rb.AddForce(new Vector3(-1, 0, 0) * speed, ForceMode.Force);
		viewDispatcher.Dispatch (GameEvents.ON_UPDATE_PLAYER_POSITION, this.transform.position);
    }
	public void playerGoFoward()
	{
        rb.AddForce(new Vector3(0, 0, 1) * speed, ForceMode.Force);
		viewDispatcher.Dispatch (GameEvents.ON_UPDATE_PLAYER_POSITION, this.transform.position);
    }
	public void playerGoBackward()
	{
        rb.AddForce(new Vector3(0, 0, -1) * speed, ForceMode.Force);
		viewDispatcher.Dispatch (GameEvents.ON_UPDATE_PLAYER_POSITION, this.transform.position);
    }
	public void playerJump()
	{
        rb.AddForce(new Vector3(0, 1, 0) * speed, ForceMode.Force);
		viewDispatcher.Dispatch (GameEvents.ON_UPDATE_PLAYER_POSITION, this.transform.position);
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
