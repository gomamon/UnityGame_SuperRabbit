using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RabbitMove_s2 : MonoBehaviour {
    
    public Transform bird;
    public GameObject letter;
    public GameObject earR;
    public GameObject earG;
    public GameObject earB;

    public GUIText script;


    private Transform pos;
    private SpriteRenderer letter_rend;
    private SpriteRenderer earR_rend;
    private SpriteRenderer earG_rend;
    private SpriteRenderer earB_rend;

    private int birdmove =0, changeflag = 1;
    private Vector3 destin;
    private float step;

	// Use this for initialization
	void Start () {

        letter_rend = letter.GetComponent<SpriteRenderer>();
        earR_rend = earR.GetComponent<SpriteRenderer>();
        earG_rend = earG.GetComponent<SpriteRenderer>();
        earB_rend = earB.GetComponent<SpriteRenderer>();

        pos = this.GetComponent<Transform>();
        step = 2 * Time.deltaTime;
	}

    // Update is called once per frame
    void Update()
    {

        //bird fly
        if (birdmove == 1)
        {
            if (changeflag == 1)
                destin = new Vector3(bird.position.x - 30, bird.position.y, 0);
            changeflag = 0;
            bird.position = Vector3.MoveTowards(bird.position, destin, step);
            if (bird.position.x == destin.x)
            {
                changeflag = 1;
                birdmove = 0;
            }
        }

        //appear letter & ears
        if (bird.position.x <= pos.position.x + 5f )
            DropLetter();
        
    }
    void StartStory2()
    {
        birdmove = 1;
    }

    void DropLetter(){
        letter_rend.enabled = true;
        earR_rend.enabled = true;
        earG_rend.enabled = true;
        earB_rend.enabled = true;
        script.text = "?!";

        Invoke("NextScene",5);
    }

    void NextScene(){
        SceneManager.LoadScene(2);
    }

}
