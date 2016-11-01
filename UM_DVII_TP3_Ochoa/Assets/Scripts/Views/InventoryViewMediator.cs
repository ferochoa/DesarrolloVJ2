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
		dispatcher.AddListener (GameEvents.ITEM_PICKED_UP, addItem);

	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_INVENTORY_MANIPULATION, openInventory);
		dispatcher.AddListener (GameEvents.ITEM_PICKED_UP, addItem);
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
	void addItem(IEvent evt)
	{

		view.addItem ();
	}
}
