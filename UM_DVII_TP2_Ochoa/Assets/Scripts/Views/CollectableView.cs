using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;


public class CollectableView : View {
	
	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }

		private const string PLAYER = "Player";


	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.name == PLAYER)
		{
			viewDispatcher.Dispatch (GameEvents.ON_PLAYER_COLLISION, this.gameObject.name);
			Destroy (this.gameObject);
		}
			
		}
}
