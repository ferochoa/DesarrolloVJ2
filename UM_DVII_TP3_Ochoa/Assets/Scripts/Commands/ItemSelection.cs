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


		for(int j =0; j< inventory.slots.Count; j++)
		{
			if (inventory.slots [position].transform.childCount != 0) {
				inventory.slots [position].GetComponent<Image> ().color = (Color.black);
				full = true;
			} 
			else 
			{
				Debug.Log ("En la posicion " + (position+1) + " no hay ningun item para seleccionar");
			}
		}




		for(int i =0;i< itemModel.items.Count; i++)
		{
			if (full == true)
			{
				Debug.Log (itemModel.items [position].name + " seleccionado");
				dispatcher.Dispatch (GameEvents.ON_ITEM_SELECTED, itemModel.items[position].name);

			}
		}


	

	}


}
