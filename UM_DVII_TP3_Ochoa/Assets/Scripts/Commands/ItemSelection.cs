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
				
				inventory.slots [position].GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Sprites/" + PrefabNames.SELECTION_SPRITE);
				full = true;
			}
		}

		if(itemModel.items.Count >= position && full == true)
		{
			Debug.Log ("Item seleccionado: " + itemModel.items [position].name);
			dispatcher.Dispatch (GameEvents.ON_ITEM_SELECTED, itemModel.items[position].name);
			dispatcher.Dispatch (GameEvents.ITEM_POS, position);
		}
	}
}
