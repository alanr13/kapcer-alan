using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var collisionObject = collision.gameObject.GetComponent<EnemyLogic>();
            collisionObject.DealDamage(gameObject.GetComponent<PlayerLogic>());
        }
    }
}
