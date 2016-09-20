
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
		commandBinder.Bind (GameEvents.ON_PLAYER_ADDED_TO_SCENE).To<ObjectsInstantiation> ();
        commandBinder.Bind(GameEvents.ON_APLICATION_READY).To<InputInstantiation>();
        commandBinder.Bind(GameEvents.READY_TO_GO).To<HUDInstantiation>();

        mediationBinder.Bind<PlayerView>().To<PlayerViewMediator>();
        mediationBinder.Bind<InputView>().To<InputViewMediator>();
        mediationBinder.Bind<TimerView>().To<TimerViewMediator>();
        mediationBinder.Bind<HUDView>().To<HUDViewMediator>();



        injectionBinder.Bind<IPlayerModel>().To<PlayerModel>();
    }

}
