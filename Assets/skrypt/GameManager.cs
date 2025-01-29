using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public kolizja[] objectsToCollect;
    public int maxScore;
    public Text wintext;
    public Text losetext;
    public GameObject kula;
    void Start()
    {
        //wyœwietlanie
        kula = GameObject.Find("player");
        wintext.enabled = false;
        losetext.enabled = false;
        findcollectible();
        Zlicz();

        foreach (var item in objectsToCollect) 
        {
            item.pickupEvent += wyswietlcollectible;
        }
    }

    // Update is called once per frame
    void Update()
    {
        findcollectible();
        Zlicz();
        wyswietlcollectible();

        if (kula.transform.position.y < -30)
        {
            losetext.enabled = true;
            Invoke("Defeat", 3.0f);
        }

        if (maxScore == 0)
        {
            wintext.enabled = true;
            Invoke("swaplvl",5.0f);
        }
    }

    private void findcollectible()
    {
        // Metoda znajduj¹ca obiekty do zebrania
        //objectsToCollect = GameObject.FindGameObjectsWithTag("collectible");
        objectsToCollect = GameObject.FindObjectsOfType<kolizja>();
    }

    private void Zlicz()
    {
        // Metoda obliczaj¹ca maksymalny wynik
        maxScore = objectsToCollect.Length;
    }

    private void wyswietlcollectible()
    {
        // Wyœwietlenie maxscore
        Debug.Log("Max Score: " + maxScore);
    }

    //wygrana
    private void swaplvl()
    {
        if(maxScore == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    //przegrana
    public void Defeat()
    {
        PlayerPrefs.SetInt("last", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("lose screen");
    }

}
