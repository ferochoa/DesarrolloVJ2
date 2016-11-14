using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections.Generic;
using UnityEngine.UI;

public class SlotManipulation : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contexView { get; set; }

	[Inject]
	public IInventoryModel inventory { get; set; }



	public override void Execute()

	{
		
		int pos = (int)evt.data;

		inventory.slots [pos].GetComponent<Image>().sprite = Resources.Load<Sprite> ("Sprites/" + PrefabNames.FULL_SPRITE);

				


	}
}