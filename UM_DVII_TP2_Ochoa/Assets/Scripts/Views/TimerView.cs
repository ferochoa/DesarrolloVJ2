using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using UnityEngine.UI;

public class TimerView : View
{

    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }


    public float maxTime = 10f;
    private Text timerText;




    void Update()
    {

        maxTime -= Time.deltaTime;
        //string seconds = maxTime.ToString("f0");
        //timerText.text =  seconds;
        //Debug.Log (seconds);
        if (maxTime <= 0.0f)
        {
            viewDispatcher.Dispatch(GameEvents.GAME_OVER);
            Time.timeScale = 0;
        }

    }
}