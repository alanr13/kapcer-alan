using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public Rigidbody2D enemy;
    Rigidbody2D player;
    bool isPlayerAlive = true;
    public float moveSpeed = 10;
    public int damage = 10;

    public void DealDamage()
    {
        var playerLogic = player.GetComponent<PlayerLogic>();
        playerLogic.HP -= damage;
    }

    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
        enemy.freezeRotation = true;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var move = moveSpeed * Time.deltaTime;
        if (isPlayerAlive)
        {
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, player.position, move);
        }

        if (enemy.transform.position.x >= 8.9)
        {
            enemy.transform.position = new Vector2(-8.9f, transform.position.y);
        }
        else if (enemy.transform.position.x <= -8.9)
        {
            enemy.transform.position = new Vector2(8.9f, transform.position.y);
        }
    }
}
