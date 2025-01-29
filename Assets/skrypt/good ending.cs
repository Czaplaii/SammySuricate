using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodending : MonoBehaviour
{
    public GameObject engje, truending;
    private int ending = 0;
    // Start is called before the first frame update
    void Start()
    {
        ending = PlayerPrefs.GetInt("Int");

        if (ending == 3)
        {
            engje.SetActive(false);
            truending.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
