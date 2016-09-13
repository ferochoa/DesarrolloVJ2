
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
        
        commandBinder.Bind(ContextEvent.START).To<ObjectsInstantiation>();
        commandBinder.Bind(GameEvents.ON_APLICATION_READY).To<PlayerInstantiation>();

        mediationBinder.Bind<PlayerView>().To<PlayerViewMediator>();


      
        injectionBinder.Bind<IPlayerModel>().To<PlayerModel>();
    }

}
