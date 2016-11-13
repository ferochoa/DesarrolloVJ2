using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class InputViewMediator :EventMediator {

    [Inject]
    public InputView view { get; set; }

    override public void OnRegister()
    {
        view.viewDispatcher.AddListener(GameEvents.ON_PLAYER_GO_LEFT, onPlayerGoLeft);
        view.viewDispatcher.AddListener(GameEvents.ON_PLAYER_GO_RIGHT, onPlayerGoRight);
        view.viewDispatcher.AddListener(GameEvents.ON_PLAYER_GO_FOWARD, onPlayerGoFoward);
        view.viewDispatcher.AddListener(GameEvents.ON_PLAYER_GO_BACKWARD, onPlayerGoBackward);
        view.viewDispatcher.AddListener(GameEvents.ON_PLAYER_JUMP, onPlayerJump);
		view.viewDispatcher.AddListener (GameEvents.ON_INVENTORY_MANIPULATION, onInventoryManipulation);
		view.viewDispatcher.AddListener (GameEvents.ON_SELECT_ITEM_BY_KEY, onSelectItemByKey);

    }

    override public void OnRemove()
    {
        view.viewDispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_LEFT, onPlayerGoLeft);
		view.viewDispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_RIGHT, onPlayerGoRight);
		view.viewDispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_FOWARD, onPlayerGoFoward);
		view.viewDispatcher.RemoveListener(GameEvents.ON_PLAYER_GO_BACKWARD, onPlayerGoBackward);
		view.viewDispatcher.RemoveListener(GameEvents.ON_PLAYER_JUMP, onPlayerJump);
		view.viewDispatcher.RemoveListener(GameEvents.ON_INVENTORY_MANIPULATION, onInventoryManipulation);
		view.viewDispatcher.AddListener (GameEvents.ON_SELECT_ITEM_BY_KEY, onSelectItemByKey);
    }

    void onPlayerGoLeft()
    {
        dispatcher.Dispatch(GameEvents.ON_PLAYER_GO_LEFT);
    }
    void onPlayerGoRight()
    {
        dispatcher.Dispatch(GameEvents.ON_PLAYER_GO_RIGHT);
    }
    void onPlayerGoFoward()
    {
        dispatcher.Dispatch(GameEvents.ON_PLAYER_GO_FOWARD);
    }
    void onPlayerGoBackward()
    {
        dispatcher.Dispatch(GameEvents.ON_PLAYER_GO_BACKWARD);
    }
    void onPlayerJump()
    {
        dispatcher.Dispatch(GameEvents.ON_PLAYER_JUMP);
    }
	void onInventoryManipulation()
	{
		
		dispatcher.Dispatch (GameEvents.ON_INVENTORY_MANIPULATION);
	}
	void onSelectItemByKey()
	{
		dispatcher.Dispatch (GameEvents.ON_SELECT_ITEM_BY_KEY, view.item_n);
	}
}
