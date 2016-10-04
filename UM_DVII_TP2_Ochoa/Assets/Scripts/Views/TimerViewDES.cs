using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class TimerDESView :View {

	[Inject]
	public IEventDispatcher viewDispatcher { get; set; }


	public float speedPenaltyTime = 15f;
	public GameObject go;

	internal void init(){
		this.go = GameObject.Find ("TimerDES");
	}

	void Update()
	{

		speedPenaltyTime -= Time.deltaTime;

		if(speedPenaltyTime <=0){
			viewDispatcher.Dispatch (GameEvents.ON_SPEED_PENALTY_ENDED);
			Destroy (go);
		}
	}

}
