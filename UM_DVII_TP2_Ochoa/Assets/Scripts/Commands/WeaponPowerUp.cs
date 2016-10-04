using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class WeaponPowerUp : EventCommand 
{
	private float powerIncreased; 



	[Inject]
	public IWeaponModel myWeapon{ get; set; }

	public override void Execute()
	{
		
		string viewName = (string)evt.data;
		ICollectableModel collectableModel = injectionBinder.GetBinding(viewName).value as ICollectableModel;
	
		myWeapon.setWeaponPower ();
		collectableModel.setPowerBonus ();
		powerIncreased = myWeapon.weaponPower + collectableModel.powerBonus;
	
		dispatcher.Dispatch(GameEvents.ON_POWER_BONUS_ADDED, powerIncreased);

	}
}
