using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engieplansza : MonoBehaviour
{
    public GameObject[] ngplus;
    public GameObject[] notsngplus;
    public GameObject ngplansza;
    public GameObject notngplansza;
    private int newgame;
    // Start is called before the first frame update
    void Start()
    {
        newgame = PlayerPrefs.GetInt("Int");
        //newgame = 0;
        //newgame = 1;
        //newgame = 2;
        //newgame = 3;
        if (newgame == 0)
        {
            Debug.Log("stan ng+ " + newgame);
            ngplansza.SetActive(false);
            notngplansza.SetActive(true);
        }
        
        if(newgame > 0 && newgame <4) 
        {
            
            Debug.Log("stan ng+ " + newgame);
            for (int i = 0; i < newgame; i++)
            {
                Debug.Log(i);
                ngplus[i].SetActive(true);
            }
            notsngplus[newgame].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
