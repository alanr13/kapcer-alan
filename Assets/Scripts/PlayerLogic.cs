using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D enemy;
    public int HP = 100;

    public GameControl gameControl;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Teleport character to the other side of the scene
        if (rb.transform.position.x >= 8.9)
        {
            rb.transform.position = new Vector2(-8.9f, transform.position.y);
        }
        else if (rb.transform.position.x <= -8.9)
        {
            rb.transform.position = new Vector2(8.9f, transform.position.y);
        }

        // Die if HP < 0
        if (HP <= 0)
        {
            gameControl.GameOver();
        }
    }
}
