using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using System.Collections.Generic;

public class InventoryView : View {

	internal bool open;

	public List<IItemModel> items = new List<IItemModel>();



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

	public void addItem(IItemModel item)
	{
		items.Add (item);
		Debug.Log ("Item Agregado");
		Debug.Log (items.Count);

	}
		

	}
	
	

