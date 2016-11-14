using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine.UI;

public class PaintSlot : EventCommand {

	[Inject]
	public IInventoryModel inventory { get; set; }



	public override void Execute()
	{
		for (int i = 0; i < inventory.slots.Count; i++) {
			
			if (inventory.slots [i].transform.childCount == 0) {


				inventory.slots [i].GetComponent<Image> ().sprite = Resources.Load <Sprite> ("Sprites/" + PrefabNames.EMPTY_SPRITE);


			}

		}

	}
}
