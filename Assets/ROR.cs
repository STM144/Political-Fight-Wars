using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROR : MonoBehaviour
{
    public int health;
    public Vector3 Right;
    public Vector3 Left;
    public float MoveTimer;
    public float ShootTimer;
    public bool shoot;
    public GameObject LROR;
    public float Death;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        shoot = false;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTimer += Time.deltaTime;
        ShootTimer += Time.deltaTime;
        Death += Time.deltaTime;
        if (MoveTimer <= 3)
        {
            transform.position += Right;
        }
        if (MoveTimer >= 3)
        {
            transform.position -= Right;
        }
        if (MoveTimer >= 6)
        {
            MoveTimer = 0;
        }
        if (ShootTimer >= 2)
        {
            shoot = true;
            Instantiate(LROR, transform.position, transform.rotation);
            ShootTimer = 0;

        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (ShootTimer <= 2)
        {
            if (ShootTimer >= 0.05f)
            {
                shoot = false;
            }
        }
        if (Death >= 15)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PD")
        {
            health -= 10;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "PR")
        {
            health -= 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "DO")
        {
            health -= 5;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "RO")
        {
            if (shoot == false)
            {
                health -= 2;
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.tag == "Trump")
        {
            health -= 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "DUO")
        {
            health -= 10;
            Destroy(collision.gameObject);
        }
    }
}
