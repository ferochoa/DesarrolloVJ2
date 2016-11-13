using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class PlayerInstantiation :EventCommand {

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    [Inject]
    public IPlayerModel myPlayer { get; set; }

    override public void Execute()
    {
       // Debug.Log("Instancia de mi player");

        GameObject go = GameObject.Instantiate(Resources.Load(PrefabNames.PLAYER_PREFAB)) as GameObject;

        go.name = "Player";
       
        go.AddComponent<PlayerView>();
		//go.AddComponent < WeaponView> ();

        PlayerView pv = go.GetComponent<PlayerView>();
        myPlayer.setSpeed();
		myPlayer.health = 100;
        pv.updateSpeed(myPlayer.speed);
		pv.updateHealth (myPlayer.health);
		myPlayer.isArmed ();
        go.transform.parent = contextView.transform;
		dispatcher.Dispatch(GameEvents.ON_PLAYER_ADDED_TO_SCENE);
       
        

    }

    }
