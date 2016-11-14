using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class LittleButtonViewMediator : EventMediator {

	[Inject]
	public LittleButtonView view { get; set; }




	override public void OnRegister()
	{
		view.closePanel ();
		dispatcher.AddListener (GameEvents.ON_INVENTORY_MANIPULATION, openPanel);
		dispatcher.AddListener (GameEvents.SEND_VALUE, dropItem);
		view.viewDispatcher.AddListener (GameEvents.DROP_ITEM, toDropItem);
	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_INVENTORY_MANIPULATION, openPanel);
		dispatcher.RemoveListener (GameEvents.SEND_VALUE, dropItem);
		view.viewDispatcher.RemoveListener (GameEvents.DROP_ITEM, toDropItem);

	}

	void openPanel()
	{
		if (view.open) {
			view.closePanel ();
		}
		else 
		{
			view.openPanel();

		}
	}

	void dropItem(IEvent evt)
	{
		
		int value = (int)evt.data;
		view.dropItem (value);

	}
	void toDropItem()
	{

		dispatcher.Dispatch (GameEvents.DROP_ITEM, view.value);

	}
}
