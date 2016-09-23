using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class PlayerView : View {


    [Inject]
	public IEventDispatcher viewDispatcher { get; set; }



    public void playerGoLeft()
    {
         Debug.Log("El player se ha movido a la izquierda");
       

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
