using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using UnityEngine.UI;

public class HUDView : View
{

    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }

    
    public void Update() {
	
	}

    public void updatePoints(int points)
    {
        Debug.Log("puntos");
    }

    public void gameOver()
    {
        Debug.Log("El juego ha terminado");
    }


}
