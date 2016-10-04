using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class TimerDESViewMediator : EventMediator
{

	[Inject]
	public TimerDESView view { get; set; }

	override public void OnRegister()
	{
		view.viewDispatcher.AddListener (GameEvents.ON_SPEED_PENALTY_ENDED, onSpeedPenaltyEnded);

	}
	override public void OnRemove()
	{
		view.viewDispatcher.RemoveListener (GameEvents.ON_SPEED_PENALTY_ENDED, onSpeedPenaltyEnded);

	} 

	void onSpeedPenaltyEnded()
	{
		dispatcher.Dispatch (GameEvents.ON_SPEED_PENALTY_ENDED);
	}


}