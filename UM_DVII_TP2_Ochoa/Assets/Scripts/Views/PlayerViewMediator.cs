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
        view.viewDispatcher.AddListener(GameEvents.TO_ADD_SPEED_BONUS, toAddSpeedBonus); 
		view.viewDispatcher.AddListener (GameEvents.TO_ADD_POWER_BONUS, toAddPowerBonus);
		view.viewDispatcher.AddListener (GameEvents.TO_DECREASE_ENEMY_SPEED, toDecreaseEnemySpeed);
        dispatcher.AddListener(GameEvents.ON_PLAYER_GO_LEFT, playerGoLeft);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_RIGHT, playerGoRight);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_FOWARD, playerGoFoward);
		dispatcher.AddListener(GameEvents.ON_PLAYER_GO_BACKWARD, playerGoBackward);
		dispatcher.AddListener(GameEvents.ON_PLAYER_JUMP, playerJump);
		dispatcher.AddListener (GameEvents.ON_SPEED_BONUS_ADDED, updateSpeed);
		dispatcher.AddListener (GameEvents.ON_SPEED_RESTARTED, updateSpeed);
    }

    override public void OnRemove()
    {
        view.viewDispatcher.RemoveListener(GameEvents.TO_ADD_SPEED_BONUS, toAddSpeedBonus);
		view.viewDispatcher.RemoveListener(GameEvents.TO_ADD_POWER_BONUS, toAddPowerBonus);
		view.viewDispatcher.RemoveListener (GameEvents.TO_DECREASE_ENEMY_SPEED, toDecreaseEnemySpeed);
        dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_LEFT, playerGoLeft);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_RIGHT, playerGoRight);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_FOWARD, playerGoFoward);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_BACKWARD, playerGoBackward);
		dispatcher.RemoveListener(GameEvents.ON_PLAYER_JUMP, playerJump);
		dispatcher.RemoveListener (GameEvents.ON_SPEED_BONUS_ADDED, updateSpeed);
		dispatcher.RemoveListener (GameEvents.ON_SPEED_RESTARTED, updateSpeed);
       
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
    void toAddSpeedBonus(IEvent evt)
    {
		dispatcher.Dispatch(GameEvents.TO_ADD_SPEED_BONUS, view.COLLECTABLE1);
    }

	void toAddPowerBonus(IEvent evt)
	{
		dispatcher.Dispatch(GameEvents.TO_ADD_POWER_BONUS, view.COLLECTABLE2);

	}

	void toDecreaseEnemySpeed()
	{
		dispatcher.Dispatch (GameEvents.TO_DECREASE_ENEMY_SPEED, view.COLLECTABLE3);
	}

	void updateSpeed(IEvent evt)
	{
		
		float speed =(float)evt.data;       
		view.updateSpeed (speed);
	}

}