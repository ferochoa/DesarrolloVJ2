using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class EquipWeapon : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	[Inject]
	public IPlayerModel myPlayer { get; set; }



	public override void Execute()
	{

		string viewName = (string)evt.data;
		IweaponHealhPackModel itemModel = injectionBinder.GetBinding (viewName).value as IweaponHealhPackModel;

		if (myPlayer.armed == false ) {


			GameObject goItem = GameObject.Instantiate(Resources.Load(itemModel.name)) as GameObject;
			goItem.name = itemModel.name;
			goItem.AddComponent<WeaponView>();
			WeaponView wv = goItem.GetComponent<WeaponView> ();
			wv.updatePower (itemModel.itemPower);
			goItem.transform.SetParent(contextView.GetComponentInChildren<PlayerView>().transform);
			goItem.transform.localPosition = Vector3.right;
			myPlayer.armed = true;

		}

		else{

			GameObject player = GameObject.Find ("Player");	

			dispatcher.Dispatch (GameEvents.TO_DESTROY_ITEM, player.transform.GetChild (0).name);
			dispatcher.Dispatch (GameEvents.READY_TO_INSTANTIATE_ITEM,player.transform.GetChild (0).name);

			myPlayer.armed = false;

			dispatcher.Dispatch (GameEvents.ON_EQUIP_WEAPON, itemModel.name);
	}
}
}