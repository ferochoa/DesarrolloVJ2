using UnityEngine;
using System.Collections;

public class CollectableModel : ICollectableModel
{
    public int type { get; set; }
    public float speedBonus { get; set; }
    public void setSpeedBonus()
    {
        speedBonus = 150;
    }
}

	