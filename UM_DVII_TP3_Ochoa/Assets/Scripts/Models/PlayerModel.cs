using UnityEngine;
using System.Collections;

public class PlayerModel : IPlayerModel {


    public int points { get; set; }
    public Vector3 position { get; set; }
    public float speed { get; set; }
	public float health { get; set; }
	public bool armed { get; set; }

    public void setPoints()
    {
        points = 0;
       
    }
   
   public void setSpeed()
    {
        speed = 100;
    }
	public void isArmed()
	{

		armed = false;

	}
}
