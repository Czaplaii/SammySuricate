using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrorcrash : MonoBehaviour
{
    public AudioSource crash,commirror;
    public GameObject crackhead;
    public GameObject cracktail;
    // Start is called before the first frame update
    void Start()
    {
        crackhead.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            crash.Play();
            crackhead.SetActive(true);
            cracktail.SetActive(false);
            Invoke("comment", 2);
        }
    }

    private void comment()
    {
        commirror.Play();
    }
}
