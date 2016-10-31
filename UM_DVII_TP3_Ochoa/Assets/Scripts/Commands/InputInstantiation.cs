using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InputInstantiation : EventCommand
{
	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	override public void Execute()
	{

	GameObject go4 = GameObject.Instantiate(Resources.Load(PrefabNames.INPUT_PREFAB)) as GameObject;

	go4.name = "Input";

	go4.AddComponent<InputView>();

	go4.transform.parent = contextView.transform;

    dispatcher.Dispatch(GameEvents.READY_TO_GO);
    }
}