﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager5 : MonoBehaviour
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
        SceneManager.LoadScene("Country");
    }
    public void International()
    {
        SceneManager.LoadScene("Place Holder Scene");
    }
    public void Local()
    {
        SceneManager.LoadScene("UKLocal");
    }
}
