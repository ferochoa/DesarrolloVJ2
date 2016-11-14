using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class DropButtonView : View {

	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }

	public int value;

	public void sendValue()
	{
		
		viewDispatcher.Dispatch(GameEvents.SEND_VALUE,value);
	}

}
