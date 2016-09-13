using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class PlayerView : View {


    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }


    void Update () {

        viewDispatcher.Dispatch(GameEvents.PLAYER_SHOOT);

    }
}
