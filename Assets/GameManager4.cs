using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GameManager4 : MonoBehaviour
{
    public GameObject DemocraticD;
    public GameObject DemocraticL;
    public GameObject RepublicanU;
    public GameObject RepublicanR;
    public float timerA;
    public float timerB;
    public float timerC;
    public float timerD;
    public float timerE;
    public float x1;
    public float x2;
    public float y1;
    public float y2;
    public GameObject Trump;
    public GameObject Biden;
    public GameObject Sanders;
    public float timerF;
    public float x3;
    public float y3;
    public float A;
    public float B;
    public float C;
    public float D;
    public float F;
    public float R;
    public TextMeshProUGUI TimerText;
    // Start is called before the first frame update
    void Start()
    {
        R = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        timerA += Time.deltaTime;
        timerB += Time.deltaTime;
        timerC += Time.deltaTime;
        timerD += Time.deltaTime;
        timerE += Time.deltaTime;
        timerF += Time.deltaTime;
        A = Random.Range(3,6);
        B = Random.Range(3,6);
        C = Random.Range(3, 6);
        D = Random.Range(3, 6);
        F = Random.Range(200, 300);
        x1 = Random.Range(-8,8);
        x2 = Random.Range(-8, 8);
        x3 = Random.Range(-8, 8);
        y1 = Random.Range(-4, 4);
        y2 = Random.Range(-4, 4);
        y3 = Random.Range(-4, 4);
        if(timerA >= A) 
        {
            Instantiate(DemocraticD, new Vector3(x1, y1, 0), Quaternion.identity);
            timerA = 0;
        }
        if(timerB >= B)
        {
            Instantiate(DemocraticL, new Vector3(x2, y2, 0), Quaternion.identity);
            timerB = 0;
        }
        if (timerC >= C)
        {
            Instantiate(RepublicanR, new Vector3(x2, y2, 0), Quaternion.identity);
            timerC = 0;
        }
        if (timerD >= D)
        {
            Instantiate(RepublicanU, new Vector3(x1, y1, 0), Quaternion.identity);
            timerD = 0;
        }
        if (timerF >= F)
        {
            if(R <= 2) 
            {
                Instantiate(Biden, new Vector3(x3, y3, 0), Quaternion.identity);
            }
            if(2 >= R) 
            { 
            if(R <= 3) 
            {
                    Instantiate(Trump, new Vector3(x3, y3, 0), Quaternion.identity);
                }
            }
            if(R >= 2) 
            {
                Instantiate(Sanders, new Vector3(x3, y3, 0), Quaternion.identity);
            }

            timerF = 0;
        }
        if(timerE >= 300) 
        {
            SceneManager.LoadScene("Country");
        }
        TimerText.text = "Time:" + timerE;
        if (Input.GetKeyDown(KeyCode.X)) 
        {
            SceneManager.LoadScene("USLocal");
        }
    }

}
