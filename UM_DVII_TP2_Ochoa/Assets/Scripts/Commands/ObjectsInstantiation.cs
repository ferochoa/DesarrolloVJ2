using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class ObjectsInstantiation : EventCommand
{
    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

   
    override public void Execute()
    {
        Debug.Log("Instancia de objetos staticos");
      
        GameObject go = GameObject.Instantiate(Resources.Load(PrefabNames.OBJECT1_PREFAB)) as GameObject;    
       
        go.name = "Object1";
       
        go.transform.parent = contextView.transform;

        GameObject go2 = GameObject.Instantiate(Resources.Load(PrefabNames.OBJECT2_PREFAB)) as GameObject;

        go2.name = "Object2";

        go2.transform.parent = contextView.transform;

        GameObject go3 = GameObject.Instantiate(Resources.Load(PrefabNames.GROUND_PREFAB)) as GameObject;

        go3.name = "Ground";

        go3.transform.parent = contextView.transform;

       

		dispatcher.Dispatch (GameEvents.ON_APLICATION_READY);

    }
}