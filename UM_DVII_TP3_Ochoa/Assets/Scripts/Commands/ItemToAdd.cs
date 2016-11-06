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

		GameObject item = (GameObject)evt.data;
		itemModel.items.Add (item);
		//Debug.Log (itemModel.items.Count);
		//Debug.Log(item.name);

		dispatcher.Dispatch (GameEvents.ON_ITEM_ADDED_TO_INVENTORY);

	}
}
