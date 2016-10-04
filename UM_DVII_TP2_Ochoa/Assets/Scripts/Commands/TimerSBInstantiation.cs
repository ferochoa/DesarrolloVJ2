using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class TimerSBInstantiation : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	override public void Execute()
	{
		GameObject goTimerSB = GameObject.Instantiate(Resources.Load(PrefabNames.TIMERSB_PREFAB)) as GameObject;    

		goTimerSB.name = "TimerSB";

		goTimerSB.AddComponent<TimerSBView> ();

		goTimerSB.transform.parent = contextView.transform;
	}
}
