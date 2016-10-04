using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class EnemyInstantiation : EventCommand
{
    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    private const string ENEMY = "Enemy";
    

    public override void Execute()        
    {
        //ebug.Log("Instanciacion de enemigos");
        for(int i = 0; i<2; i++)
        {
            

            string enemyName = ENEMY + (i + 1);

            GameObject goEnemy = GameObject.Instantiate(Resources.Load(PrefabNames.ENEMY_PREFAB)) as GameObject;
            goEnemy.name = enemyName;
            IEnemyModel enemyModel = injectionBinder.GetInstance<IEnemyModel>();
            if (i == 0)
            {
                enemyModel.health = 200;
                goEnemy.transform.position = new Vector3(-3.5f,1,4);              

            }
            if (i == 1)
            {
                enemyModel.health = 180;
                goEnemy.transform.position = new Vector3(4,1,-2);


            }
            goEnemy.AddComponent<Rigidbody>();
            goEnemy.AddComponent<EnemyView>();
            goEnemy.transform.parent = contextView.transform;
            
         
           // Debug.Log(enemyName+" agregado a la escena");
           // Debug.Log(enemyName + " vida: " + enemyModel.health);

            injectionBinder.Bind(enemyName).To<EnemyModel>();

        }
    }
}
