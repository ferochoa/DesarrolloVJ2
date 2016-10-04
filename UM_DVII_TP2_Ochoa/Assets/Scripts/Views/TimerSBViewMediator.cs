using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class TimerSBViewMediator : EventMediator
{

	[Inject]
	public TimerSBView view { get; set; }

	override public void OnRegister()
	{
		view.init ();
		view.viewDispatcher.AddListener (GameEvents.ON_SPEED_BONUS_ENDED, onSpeedBonusEnded);

	}
	override public void OnRemove()
	{
		view.viewDispatcher.RemoveListener (GameEvents.ON_SPEED_BONUS_ENDED, onSpeedBonusEnded);

	} 

	void onSpeedBonusEnded()
	{
		dispatcher.Dispatch (GameEvents.ON_SPEED_BONUS_ENDED);
	}


}