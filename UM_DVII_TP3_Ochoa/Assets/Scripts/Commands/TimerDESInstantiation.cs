using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class TimerDESInstantiation : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	override public void Execute()
	{
		GameObject goTimerDES = GameObject.Instantiate(Resources.Load(PrefabNames.TIMERDES_PREFAB)) as GameObject;    

		goTimerDES.name = "TimerDES";

		goTimerDES.AddComponent<TimerDESView> ();

		goTimerDES.transform.parent = contextView.transform;
	}
}
