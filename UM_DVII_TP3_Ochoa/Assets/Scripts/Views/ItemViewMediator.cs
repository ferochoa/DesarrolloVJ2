using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class ItemViewMediator : EventMediator {

	[Inject]
	public ItemView view { get; set; }

	override public void OnRegister()
	{
		view.viewDispatcher.AddListener (GameEvents.ITEM_PICKED_UP, itemPickedUp);
		dispatcher.AddListener (GameEvents.TO_DESTROY_ITEM, destroyItem);
	}

	override public void OnRemove()
	{
		view.viewDispatcher.RemoveListener (GameEvents.ITEM_PICKED_UP, itemPickedUp);
		dispatcher.RemoveListener (GameEvents.TO_DESTROY_ITEM, destroyItem);
	}

	void itemPickedUp()
	{
		dispatcher.Dispatch (GameEvents.ITEM_PICKED_UP, view.gameObject);
	}
	void destroyItem(IEvent evt)
	{
		
		string itemName = (string)evt.data;
		view.destroyItem (itemName);

	}
}
