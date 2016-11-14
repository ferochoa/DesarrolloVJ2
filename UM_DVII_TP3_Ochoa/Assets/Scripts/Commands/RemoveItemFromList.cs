using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class RemoveItemFromList : EventCommand {


	[Inject]
	public IItemModel itemModel { get; set; }

	public override void Execute()
	{

		GameObject item = (GameObject)evt.data;

		itemModel.items.Remove (item);

	}
}
