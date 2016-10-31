using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class RestartEnemySpeed : EventCommand
{


	[Inject]
	public IEnemyModel enemy{ get; set; }


	public override void Execute()
	{
		enemy.setEnemySpeed ();

		dispatcher.Dispatch (GameEvents.ON_ENEMY_SPEED_RESTARTED, enemy.speed);
	}
}

