using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resolution : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void lowres()
    {
        Screen.SetResolution(1440, 900, true);
    }

    public void mediumres()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    public void highres()
    {
        Screen.SetResolution(3840, 2160, true);
    }
}
