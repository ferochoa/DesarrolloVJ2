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

	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_INVENTORY_MANIPULATION, openPanel);

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
}
