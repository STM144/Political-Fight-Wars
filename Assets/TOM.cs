﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TOM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interactive()
    {
        SceneManager.LoadScene("Place Holder Scene");
    }
    public void ReadTuotial()
    {
        SceneManager.LoadScene("Tutorial 1");
    }
}
