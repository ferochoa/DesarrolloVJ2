using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class PlayerViewMediator : EventMediator
{

    [Inject]
    public PlayerView view { get; set; }

    override public void OnRegister()
    {
        view.viewDispatcher.AddListener(GameEvents.PLAYER_SHOOT, onPlayerShot);
    }

    override public void OnRemove()
    {
        view.viewDispatcher.AddListener(GameEvents.PLAYER_SHOOT, onPlayerShot);
    }

    private void onPlayerShot()
    {
        dispatcher.Dispatch(GameEvents.PLAYER_SHOOT, view.transform.position);
    }
}