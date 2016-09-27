using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class PlayerSpeedUp : EventCommand
{
    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }
    [Inject]
    public IPlayerModel myPlayer { get; set; }
    [Inject]
    public ICollectableModel collectable { get; set; }
    private float newSpeed;
    public override void Execute()
    {
       
        string viewName = (string)evt.data;
        ICollectableModel modeloAsociado = injectionBinder.GetBinding(viewName) as ICollectableModel;
        Debug.Log("ha colisionado con" +viewName);

       // collectable.setSpeedBonus();
       // dispatcher.Dispatch(GameEvents.ON_SPEED_BONUS_ADDED, collectable.speedBonus);
        


    }
}    