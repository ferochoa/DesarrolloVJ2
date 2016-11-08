using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class PlayerHealthUp : EventCommand {

	private float newHealth;
	private float playerHealth;
	private float maxHealth;

	[Inject]
	public IPlayerModel myPlayer{ get; set; }

	public override void Execute(){

		Debug.Log ("llegue aca");
		string viewName = (string)evt.data;
		IItemModel itemModel = injectionBinder.GetBinding (viewName).value as IItemModel;
		playerHealth = myPlayer.health;

		newHealth = playerHealth + itemModel.itemPower;
		//Debug.Log (itemModel.itemPower);
		if (newHealth > 300)
		{
			newHealth =150;
		}
		Debug.Log ("despacho aca");
		//dispatcher.Dispatch (GameEvents.ON_HEALTH_BONUS_ADDED, newHealth);
	
	}
}
