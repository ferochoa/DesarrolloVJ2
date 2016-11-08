using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class PlayerHealthUp : EventCommand {

	private float newHealth;
	private float playerHealth;
	private const float MAX_HEALTH = 200;

	[Inject]
	public IPlayerModel myPlayer{ get; set; }

	public override void Execute(){


		string viewName = (string)evt.data;
		IweaponHealhPackModel itemModel = injectionBinder.GetBinding (viewName).value as IweaponHealhPackModel;
		playerHealth = myPlayer.health;

		newHealth = playerHealth + itemModel.itemPower;

		if (newHealth > MAX_HEALTH)
		{
			newHealth = playerHealth;
		}


		dispatcher.Dispatch (GameEvents.ON_HEALTH_BONUS_ADDED, newHealth);
	
	}
}
