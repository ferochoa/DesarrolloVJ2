using UnityEngine;
using System.Collections;

public interface IPlayerModel {

    int points { get; set; }
    Vector3 position { get; set; }
    float speed { get; set;}
	float health { get; set; }

    void setPoints();
    void setPlayerPosition(Vector3 pos);
    void setSpeed ();
   
}
