using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public GameObject follow;
    public GameObject player;
    Vector3 C;
    // Start is called before the first frame update
    void Start()
    {
       C = follow.transform.position-player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        follow.transform.position = C + player.transform.position;
    }
}
