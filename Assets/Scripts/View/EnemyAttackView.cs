using OGJ.Controller;
using UnityEngine;

namespace OGJ.View
{
    public class EnemyAttackView : CustomMonoBehaviour
    { 
        private EnemyAttackController enemyAttackController;

        private void Awake()
        {
            enemyAttackController = new EnemyAttackController();
        }

        /*private void OnCollisionEnter2D(Collision2D collision)
        {
            PlayerView player = collision.gameObject.GetComponent<PlayerView>();

            if (player)
            {
                enemyAttackController.KillPlayer(player);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("AAAA");
        }*/        
    }
}
