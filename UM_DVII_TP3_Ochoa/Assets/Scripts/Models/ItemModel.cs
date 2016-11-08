using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemModel : IItemModel {



	public List<GameObject> items { get; set; }


	[PostConstruct]
	public void PostConstruct()
	{
		items = new List<GameObject> ();
	}
}
