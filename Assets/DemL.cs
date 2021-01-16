using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemL : MonoBehaviour
{
    public int health;
    public Vector3 Left;
    public Vector3 Right;
    public float MoveTimer;
    public float ShootTimer;
    public GameObject DOL;
    public bool shoot;
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
        Death += Time.deltaTime;
        MoveTimer += Time.deltaTime;
        ShootTimer += Time.deltaTime;
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
            Instantiate(DOL, transform.position, transform.rotation);
            ShootTimer = 0;

        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if(ShootTimer <= 2) 
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
            health -= 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "PR")
        {
            health -= 10;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "DO")
        {
            if (shoot == false)
            {
                health -= 2;
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.tag == "RO")
        {
            health -= 5;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Trump")
        {
            health -= 10;
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "DUO")
        {
            health -= 2;
            Destroy(collision.gameObject);
        }

    }
}
