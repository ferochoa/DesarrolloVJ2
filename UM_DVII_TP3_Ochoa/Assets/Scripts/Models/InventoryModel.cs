using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryModel : IInventoryModel {

	public List<GameObject> slots { get; set; }

	[PostConstruct]
	public void PostConstruct()
	{
		slots = new List<GameObject> ();
	}
	
	}

