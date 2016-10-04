using UnityEngine;
using System.Collections;

public class WeaponModel : IWeaponModel {

	public float weaponPower { get; set;}

	public void setWeaponPower(){
	
		weaponPower = 200;
	}
}
