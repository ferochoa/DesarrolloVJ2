
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
		commandBinder.Bind (GameEvents.ON_APLICATION_READY).To<InputInstantiation> ();

        mediationBinder.Bind<PlayerView>().To<PlayerViewMediator>();
        mediationBinder.Bind<InputView>().To<InputViewMediator>();



        injectionBinder.Bind<IPlayerModel>().To<PlayerModel>();
    }

}
