using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class WeaponPowerUp : EventCommand 
{
	private float powerIncreased; 
	private const float ITEMPOWER = 200;


	[Inject]
	public IItemModel myWeapon{ get; set; }

	public override void Execute()
	{
		
		string viewName = (string)evt.data;
		ICollectableModel collectableModel = injectionBinder.GetBinding(viewName).value as ICollectableModel;
	
		myWeapon.itemPower = ITEMPOWER;
		collectableModel.setPowerBonus ();
		powerIncreased = myWeapon.itemPower + collectableModel.powerBonus;
	
		dispatcher.Dispatch(GameEvents.ON_POWER_BONUS_ADDED, powerIncreased);

	}
}
