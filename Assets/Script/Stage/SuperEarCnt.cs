using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SuperEarCnt : MonoBehaviour
{

    private Material earmat;


    public Material fire;
    public Material water;
    public Material grass;
    public Rigidbody player_rig;


    private int red_num;
    private int blue_num;
    private int green_num;


    private float playermass;
    public Renderer check;
    private Rigidbody rig;
   // private Rigidbody red_rig;
   // private Rigidbody green_rig;
    private GameObject[] blue={};
    private GameObject[] red = { };
    private GameObject[] green = { };
    bool init=true;

    // Use this for initialization
    void Start()
    {
        check = this.GetComponent<Renderer>();
        check.material = water;
        playermass = player_rig.mass;
        red = GameObject.FindGameObjectsWithTag("redEnemy");
        green = GameObject.FindGameObjectsWithTag("greenEnemy");
        blue = GameObject.FindGameObjectsWithTag("blueEnemy");


    }



    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown("a"))
        {
            check.material = fire;

            foreach (GameObject a in red)
            {
                if (a != null)
                {
                    rig = a.GetComponent<Rigidbody>();
                    rig.mass = playermass;
                }
            }
            foreach (GameObject a in green)
            {
                if (a != null)
                {
                    rig = a.GetComponent<Rigidbody>();
                    rig.mass = playermass * (1 / 10);
                }
            }
            foreach (GameObject a in blue)
            {
                if (a != null)
                {
                    rig = a.GetComponent<Rigidbody>();
                    rig.mass = playermass * 10;
                }
            }


        }
        if (Input.GetKeyDown("s")||init==true)
        {
            init = false;
            check.material = water;

            foreach (GameObject a in red)
            {
                if (a != null)
                {
                    rig = a.GetComponent<Rigidbody>();
                    rig.mass = playermass * (1 / 10);
                }
            }
            foreach (GameObject a in green)
            {
                if (a != null)
                {
                    rig = a.GetComponent<Rigidbody>();
                    rig.mass = playermass * 10;
                }
            }
            foreach (GameObject a in blue)
            {
                if (a != null)
                {
                    rig = a.GetComponent<Rigidbody>();
                    rig.mass = playermass;
                }
            }
        }
        if (Input.GetKeyDown("d"))
        {
            check.material = grass;

            foreach (GameObject a in red)
            {
                if (a != null)
                {
                    rig = a.GetComponent<Rigidbody>();
                    rig.mass = playermass * 10;
                }
            }
            foreach (GameObject a in green)
            {
                if (a != null)
                {
                    rig = a.GetComponent<Rigidbody>();
                    rig.mass = playermass;
                }
            }
            foreach (GameObject a in blue)
            {
                if (a != null)
                {
                    rig = a.GetComponent<Rigidbody>();
                    rig.mass = playermass * (1 / 10);
                }
            }
        }
    }

}
