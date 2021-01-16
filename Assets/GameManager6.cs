using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Back()
    {
        SceneManager.LoadScene("UK");
    }
    public void Conservatives()
    {
        SceneManager.LoadScene("Place Holder Scene");
    }
    public void Labour()
    {
        SceneManager.LoadScene("Place Holder Scene");
    }
}
