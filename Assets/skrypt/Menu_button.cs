using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_button : MonoBehaviour
{
    public GameObject button;
    public GameObject opcje;
    public AudioSource moooooooc;
    void Start()
    {
        if (button != null)
        {
            if (PlayerPrefs.GetInt("Int") > 0)
            {
                button.SetActive(true);
            }
            else
                button.SetActive(false);
        }
    }

    private void Update()
    {
    }

    public void StartGame()
    {
        SceneManager.LoadScene("look na kule");
    }
    // Start is called before the first frame update
    public void ShowOptions()
    {
        opcje.SetActive(true); 
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("last"));
    }

    public void FinishGame()
    {
        PlayerPrefs.SetInt("last", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("main menu rollball");
    }
    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }

    public void Revewopcje()
    {
        opcje.SetActive(false);
    }

    public void jezykP()
    {
        PlayerPrefs.SetInt("language", 1);
    }

    public void jezykA()
    {
        PlayerPrefs.SetInt("language", 2);
    }

    public void music()
    {
        moooooooc.Play();
    }
}
