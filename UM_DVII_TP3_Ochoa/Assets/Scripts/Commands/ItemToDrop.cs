using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine.UI;

public class ItemToDrop : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contexView { get; set; }

	[Inject]
	public IInventoryModel inventory { get; set; }

	[Inject]
	public IItemModel itemModel { get; set; }


	public override void Execute()
	{


		int position = (int)evt.data;


		if (inventory.slots.Count >= position) {
			
			dispatcher.Dispatch (GameEvents.TO_DESTROY_ITEM, itemModel.items [position].name);
		

	        inventory.slots [position].GetComponent<Image> ().sprite = Resources.Load <Sprite> ("Sprites/" + PrefabNames.EMPTY_SPRITE);



		}


			dispatcher.Dispatch (GameEvents.READY_TO_INSTANTIATE_ITEM, itemModel.items [position].name);
		    dispatcher.Dispatch (GameEvents.REMOVE_FROM_LIST, itemModel.items[position]);
		  

	}
}

