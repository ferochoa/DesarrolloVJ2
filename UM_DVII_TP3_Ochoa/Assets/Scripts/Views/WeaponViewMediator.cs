using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class WeaponViewMediator : EventMediator {

	[Inject]
	public WeaponView view{ get; set;}

	override public void OnRegister()
	{

		dispatcher.AddListener (GameEvents.ON_POWER_BONUS_ADDED, updatePower);

	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_POWER_BONUS_ADDED, updatePower);
	}

	void updatePower(IEvent evt)
	{

		float power =(float)evt.data;       
		view.updatePower (power);
	}
}
