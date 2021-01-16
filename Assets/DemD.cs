using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemD : MonoBehaviour
{
    public int health;
    public Vector3 Up;
    public Vector3 Down;
    public float MoveTimer;
    public float ShootTimer;
    public GameObject DOD;
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
        if(MoveTimer <= 3) 
        {
            transform.position += Up;
        }
        if(MoveTimer >= 3) 
        {
            transform.position -= Up;
        }
        if(MoveTimer >= 6) 
        {
            MoveTimer = 0;
        }
        if(ShootTimer >= 2) 
        {
            shoot = true;
            Instantiate(DOD, transform.position, transform.rotation);
            ShootTimer = 0;
        }
        if(health <= 0) 
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
        if(Death >= 15) 
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "PD") 
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
            if(shoot == false) 
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
