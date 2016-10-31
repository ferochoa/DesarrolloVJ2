using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InventoryInstantiation :EventCommand {
	

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	override public void Execute()
	{
		GameObject goInv = GameObject.Instantiate(Resources.Load(PrefabNames.INVENTORY_PREFAB)) as GameObject;
		goInv.transform.FindChild ("InventoryPanel").gameObject.AddComponent<InventoryView> ();
		goInv.name = "Inventory";
		goInv.transform.SetParent(contextView.transform);
	}
}
