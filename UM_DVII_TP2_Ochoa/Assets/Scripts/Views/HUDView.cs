using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using UnityEngine.UI;

public class HUDView : View
{

    //private int playerPoints = 0;
    private const string GAME_OVER = "GAME OVER";

    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }

  

    public void Update() {
	
	}

    public void updatePoints(int points)
    {
       // playerPoints = points;
        Debug.Log("puntos: " +points);
    }

    public void gameOver()
    {
        Debug.Log(GAME_OVER);
    }


}
