using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class InputView : View
{
    
    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
		{
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_GO_LEFT);
		
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_GO_RIGHT);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_GO_FOWARD);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_GO_BACKWARD);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_JUMP);

        }

    }
}
