using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class PlayerSpeedUp : EventCommand
{
    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }


    public override void Execute()
    {
        Debug.Log("el player colisiono con un coleccionable");
    }
}    