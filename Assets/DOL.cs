using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOL : MonoBehaviour
{
    public float move;
    public Vector3 up;
    public Vector3 right;
    public Vector3 down;
    public Vector3 left;
    public float death;
    // Start is called before the first frame update
    void Start()
    {
        move = Random.Range(2.1f, -1);
    }

    // Update is called once per frame
    void Update()
    {
        if (move >= 1.1)
        {
            transform.position += up;
        }
        if (move <= 1.1)
        {
            if (move >= 0.9)
            {
                transform.position += left;
            }
        }
        if (move <= 0.9)
        {
            if (move >= -0.1)
            {
                transform.position += down;
            }
        }
        if (move <= -.1)
        {
            transform.position += right;
        }
        if (death >= 4)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "PR")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "RO")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Trump")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }

    }
}
