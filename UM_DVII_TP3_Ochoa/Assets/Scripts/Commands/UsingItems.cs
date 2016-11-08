using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;


public class UsingItems :EventCommand {


	public override void Execute(){


		string viewName = (string)evt.data;
		IweaponHealhPackModel itemModel = injectionBinder.GetBinding(viewName).value as IweaponHealhPackModel;
		//Debug.Log (itemModel.itemEvent);
		dispatcher.Dispatch (itemModel.itemEvent, viewName);
	}
}
