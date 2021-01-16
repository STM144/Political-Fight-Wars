using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PlayerD : MonoBehaviour
{
    public GameObject Logo;
    public int Health;
    public Vector3 Up;
    public Vector3 Down;
    public Vector3 Left;
    public Vector3 Right;
    public TextMeshProUGUI HealthText;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(Logo, transform.position, transform.rotation);

        }
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.position += Up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Right;
        }

        if(Health <= 0) 
        {
            Destroy(gameObject);
            SceneManager.LoadScene("USlocal");
        }
        HealthText.text = "Health:" + Health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RO")
        {
            Health -= 10;
            Destroy(collision.gameObject);
        }
       
        if (collision.gameObject.tag == "DO")
        {
            Health -= 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Trump")
        {
            Health -= 20;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "DUO")
        {
            Health -= 5;
            Destroy(collision.gameObject);
        }
    }
}
