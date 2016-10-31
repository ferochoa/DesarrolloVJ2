﻿using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class InventoryView : View {

	internal bool open;



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
		
			
	}
	
	
