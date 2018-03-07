using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCnt : MonoBehaviour {

    int discnt = 0;

    public Material yellow;

    private bool onpower;
    private Renderer player_color;
    private Renderer boss_color;
    // Use this for initialization
    void Start()
    {
        onpower = true;
        boss_color = this.GetComponent<Renderer>();
     //   player_color = GameObject.Find("superear").GetComponent<SuperEarCnt>().check;
    }

    // Update is called once per frame
    void Update()
    {
        if(onpower == true)
            BossMove();
    }
    void BossMove(){
        if (discnt < 50)    this.transform.position += Vector3.forward;
        else if (discnt < 99)   this.transform.position -= Vector3.forward;
        else if (discnt == 99)  discnt = 0;
        discnt++;
    }

    void OnCollisionEnter(Collision ball){
        if (ball.gameObject != null)
        {
            if (ball.gameObject.GetComponent<Renderer>().material.name.Equals(boss_color.material.name))
            {
                print(ball.gameObject.GetComponent<Renderer>().material.name);
                Destroy(ball.gameObject);
                boss_color.material = yellow;
                (GameObject.Find("potal").GetComponent<PotalAppear>().num)--;
                onpower = false;
            }
        }


    }


}
