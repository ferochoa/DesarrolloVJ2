using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine.UI;

public class PanelButtonView :View {
	 
	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }

	internal bool open;
	public string itemName;
	public int itemPos;

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
		
		viewDispatcher.Dispatch (GameEvents.USE_ITEM, itemName);

	}
	public void dropItem()
	{

		viewDispatcher.Dispatch (GameEvents.DROP_ITEM, itemPos);

	}

	public void getItemPos(int pos)
	{

		itemPos = pos;
		Debug.Log (itemPos);
	}
}
