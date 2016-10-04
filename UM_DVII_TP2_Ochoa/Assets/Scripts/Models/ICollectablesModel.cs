using UnityEngine;
using System.Collections;

public interface ICollectableModel
{
    int type { get; set; }
    float speedBonus { get; set; }
	float powerBonus{ get; set; }
	float speedPenalty{ get; set; }
    void setSpeedBonus();
	void setPowerBonus();
	void setSpeedPenalty();
}