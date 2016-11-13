using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class PanelButtonViewMediator : EventMediator {


	[Inject]
	public PanelButtonView view { get; set; }

	override public void OnRegister()
	{
		view.desactivatePanel ();
		dispatcher.AddListener (GameEvents.ON_ITEM_SELECTED, activatePanel);
		view.viewDispatcher.AddListener (GameEvents.USE_ITEM, useItem);
		view.viewDispatcher.AddListener (GameEvents.DROP_ITEM, dropItem);
		dispatcher.AddListener (GameEvents.ITEM_POS, getItemPos);
	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener(GameEvents.ON_ITEM_SELECTED, activatePanel);
		view.viewDispatcher.RemoveListener (GameEvents.USE_ITEM, useItem);
		view.viewDispatcher.RemoveListener (GameEvents.DROP_ITEM, dropItem);
	}

	void activatePanel(IEvent evt)
	{
		string itemName = (string)evt.data;
		if (view.open) {
			view.desactivatePanel ();
		}
		else
		{

			view.activatePanel (itemName);

		}
	}

	void useItem()
	{
		dispatcher.Dispatch (GameEvents.USE_ITEM, view.itemName);
	}
	void dropItem()
	{

		dispatcher.Dispatch (GameEvents.DROP_ITEM, view.itemPos);
	}

	void getItemPos(IEvent evt)
	{
		int pos = (int)evt.data;

		view.getItemPos (pos);

	}

	}

