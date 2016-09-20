using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class HUDInstantiation : EventCommand
{
    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    [Inject]
    public IPlayerModel myPlayer { get; set; }


    override public void Execute()
    {
        GameObject go = GameObject.Instantiate(Resources.Load(PrefabNames.HUD_PREFAB)) as GameObject;

        go.name = "HUD";
        go.AddComponent<HUDView>();
        go.AddComponent<TimerView>();

             
        dispatcher.Dispatch(GameEvents.ON_SET_POINTS, myPlayer.points);
        go.transform.parent = contextView.transform;
    }
}
