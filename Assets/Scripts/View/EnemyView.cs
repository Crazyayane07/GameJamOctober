using OGJ;
using UnityEngine;

public class EnemyView : CustomMonoBehaviour
{
    public float dropChance = 1.0f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<BulletView>().isPlayerBullet)
        {
            KillEnemy(collision);
        }
    }

    private void KillEnemy(Collision2D collision)
    {
        powerUpService.TrySpawnRandomPowerUp(this.transform, dropChance);

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
