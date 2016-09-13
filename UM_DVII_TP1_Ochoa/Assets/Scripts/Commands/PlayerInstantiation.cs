using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class PlayerInstantiation :EventCommand {

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    [Inject]
    public IPlayerModel playerModel { get; set; }

    override public void Execute()
    {
        Debug.Log("Instancia de mi player");

        GameObject go = GameObject.Instantiate(Resources.Load(PrefabNames.PLAYER_PREFAB)) as GameObject;

        go.name = "Player";
        go.AddComponent<PlayerView>();

        PlayerView pv = go.GetComponent<PlayerView>();
       

        go.transform.parent = contextView.transform;

    }

    }
