using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myRigidbody.transform.position.x >= 8.9)
        {
            myRigidbody.transform.position = new Vector2(-8.9f, transform.position.y);
        }
        else if (myRigidbody.transform.position.x <= -8.9)
        {
            myRigidbody.transform.position = new Vector2(8.9f, transform.position.y);
        }
    }
}
