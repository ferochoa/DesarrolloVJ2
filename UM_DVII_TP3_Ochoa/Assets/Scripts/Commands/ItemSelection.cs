using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine.UI;

public class ItemSelection : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contexView { get; set; }

	[Inject]
	public IInventoryModel inventory { get; set; }

	[Inject]
	public IItemModel itemModel { get; set; }


	public override void Execute()
	{

		int position = (int)evt.data;
		bool full = false;

		if(inventory.slots.Count >= position)
		{
			if (inventory.slots [position].transform.childCount != 0)
			{
				// hacer un método en la vista que se encargue de esto
				inventory.slots [position].GetComponent<Image> ().color = (Color.black);
				full = true;
			}
		}

		if(itemModel.items.Count >= position && full == true)
		{
			Debug.Log("asdljnasdasd2");
			dispatcher.Dispatch (GameEvents.ON_ITEM_SELECTED, itemModel.items[position].name);
		}
	}
}
