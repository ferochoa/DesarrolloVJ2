using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine.UI;

public class PanelButtonView :View {
	 
	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }

	internal bool open;
	public string itemName;

	public void activatePanel(string itemName)
	{
		
		this.gameObject.SetActive (true);
		this.itemName = itemName;
		open = true;

	}


	public void desactivatePanel()
	{
		
		this.gameObject.SetActive (false);
		open = false;
	}
	public void useItem()
	{
		Debug.Log ("despacho este item " + itemName);
		viewDispatcher.Dispatch (GameEvents.USE_ITEM, itemName);

	}
}
