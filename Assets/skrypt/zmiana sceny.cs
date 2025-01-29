using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zmianasceny : MonoBehaviour
{
    int engie;
    public void LoadLevel2()
    {
        PlayerPrefs.SetInt("Int", 0);
        SceneManager.LoadScene("look na kule"); // "Level2" to nazwa sceny "Level 2" w projekcie Unity
    }

    public void LoadNG()
    {
        PlayerPrefs.SetInt("Int", PlayerPrefs.GetInt("Int") + 1);
        SceneManager.LoadScene("look na kule"); // "Level2" to nazwa sceny "Level 2" w projekcie Unity
        Debug.Log(PlayerPrefs.GetInt("Int")) ;
    }
}
