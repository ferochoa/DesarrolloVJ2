using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using System.Collections.Generic;

public class InventoryView : View {

	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }

	internal bool open;
	internal int totalItems = 0;
	internal const int ITEMSCAPACITY = 6;


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


	public void itemControl()
	{
		
		viewDispatcher.Dispatch (GameEvents.PAINT_SLOT_ITEM_INVENTORY, totalItems);
		totalItems++;
		if (totalItems == ITEMSCAPACITY) {
			totalItems = 0;
		}

	}

	}
	
	
