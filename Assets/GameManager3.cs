﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager3 : MonoBehaviour
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
        SceneManager.LoadScene("USA");
    }
    public void Democrat()
    {
        SceneManager.LoadScene("Democrat");
    }
    public void Reppublican()
    {
        SceneManager.LoadScene("Republican");
    }
}
