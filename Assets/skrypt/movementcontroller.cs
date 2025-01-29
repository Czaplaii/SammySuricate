using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class movementcontroller : MonoBehaviour
{
        public int score;
        public GameObject panel;
        private Rigidbody rb;
        private float movementSpeed = 6f;
        public static movementcontroller instance;
        private Vector3 movement;
        public Transform GroundCheck;
        public LayerMask Ground;
    //public event Action pickupEvent;
        //public GameObject kula;
        //Vector3 G;
        //public GameObject kula;
        // private int newscore;
        //G = new Vector3(0.5f, 0.5f, 0.5f); do poprawy skrypt do roœniêcia kuli


    void Start()
    {
        Time.timeScale = 1;
            //ruch
            rb = GetComponent<Rigidbody>();
            //punkty
            score = 0;
            instance = this;
            this.rb = this.GetComponent<Rigidbody>();
    }


        void Update()
        {
            this.movement = Vector3.zero;

            if (Input.GetKey(KeyCode.Space) && IsGrounded())
            {
                this.movement += Vector3.up * 30;
            }
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);


            //menu
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                panel.SetActive(true);
            }
     
        }

        void FixedUpdate()
        {
            this.rb.AddForce(movement * movementSpeed);
        }
    //PUNKTY
    public void CollectScore()
        {
        score += 1;
        Debug.Log(score);
        //pickupEvent();
        }

        //menu
        public void Renew()
        {
            panel.SetActive(false);
            Time.timeScale = 1;
        }

    bool IsGrounded()
    {
    return Physics.CheckSphere(GroundCheck.position, 0.6f, Ground);
    }

}