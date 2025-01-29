using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using System;

public class collector : MonoBehaviour
{
    int w;
    public GameObject[] scorestar;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePointDisplay();
    }

    public void UpdatePointDisplay()
    {
        w = movementcontroller.instance.score;
        Debug.Log("wyniki to" + w);
        if (w >= 1)
        {
             for (int i = 1; i <= w; i++)
            {
                scorestar[i - 1].SetActive(true);
            }
        }
    }
}
