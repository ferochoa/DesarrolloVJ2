﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IItemModel  {

	List<GameObject> items { get; set; }
	float itemPower { get; set; }
	string name { get; set;}


}
