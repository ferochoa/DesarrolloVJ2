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
        
        dispatcher.AddListener(GameEvents.ON_PLAYER_GO_LEFT, playerGoLeft);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_RIGHT, playerGoRight);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_FOWARD, playerGoFoward);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_BACKWARD, playerGoBackward);
		dispatcher.AddListener(GameEvents.ON_PLAYER_JUMP, playerJump);
		dispatcher.AddListener (GameEvents.ON_SPEED_BONUS_ADDED, updateSpeed);
		dispatcher.AddListener (GameEvents.ON_SPEED_RESTARTED, updateSpeed);
		dispatcher.AddListener (GameEvents.ON_HEALTH_BONUS_ADDED, updateHealth);
    }

    override public void OnRemove()
    {
      
        dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_LEFT, playerGoLeft);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_RIGHT, playerGoRight);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_FOWARD, playerGoFoward);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_BACKWARD, playerGoBackward);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_JUMP, playerJump);
		dispatcher.RemoveListener (GameEvents.ON_SPEED_BONUS_ADDED, updateSpeed);
		dispatcher.RemoveListener (GameEvents.ON_SPEED_RESTARTED, updateSpeed);
		dispatcher.RemoveListener (GameEvents.ON_HEALTH_BONUS_ADDED, updateHealth);
       
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
  

	void updateSpeed(IEvent evt)
	{
		
		float speed =(float)evt.data;       
		view.updateSpeed (speed);
	}
	void updateHealth(IEvent evt)
	{

		float health = (float)evt.data;
		view.updateHealth (health);
	}
}