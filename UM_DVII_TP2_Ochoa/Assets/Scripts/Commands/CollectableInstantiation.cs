using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class CollectableInstantiation : EventCommand
{
    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    private const string COLLECTABLE = "Collectable";
   
   
    public override void Execute()
    {
        
        Debug.Log("Instanciacion de coleccionables");
        for (int i = 0; i < 3; i++)
        {
            ICollectableModel collectableModel = injectionBinder.GetInstance<ICollectableModel>();
           

            string collectableName = COLLECTABLE + (i + 1);
           

            GameObject goColl = GameObject.Instantiate(Resources.Load(PrefabNames.COLLECTABLE_PREFAB)) as GameObject;
            goColl.name = collectableName;
            
         
           

            if (i == 0)
            {
                collectableModel.type = 1;
                goColl.transform.position = new Vector3(4, 0.5f, 4);
               
            }
            if (i == 1)
            {
                collectableModel.type = 2;
                goColl.transform.position = new Vector3(-3.5f, 0.5f, 2);
            }
            if (i == 2)
            {
                collectableModel.type = 3;
                goColl.transform.position = new Vector3(3, 0.5f, -3.5f);
            }

                   
            

            goColl.transform.parent = contextView.transform;
          
            
          
           
           // Debug.Log(collectableName + " agregado a la escena");
           // Debug.Log(collectableName + " tipo: " + collectableModel.type);

            injectionBinder.Bind(collectableName).To<EnemyModel>();

        }
    }
}