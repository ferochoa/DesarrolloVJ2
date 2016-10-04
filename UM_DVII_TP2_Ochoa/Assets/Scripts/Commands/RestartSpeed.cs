using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class RestartSpeed : EventCommand
{
	

	[Inject]
	public IPlayerModel myPlayer{ get; set; }


	public override void Execute()
	{
		myPlayer.setSpeed ();
	
		dispatcher.Dispatch (GameEvents.ON_SPEED_RESTARTED, myPlayer.speed);
	}
}

