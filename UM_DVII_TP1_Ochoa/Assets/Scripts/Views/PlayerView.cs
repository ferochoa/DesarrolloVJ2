using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class PlayerView : View {

    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }


    void Update () {



    }

    public void playerMovement()
    {
        Debug.Log("El player se ha movido");
    }
}
