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

		if(inventory.slots.Count >= position)
		{
			
			dispatcher.Dispatch (GameEvents.TO_DESTROY_ITEM,itemModel.items[position].name );
		

			if (inventory.slots [position].transform.childCount != 0)
			{
				//instanciar imagen roja aca
				inventory.slots [position].GetComponent<Image> ().color = (Color.red);
				Debug.Log(inventory.slots [position].transform.childCount);



			}
		}

		if(itemModel.items.Count >= position )
		{
			
			//itemModel.items.RemoveAt (position);
		}

		dispatcher.Dispatch (GameEvents.READY_TO_INSTANTIATE_ITEM, itemModel.items [position].name);


		//eliminamos el item del array y lo eliminamos en su vista.. despues pintamos el slot correspondiente ya que no va a tener hijo
	}
}
