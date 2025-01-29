using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizja : MonoBehaviour
{
    public AudioSource collect;
    public int s;
    public event Action pickupEvent;
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 8, 0) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            pickupEvent?.Invoke();
            collect.Play();
            collision.gameObject.GetComponent<movementcontroller>().CollectScore();
            s = collision.gameObject.GetComponent<movementcontroller>().score;
            collision.gameObject.GetComponent<movementcontroller>();
            gameObject.SetActive(false);
        }
    }

}
