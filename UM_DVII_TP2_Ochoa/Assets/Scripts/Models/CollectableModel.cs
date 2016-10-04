using UnityEngine;
using System.Collections;

public class CollectableModel : ICollectableModel
{
    public int type { get; set; }
    public float speedBonus { get; set; }
	public float powerBonus{ get; set; }
	public float speedPenalty{ get; set; }

    public void setSpeedBonus()
    {
        speedBonus = 50;
    }

	public void setPowerBonus()
	{
		powerBonus = 100;
	}
	public void setSpeedPenalty()
	{
		speedPenalty = 25;
	}
}

	