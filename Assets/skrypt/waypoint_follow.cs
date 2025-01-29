using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint_follow : MonoBehaviour
{
    public GameObject platform;
    [SerializeField] float speed=1.0f;
    public int ng;

    private void Start()
    {
        ng= PlayerPrefs.GetInt("Int");
    }
    void Update()
    {
        if (ng > 0)
        {
            Vector3 pozycja = platform.transform.position;
            pozycja.z -= speed * Time.deltaTime;
            platform.transform.position = pozycja;
        }
    }
}
