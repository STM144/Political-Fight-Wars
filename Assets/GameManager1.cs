﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager1 : MonoBehaviour
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
        SceneManager.LoadScene("Title");
    }
    public void USA()
    {
        SceneManager.LoadScene("USA");
    }
    public void UK()
    {
        SceneManager.LoadScene("UK");
    }
}
