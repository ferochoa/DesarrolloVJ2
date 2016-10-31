using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class EnemyViewMediator : EventMediator
{

	[Inject]
	public EnemyView view { get; set; }

	override public void OnRegister()
	{
		dispatcher.AddListener (GameEvents.ON_ENEMY_SPEED_DECREASED, updateSpeed);
		dispatcher.AddListener (GameEvents.ON_ENEMY_SPEED_RESTARTED, updateSpeed);
	
	}
	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_ENEMY_SPEED_DECREASED, updateSpeed);
		dispatcher.RemoveListener (GameEvents.ON_ENEMY_SPEED_RESTARTED, updateSpeed);
	}

	void updateSpeed(IEvent evt)
	{
		float speed =(float)evt.data;       
		view.updateSpeed (speed);
	}
}
