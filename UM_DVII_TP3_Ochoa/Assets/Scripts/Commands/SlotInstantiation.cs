using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class SlotInstantiation :EventCommand {


	private const int TOTAL_SLOTS = 6;

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	override public void Execute()
	{
		for (int i = 0; i < TOTAL_SLOTS; i++) {
			GameObject goSlot = GameObject.Instantiate (Resources.Load (PrefabNames.SLOT_PREFAB)) as GameObject;
			goSlot.name = "Slot "+(i+1);
			goSlot.transform.SetParent (contextView.transform.FindChild ("Inventory").FindChild ("InventoryPanel").transform);
		}
	}

}