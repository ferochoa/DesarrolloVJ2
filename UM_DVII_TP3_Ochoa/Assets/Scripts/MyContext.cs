
using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;



public class MyContext : MVCSContext {


    public MyContext(MonoBehaviour view) : base(view)
	{
        //Debug.Log("constructor MiContexto");
    }
    override protected void mapBindings()
    {
        
        commandBinder.Bind(ContextEvent.START).To<PlayerInstantiation>();
		commandBinder.Bind (GameEvents.ON_PLAYER_ADDED_TO_SCENE).To<ObjectsInstantiation> ().To<EnemyInstantiation> ().To<CollectableInstantiation> ().
		To<InventoryInstantiation> ().To<SlotInstantiation> ().To<ItemInstantiation>();
        commandBinder.Bind(GameEvents.ON_APLICATION_READY).To<InputInstantiation>();
        commandBinder.Bind(GameEvents.READY_TO_GO).To<HUDInstantiation>();
		commandBinder.Bind (GameEvents.ON_PLAYER_COLLISION).To<SetEventCollectable>();
        commandBinder.Bind(GameEvents.TO_ADD_SPEED_BONUS).To<PlayerSpeedUp>();
		commandBinder.Bind(GameEvents.ON_SPEED_BONUS_ADDED).To<TimerSBInstantiation>();
		commandBinder.Bind(GameEvents.ON_SPEED_BONUS_ENDED).To<RestartSpeed>();
		commandBinder.Bind(GameEvents.TO_ADD_POWER_BONUS).To<WeaponPowerUp>();
		commandBinder.Bind(GameEvents.TO_DECREASE_ENEMY_SPEED).To<DecreaseEnemySpeed>();
		commandBinder.Bind(GameEvents.ON_SPEED_PENALTY_ENDED).To<RestartEnemySpeed>();
		commandBinder.Bind(GameEvents.ON_ENEMY_SPEED_DECREASED).To<TimerDESInstantiation>();
		commandBinder.Bind (GameEvents.ITEM_PICKED_UP).To<ItemToAdd> ();
		commandBinder.Bind (GameEvents.PAINT_SLOT_ITEM_INVENTORY).To<SlotManipulation> ();
		commandBinder.Bind (GameEvents.ON_SELECT_ITEM_BY_KEY).To<ItemSelection> ();
		commandBinder.Bind (GameEvents.USE_ITEM).To<UsingItems> ();
		commandBinder.Bind (GameEvents.ON_USE_HEALTH_PACK).To<PlayerHealthUp> ();

        mediationBinder.Bind<PlayerView>().To<PlayerViewMediator>();
        mediationBinder.Bind<InputView>().To<InputViewMediator>();
        mediationBinder.Bind<TimerView>().To<TimerViewMediator>();
        mediationBinder.Bind<HUDView>().To<HUDViewMediator>();
		mediationBinder.Bind<EnemyView> ().To<EnemyViewMediator> ();
		mediationBinder.Bind<TimerSBView>().To<TimerSBViewMediator>();
		mediationBinder.Bind<TimerDESView>().To<TimerDESViewMediator>();
		mediationBinder.Bind<WeaponView>().To<WeaponViewMediator>();
		mediationBinder.Bind<CollectableView>().To<CollectableViewMediator>();
		mediationBinder.Bind<InventoryView>().To<InventoryViewMediator>();
		mediationBinder.Bind<ItemView>().To<ItemViewMediator>();
		mediationBinder.Bind<PanelButtonView>().To<PanelButtonViewMediator>();
        



		injectionBinder.Bind<IPlayerModel>().To<PlayerModel>().ToSingleton();
        injectionBinder.Bind<IEnemyModel>().To<EnemyModel>();
		injectionBinder.Bind<ICollectableModel> ().To<CollectableModel> ();
		injectionBinder.Bind<IItemModel> ().To<ItemModel> ().ToSingleton ();
		injectionBinder.Bind<IInventoryModel> ().To<InventoryModel> ().ToSingleton();
		injectionBinder.Bind<IweaponHealhPackModel> ().To<WeaponHealthPackModel> ();

       
    }

}
