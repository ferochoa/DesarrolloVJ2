using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using UnityEngine.UI;

public class TimerSBView : View
{
	
	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }


	public float speedBonusTime = 30f;
	public GameObject go;

	internal void init(){
		this.go = GameObject.Find ("TimerSB");
	}

	void Update()
	{

		speedBonusTime -= Time.deltaTime;

		if(speedBonusTime <=0){
			viewDispatcher.Dispatch (GameEvents.ON_SPEED_BONUS_ENDED);
			Destroy (go);
		}
	}


	
}

