using UnityEngine;

public class SwordAttackScript : MonoBehaviour
{
    Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
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
}
