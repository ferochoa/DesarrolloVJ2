using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;


public class UsingItems :EventCommand {


	public override void Execute(){

		Debug.Log ("estoy aca");
		string viewName = (string)evt.data;

		IItemModel itemModel = injectionBinder.GetBinding(viewName).value as IItemModel;
		Debug.Log (itemModel.ItemEvent);
		dispatcher.Dispatch (itemModel.ItemEvent, viewName);
	}
}
