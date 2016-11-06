using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class ItemViewMediator : EventMediator {

	[Inject]
	public ItemView view { get; set; }

	override public void OnRegister()
	{
		view.viewDispatcher.AddListener (GameEvents.ITEM_PICKED_UP, itemPickedUp);
	}

	override public void OnRemove()
	{
		view.viewDispatcher.RemoveListener (GameEvents.ITEM_PICKED_UP, itemPickedUp);
	}

	void itemPickedUp()
	{
		dispatcher.Dispatch (GameEvents.ITEM_PICKED_UP, view.gameObject);
	}
}
