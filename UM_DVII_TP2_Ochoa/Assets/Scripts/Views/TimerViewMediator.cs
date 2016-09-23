using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class TimerViewMediator : EventMediator
{

    [Inject]
    public TimerView view { get; set; }

    override public void OnRegister()
    {
        view.viewDispatcher.AddListener(GameEvents.GAME_OVER, gameFinished);
    }
    override public void OnRemove()
    {
        view.viewDispatcher.RemoveListener(GameEvents.GAME_OVER, gameFinished);
    } 

    void gameFinished()
    {
        dispatcher.Dispatch(GameEvents.GAME_OVER);
        
    }
}