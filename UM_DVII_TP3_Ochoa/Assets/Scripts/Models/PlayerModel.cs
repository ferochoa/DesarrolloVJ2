using UnityEngine;
using System.Collections;

public class PlayerModel : IPlayerModel {


    public int points { get; set; }
    public Vector3 position { get; set; }
    public float speed { get; set; }
    public void setPoints()
    {
        points = 0;
       
    }
    public void setPlayerPosition(Vector3 pos)
    {
        this.position = pos;
    }
   public void setSpeed()
    {
        speed = 100;
    }
}
