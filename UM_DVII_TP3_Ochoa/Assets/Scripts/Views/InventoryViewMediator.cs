using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class InventoryViewMediator : EventMediator {

	[Inject]
	public InventoryView view { get; set; }




	override public void OnRegister()
	{
		view.closeInventary ();
		dispatcher.AddListener (GameEvents.ON_INVENTORY_MANIPULATION, openInventory);
		dispatcher.AddListener (GameEvents.ON_ITEM_ADDED_TO_INVENTORY, itemControl);
		view.viewDispatcher.AddListener (GameEvents.PAINT_SLOT_ITEM_INVENTORY, paintSlot);
	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_INVENTORY_MANIPULATION, openInventory);
		dispatcher.RemoveListener (GameEvents.ON_ITEM_ADDED_TO_INVENTORY, itemControl);
		view.viewDispatcher.RemoveListener (GameEvents.PAINT_SLOT_ITEM_INVENTORY, paintSlot);
	}

	void openInventory()
	{
		if (view.open) {
			view.closeInventary ();
		}
		else 
		{
			view.openInventory ();

		}
	}

	void itemControl( IEvent evt)
	{
		
		int pos = (int)evt.data;
		view.itemControl (pos);
		//Debug.Log ("pos q recibo :" + pos);
	}

	void paintSlot()
	{
		dispatcher.Dispatch (GameEvents.PAINT_SLOT_ITEM_INVENTORY, view.position);
	}

}
