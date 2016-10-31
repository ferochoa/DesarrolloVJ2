using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;



public class CollectableInstantiation : EventCommand
{
    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

   
	
   
   
    public override void Execute()
    {
        TextAsset file = Resources.Load("Collectables") as TextAsset;

        var n = SimpleJSON.JSON.Parse(file.text);

     

		for (int i = 0; i < n.Count; i++)
        {
            ICollectableModel collectableModel = injectionBinder.GetInstance<ICollectableModel>();
            string collectableName = n [i]["name"].Value;  
			float posX = n [i] ["posX"].AsFloat;
			float posY = n [i] ["posY"].AsFloat;
			float posZ = n [i] ["posZ"].AsFloat;
			collectableModel.collEvent = n [i] ["event"];

            GameObject goColl = GameObject.Instantiate(Resources.Load(PrefabNames.COLLECTABLE_PREFAB)) as GameObject;

            goColl.name = collectableName;
			goColl.AddComponent<CollectableView> ();
			goColl.transform.position = new Vector3 (posX, posY,posZ);
			goColl.tag = "Collectable";
			         
            goColl.transform.parent = contextView.transform;         
               

			injectionBinder.Bind (collectableName).To (collectableModel);

        }
    }
}