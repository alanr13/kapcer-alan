using UnityEngine;

public class SwordAttackScript : MonoBehaviour
{
    Animator anim;
    private Collider2D attackCollider;
    public int damage = 50;

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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var enemy = collision.gameObject.GetComponent<EnemyLogic>();
            enemy.TakeDamage(gameObject.GetComponent<SwordAttackScript>());
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
