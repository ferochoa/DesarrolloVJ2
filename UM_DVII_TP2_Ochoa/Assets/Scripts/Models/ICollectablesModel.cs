﻿using UnityEngine;
using System.Collections;

public interface ICollectableModel
{
    int type { get; set; }
    float speedBonus { get; set; }
    void setSpeedBonus();
}