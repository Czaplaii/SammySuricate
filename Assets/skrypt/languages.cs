using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class languages : MonoBehaviour
{
    public Text menu;
    public Text menu1;
    public Text menu2;
    public Text menu3;
    public Text menu4;
    public Text menu5;
    public Text menu6;
    public Text menu7;
    public Text powrot;
    public Text losetext;
    public Text wintext;
    private int speaker;
    public Text again;
    // Start is called before the first frame update  

    // Update is called once per frame
    void Update()
    {
        speaker = PlayerPrefs.GetInt("language");
        Debug.Log("jÍzyk : " + speaker);
        if (speaker == 1)
        {
            if (menu1 != null)
            {
                menu1.text = "URUCHOM";
            }
            if (menu2 != null)
            {
                menu2.text = "OPCJE";
            }
            if (menu3 != null)
            {
                menu3.text = "WYJDè Z GRY";
            }
            if (menu4 != null)
            {
                menu4.text = "POLSKI";
            }
            if (menu5 != null)
            {
                menu5.text = "ANGIELSKI";
            }
            if (menu6 != null)
            {
                menu6.text = "Wybierz jÍzyk:";
            }
            if (menu7 != null)
            {
                menu7.text = "RozdzielczoúÊ";
            }
            if (losetext != null)
            {
                losetext.text = "PRZEGRA£Eå";
            }
            if (wintext != null)
            {
                wintext.text = " WYGRA£Eå";
            }
            if (powrot != null)
            {
                powrot.text = "POWR”T";
            } if (again != null)
            {
                again.text = "SPR”BUJ PONOWNIE";
            }
            if (menu != null)
            {
                menu.text = "MENU G£”WNE";
            }
            PlayerPrefs.SetInt("language", 1);
        }
        else
        {
            if(menu1 != null) 
            {
                menu1.text = "START";
            }
            if (menu2 != null)
            {
                menu2.text = "OPTIONS";
            }
            if (menu3 != null)
            {
                menu3.text = "EXIT";
            }
            if (menu4 != null)
            {
                menu4.text = "POLISH";
            }
            if (menu5 != null)
            {
                menu5.text = "ENGLISH"; ;
            }
            if (menu6 != null)
            {
                menu6.text = "Choose language:";
            }
            if (menu7 != null)
            {
                menu7.text = "Resolution";
            }
            if (losetext != null)
                {
                    losetext.text = "YOU DIED";
                }
            if (wintext != null)
            {
            wintext.text = "CONGRATULATIONS";
            }
            if (powrot != null)
            {
            powrot.text = "BACK";
            }
            if (again != null)
            {
            again.text = "TRY AGAIN";
            }
            if (menu != null)
            {
                menu.text = "MAIN MENU";
            }
        }

    }
}
