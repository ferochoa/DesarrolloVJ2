﻿using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;

public class InputView : View
{

    [Inject]
    public IEventDispatcher viewDispatcher { get; set; }

	internal int item_n;

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.A))
		{
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_GO_LEFT);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_GO_RIGHT);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_GO_FOWARD);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_GO_BACKWARD);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            viewDispatcher.Dispatch(GameEvents.ON_PLAYER_JUMP);

        }
		if (Input.GetKeyDown(KeyCode.I))
		{

			viewDispatcher.Dispatch(GameEvents.ON_INVENTORY_MANIPULATION);

		}
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			item_n = 0;
			viewDispatcher.Dispatch(GameEvents.ON_SELECT_ITEM_BY_KEY , item_n);

		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			item_n = 1;
			viewDispatcher.Dispatch(GameEvents.ON_SELECT_ITEM_BY_KEY , item_n);

		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			item_n = 2;
			viewDispatcher.Dispatch(GameEvents.ON_SELECT_ITEM_BY_KEY , item_n);

		}
		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			item_n = 3;
			viewDispatcher.Dispatch(GameEvents.ON_SELECT_ITEM_BY_KEY , item_n);

		}
		if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			item_n = 4;
			viewDispatcher.Dispatch(GameEvents.ON_SELECT_ITEM_BY_KEY , item_n);

		}
		if (Input.GetKeyDown(KeyCode.Alpha6))
		{
			item_n = 5;
			viewDispatcher.Dispatch(GameEvents.ON_SELECT_ITEM_BY_KEY , item_n);

		}

    }
}
