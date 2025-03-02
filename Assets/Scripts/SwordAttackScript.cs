using UnityEngine;

public class SwordAttackScript : MonoBehaviour
{
    Animator anim;
    private Collider2D attackCollider;
    public int damage = 50;
    public float bounceForce = 10f;
    void Start()
    {
        anim = GetComponent<Animator>();
        attackCollider = GetComponent<Collider2D>();
        attackCollider.enabled = false;
    }

    void Update()
    {
        if (anim != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetTrigger("Swing");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var enemy = collision.gameObject.GetComponent<EnemyLogic>();
            enemy.TakeDamage(gameObject.GetComponent<SwordAttackScript>());

            Rigidbody2D enemyRb = collision.GetComponent<Rigidbody2D>();
            if (enemyRb != null)
            {
                Vector2 direction = (collision.transform.position - transform.position).normalized;

                enemyRb.linearVelocity = Vector2.zero;
                enemyRb.AddForce(direction * bounceForce, ForceMode2D.Impulse);
            }
        }
    }

    public void EnableCollider()
    {
        Debug.Log("Sword Collision enabled");
        attackCollider.enabled = true;
    }

    public void DisableCollider()
    {
        Debug.Log("Sword collision disabled");
        attackCollider.enabled = false;
    }
}
