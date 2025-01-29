using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easterbunny : MonoBehaviour
{
    public AudioSource bunny;
    public GameObject tepacja;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            if (bunny != null)
            {
                bunny.Play();
            }
            Invoke("tp", 5.0f);
        }
    }

    private void tp()
    {
        tepacja.transform.position = new Vector3(-8.54f, 0.5f, -9.11f);
    }
}
