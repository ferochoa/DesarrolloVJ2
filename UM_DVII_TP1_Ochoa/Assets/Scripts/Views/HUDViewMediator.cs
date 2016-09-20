using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class HUDViewMediator : EventMediator
{

    [Inject]
    public HUDView view { get; set; }
   

    override public void OnRegister()
    {
        dispatcher.AddListener(GameEvents.GAME_OVER, gameOver);
        dispatcher.AddListener(GameEvents.ON_SET_POINTS, updatePoints);
    }
    public override void OnRemove()
    {
        dispatcher.RemoveListener(GameEvents.GAME_OVER, gameOver);
        dispatcher.RemoveListener(GameEvents.ON_SET_POINTS, updatePoints);
    }

    void gameOver()
    {
        view.gameOver();
    }
    void updatePoints(IEvent evt)
    {
        int points =(int)evt.data;
        Debug.Log(points);
        view.updatePoints(points);
    }
}
