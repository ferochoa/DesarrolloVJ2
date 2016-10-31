using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class PlayerSpeedUp : EventCommand
{

	private float speedIncreased; 


   

	[Inject]
	public IPlayerModel myPlayer{ get; set; }
  

    public override void Execute()
    {
       
        string viewName = (string)evt.data;
		ICollectableModel collectableModel = injectionBinder.GetBinding(viewName).value as ICollectableModel;
        
		collectableModel.setSpeedBonus();
		myPlayer.setSpeed ();
		speedIncreased = myPlayer.speed + collectableModel.speedBonus;

		dispatcher.Dispatch(GameEvents.ON_SPEED_BONUS_ADDED, speedIncreased);



	}
        
}     
		  
   