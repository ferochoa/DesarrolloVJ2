using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections.Generic;

public class ItemToAdd : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contexView { get; set; }

	[Inject]
	public IItemModel itemModel { get; set; }



	public override void Execute()
	{

		string viewName = (string)evt.data;
		IItemModel itemModel = injectionBinder.GetBinding(viewName).value as IItemModel;

		dispatcher.Dispatch (GameEvents.ADD_ITEM, itemModel);
	}
}
