using UnityEngine;
using System.Collections;

public interface IEnemyModel {

    int health { get; set; }  
	float speed{ get; set; }

	void setEnemySpeed();

}
