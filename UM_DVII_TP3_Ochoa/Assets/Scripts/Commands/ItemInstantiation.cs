using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;




public class ItemInstantiation : EventCommand
{
	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }


	public override void Execute()
	{



		TextAsset file = Resources.Load("Items") as TextAsset;

		var n = SimpleJSON.JSON.Parse(file.text);


		for (int i = 0; i < n.Count; i++)
		{
			IItemModel itemModel = injectionBinder.GetInstance<IItemModel>();
			string itemName = n [i]["name"].Value;  
			string itemTag = n [i] ["tag"].Value;
			float posX = n [i] ["posX"].AsFloat;
			float posY = n [i] ["posY"].AsFloat;
			float posZ = n [i] ["posZ"].AsFloat;

			itemModel.itemPower = n [i] ["power"].AsFloat;
			itemModel.name = itemName;

			GameObject goItem = GameObject.Instantiate(Resources.Load(n [i]["prefabName"].Value)) as GameObject;

			goItem.name = itemName;
			goItem.AddComponent<ItemView> ();
			goItem.transform.position = new Vector3 (posX, posY,posZ);
			goItem.tag = itemTag;

			goItem.transform.parent = contextView.transform;         


			injectionBinder.Bind (itemName).To (itemModel);

		}
	}

}