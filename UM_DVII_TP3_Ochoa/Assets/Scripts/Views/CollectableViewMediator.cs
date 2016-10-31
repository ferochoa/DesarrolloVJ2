using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class CollectableViewMediator : EventMediator
{

	[Inject]
	public CollectableView view { get; set; }

	override public void OnRegister()
	{
		view.viewDispatcher.AddListener(GameEvents.ON_PLAYER_COLLISION, onPlayerCollision);
	}

	override public void OnRemove()
	{
		view.viewDispatcher.RemoveListener(GameEvents.ON_PLAYER_COLLISION, onPlayerCollision);
	}

	void onPlayerCollision()
	{
		dispatcher.Dispatch (GameEvents.ON_PLAYER_COLLISION, view.gameObject.name);
	}
}