using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class DropButtonViewMediator : EventMediator  {

	[Inject]
	public DropButtonView view { get; set; }


	override public void OnRegister()
	{
		
		view.viewDispatcher.AddListener (GameEvents.SEND_VALUE, toSendValue);
	}

	override public void OnRemove()
	{
		
		view.viewDispatcher.RemoveListener (GameEvents.SEND_VALUE, toSendValue);
	}

	void toSendValue()
	{
		
		dispatcher.Dispatch (GameEvents.SEND_VALUE, view.value);
	}

}

