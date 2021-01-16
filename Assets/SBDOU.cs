using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SBDOU : MonoBehaviour
{
    public GameObject Party;
    public int Health;
    public Vector3 Up;
    public Vector3 Down;
    public Vector3 Left;
    public Vector3 Right;
    public float move;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        Health = 150;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            Instantiate(Party, transform.position, transform.rotation);
            Instantiate(Party, transform.position, transform.rotation);
            timer = 0;
        }
        move += Time.deltaTime;
        if (move <= 3)
        {
            transform.position += Up;
        }
        if (move >= 3)
        {
            if (move <= 6)
            {
                transform.position += Right;
            }
        }
        if (move >= 6)
        {
            if (move <= 9)
            {
                transform.position += Down;
            }
        }
        if (move >= 9)
        {
            transform.position += Left;
            move = 0;
        }
        if (Health <= 0)
        {
            Instantiate(Party, transform.position, transform.rotation);
            Instantiate(Party, transform.position, transform.rotation);
            Instantiate(Party, transform.position, transform.rotation);
            Instantiate(Party, transform.position, transform.rotation);
            Destroy(gameObject);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RO")
        {
            Health -= 5;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "DO")
        {
            Health -= 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "PD")
        {
            Health -= 2;
        }
        if (collision.gameObject.tag == "RD")
        {
            Health -= 10;
        }
    }
}
