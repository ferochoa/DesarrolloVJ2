using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class SetEventCollectable : EventCommand
{


	public override void Execute()
	{
		
		string viewName = (string)evt.data;
		ICollectableModel collectableModel = injectionBinder.GetBinding(viewName).value as ICollectableModel;
		dispatcher.Dispatch (collectableModel.collEvent, viewName);

	}
}