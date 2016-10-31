using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class DecreaseEnemySpeed : EventCommand
{
	private float speedPenalty;

	[Inject]
	public IEnemyModel enemy{ get; set; }
	public override void Execute ()
	{
		string viewName = (string)evt.data;
		ICollectableModel collectableModel = injectionBinder.GetBinding(viewName).value as ICollectableModel;
		collectableModel.setSpeedPenalty ();
		enemy.setEnemySpeed ();
		speedPenalty = enemy.speed - collectableModel.speedPenalty;
		dispatcher.Dispatch (GameEvents.ON_ENEMY_SPEED_DECREASED, speedPenalty);
	
	}

}
