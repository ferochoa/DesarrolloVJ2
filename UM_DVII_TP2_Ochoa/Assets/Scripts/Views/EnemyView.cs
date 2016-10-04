using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class EnemyView : View {


	public void updateSpeed(float speed)
	{
		
		Debug.Log ("Enemy speed: " + speed);
	}
}
