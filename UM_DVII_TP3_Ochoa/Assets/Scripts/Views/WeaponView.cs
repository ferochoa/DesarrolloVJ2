using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class WeaponView : View {



	public void updatePower(float power)
	{
		
		Debug.Log ("WeaponPower: " + power);
	}
}
