using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;


public class UpdatePlayerPosition : EventCommand{


	[Inject]
	public IPlayerModel myPlayer { get; set; }


	public override void Execute()
	{

		Vector3 pos = (Vector3)evt.data;
		myPlayer.position = pos;
	}
}
