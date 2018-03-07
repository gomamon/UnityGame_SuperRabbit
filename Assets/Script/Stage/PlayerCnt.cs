using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCnt : MonoBehaviour {

    /*
     * controlling player move (speed, jumpforce)
     * can pass to next stage (using potal)
     * death event (using dyingmessage)
     */

    public float speed;
    public float jumpForce = 7;
    private bool onfloor = false;
    private Rigidbody rb;
  // public Collider potal;

    public bool isdie = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // Physics.gravity = new Vector3(0, -14.0F, 0);
    
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        if (Input.GetKeyDown("space") && onfloor == true)
        {
            Debug.Log("I'm in!");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onfloor = false;
        }

        //if you die
        if (this.transform.position.y < -5)
        {
            isdie = true;
            GameObject.Find("Canvas").SendMessage("IsDie");
        }

        //load present scene
        if (this.transform.position.y < -55)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    void OnTriggerEnter(Collider potal){

        if (potal.tag == "potal")
        {
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        onfloor = true;
    }

}
