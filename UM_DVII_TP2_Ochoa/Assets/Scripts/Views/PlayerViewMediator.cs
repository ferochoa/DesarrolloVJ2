using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class PlayerViewMediator : EventMediator
{

    [Inject]
    public PlayerView view { get; set; }

    override public void OnRegister()
    {
        view.init();
        //view.viewDispatcher.AddListener(GameEvents.ON_ENEMY_COLLISION, onEnemyCollision);
        view.viewDispatcher.AddListener(GameEvents.ON_COLLECTABLE_COLLISION, onCollectableCollision);
        dispatcher.Dispatch(GameEvents.ON_COLLECTABLE_COLLISION, view.COLLECTABLE1);   
        dispatcher.AddListener(GameEvents.ON_PLAYER_GO_LEFT, playerGoLeft);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_RIGHT, playerGoRight);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_FOWARD, playerGoFoward);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_BACKWARD, playerGoBackward);
		dispatcher.AddListener(GameEvents.ON_PLAYER_JUMP, playerJump);
    }

    override public void OnRemove()
    {
        view.viewDispatcher.RemoveListener(GameEvents.ON_COLLECTABLE_COLLISION, onCollectableCollision);
        dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_LEFT, playerGoLeft);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_RIGHT, playerGoRight);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_FOWARD, playerGoFoward);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_BACKWARD, playerGoBackward);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_JUMP, playerJump);
       
    }

   void playerGoLeft()
    {
        view.playerGoLeft();
    }
	void playerGoRight()
	{
		view.playerGoRight();
	}
	void playerGoFoward()
	{
		view.playerGoFoward ();
	}
	void playerGoBackward()
	{
		view.playerGoBackward ();
	}
	void playerJump()
	{
		view.playerJump();
	}
   /* void onEnemyCollision()
    {
        dispatcher.Dispatch(GameEvents.ON_ENEMY_COLLISION);
    }*/
    void onCollectableCollision(IEvent evt)
    {
        dispatcher.Dispatch(GameEvents.ON_COLLECTABLE_COLLISION, evt.data);
    }

}