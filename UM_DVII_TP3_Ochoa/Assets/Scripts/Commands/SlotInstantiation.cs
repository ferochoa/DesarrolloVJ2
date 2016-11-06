using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine.UI;

public class SlotInstantiation :EventCommand {


	private const int TOTAL_SLOTS = 6;

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	[Inject]
	public IInventoryModel inventory { get; set; }


	override public void Execute()
	{
		for (int i = 0; i < TOTAL_SLOTS; i++) {
			GameObject goSlot = GameObject.Instantiate (Resources.Load (PrefabNames.SLOT_PREFAB)) as GameObject;
			goSlot.GetComponent<Image> ().sprite = Resources.Load <Sprite> ("Sprites/" + PrefabNames.EMPTY_SPRITE);
			goSlot.name = "Slot "+(i+1);
			goSlot.transform.SetParent (contextView.transform.FindChild ("Inventory").FindChild ("InventoryPanel").transform,false);
			inventory.slots.Add (goSlot);

		}

	}

}