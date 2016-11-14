using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine.UI;

public class LittleButtonView : View {

	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }

	internal bool open;
	public int value;

	public void closePanel()
	{
		
		this.gameObject.SetActive (false);
		open = false;

	}


	public void openPanel()
	{
		
		this.gameObject.SetActive (true);
		open = true;


	} 

	public void dropItem(int value)
	{
		this.value = value;	
		viewDispatcher.Dispatch (GameEvents.DROP_ITEM, value);



	}

}
