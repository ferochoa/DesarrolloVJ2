using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class ItemView : View {


	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }



	private const string PLAYER = "Player";

	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.name == PLAYER)
		{
			viewDispatcher.Dispatch (GameEvents.ITEM_PICKED_UP,this.gameObject);


		}

	}
}
