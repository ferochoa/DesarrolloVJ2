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
	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener(GameEvents.ON_ITEM_SELECTED, activatePanel);
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

	}

