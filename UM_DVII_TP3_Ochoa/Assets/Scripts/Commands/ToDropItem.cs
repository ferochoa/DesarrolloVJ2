using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class ToDropItem : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contexView { get; set; }

	[Inject]
	public IPlayerModel myplayer { get; set; }


	public override void Execute()
	{
		string viewName = (string)evt.data;
		Debug.Log (viewName);
		IweaponHealhPackModel itemModel = injectionBinder.GetBinding (viewName).value as IweaponHealhPackModel;

		GameObject goItem = GameObject.Instantiate (Resources.Load (itemModel.name))as GameObject;
		goItem.name = itemModel.name;
		goItem.gameObject.AddComponent<ItemView> ();
		goItem.transform.localPosition = myplayer.position + new Vector3(0f,-0.5f,1f);
		goItem.transform.parent = contexView.transform;	



	}



}
