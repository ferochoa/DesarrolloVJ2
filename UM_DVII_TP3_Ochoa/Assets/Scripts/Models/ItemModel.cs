using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemModel : IItemModel {

	public float itemPower { get; set;}
	public string name { get; set; }

	public List<GameObject> items { get; set; }
	public string ItemEvent{ get; set; }

	[PostConstruct]
	public void PostConstruct()
	{
		items = new List<GameObject> ();
	}
}
