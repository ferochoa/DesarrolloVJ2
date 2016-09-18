using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class PlayerViewMediator : EventMediator
{

    [Inject]
    public PlayerView view { get; set; }

    override public void OnRegister()
    {
        dispatcher.AddListener(GameEvents.ON_PLAYER_GO_LEFT, playerMovement);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_RIGHT, playerMovement);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_FOWARD, playerMovement);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_BACKWARD, playerMovement);
		dispatcher.AddListener(GameEvents.ON_PLAYER_JUMP, playerMovement);
    }

    override public void OnRemove()
    {
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_LEFT, playerMovement);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_RIGHT, playerMovement);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_FOWARD, playerMovement);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_BACKWARD, playerMovement);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_JUMP, playerMovement);
       
    }

   void playerMovement()
    {
        view.playerMovement();
    }
}