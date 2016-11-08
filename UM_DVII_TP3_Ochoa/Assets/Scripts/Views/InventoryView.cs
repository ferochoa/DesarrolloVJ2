using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using System.Collections.Generic;

public class InventoryView : View {

	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }

	internal bool open;
	public int position;






	public void closeInventary()
	{
		Debug.Log ("Inventario cerrado");
		 this.gameObject.SetActive (false);
		 open = false;

	}


	public void openInventory()
	{
		Debug.Log ("inventario abierto");
		this.gameObject.SetActive (true);
		open = true;
	


	} 


	public void itemControl(int pos)
	{
		position = pos;
		viewDispatcher.Dispatch (GameEvents.PAINT_SLOT_ITEM_INVENTORY,position);




	}

	}
	
	
