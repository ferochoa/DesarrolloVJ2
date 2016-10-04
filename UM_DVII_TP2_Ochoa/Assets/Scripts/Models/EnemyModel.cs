using UnityEngine;
using System.Collections;

public class EnemyModel : IEnemyModel{

    public int health { get; set; }
	public float speed{ get; set; }

	public void setEnemySpeed()
	{

		speed = 100;
	}

   
}
