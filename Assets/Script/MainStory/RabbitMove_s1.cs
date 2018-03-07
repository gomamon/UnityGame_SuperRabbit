using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMove_s1 : MonoBehaviour {
	
    public GUIText script;
	public GameObject badrabbit;

	private Vector3 destin;
    private float step;
	private int rot = 1;
	
    private int cnt;
    private int text3flag = 1, text2flag = 1;
    private int moveflag;
    private int changeflag;
    private int scriptflag = 0;


	void Start () {
		moveflag = 0;
		changeflag = 1;
        step = 5 * Time.deltaTime;
	}

    void Update()
    {
        //rabbit move to down stair
        if (moveflag == 0) RabbitMoveRight();
        else if (moveflag == 1) RabbitMoveDown();
        else if (moveflag == 2) RabbitMoveRight();
        else if (moveflag == 3) RabbitMoveDown();
        else if (moveflag == 4) RabbitMoveRight();
        //bad rabbit move
        else if (moveflag == 5)
        {
            BadRabbitMove1();
            BadRabbitRot();
            if (destin == badrabbit.transform.position)
            {
                changeflag = 1;
                moveflag++;
            }
        }
        else if (moveflag == 6)
        {
            BadRabbitRot();
            Invoke("BadRabbitMove2", 3.5f);
            scriptflag = 1;
        }

        if (scriptflag == 1)
        {
            
            StartCoroutine("Script");
            scriptflag = 0;
        }

    }




    //function for script
	IEnumerator Script(){
		yield return new WaitForSeconds(0.3f);
		TextAppear1 ();
		yield return new WaitForSeconds (1.2f);
        TextAppear2();
        yield return new WaitForSeconds(1.2f);
        TextAppear3();
		yield return new WaitForSeconds (2.5f);
        script.color = new Color(1f, 1f, 1f, 1f);
        script.fontSize = 300;
        script.text = ". . .";
        yield return new WaitForSeconds(3.0f);
        this.gameObject.SendMessage("StartStory2");

	}
    void TextAppear1()
    {
        script.enabled = true;
    }
    void TextAppear2()
    {
        if (text2flag == 1)
            script.text = "You Are So Weird!";
        text2flag = 0;
    }
    void TextAppear3()
    {
        if (text3flag == 1)
            script.text = "hahaha";
        text3flag = 0;
    }
    void TextAppear4()
    {
        script.color = new Color(1f, 1f, 1f, 1f);
        script.text = "...";
    }


    //funtion for bad rabbit
	void BadRabbitMove1(){
		if (changeflag == 1) {
			destin = new Vector3 (badrabbit.transform.position.x - 12, badrabbit.transform.position.y, 0);
			changeflag = 0;
		}
		badrabbit.transform.position = Vector3.MoveTowards(badrabbit.transform.position, destin, step);
	}	
	void BadRabbitMove2(){
		if (changeflag == 1) {
			destin = new Vector3 (badrabbit.transform.position.x + 5, badrabbit.transform.position.y, 0);
			changeflag = 0;

		}
		badrabbit.transform.position = Vector3.MoveTowards(badrabbit.transform.position, destin, step);

		if (10 < badrabbit.transform.position.x) {
			changeflag = 1;
			moveflag++;
		}
	}
	void BadRabbitRot(){
		if (cnt==0) {
			rot *= -1;
			cnt = 9;
		}
		cnt--;
			//badrabbit.transform.Rotate (Vector3.forward * 30 * rot );
		badrabbit.transform.Rotate (Vector3.forward * 30 * rot * Time.deltaTime , Space.World);
	}


    //function for hero move
	void RabbitMoveDown(){
		if (changeflag == 1) {
			destin  = new Vector3(this.transform.position.x, (float)(this.transform.position.y - 1.8), 0);
			changeflag=0;
		}

		RabbitMove();

		if (this.transform.position.x == destin.x && this.transform.position.y == destin.y) {
			moveflag++;
			changeflag = 1;
			destin = new Vector3 (0, 0, 0);
		}
	}

	void RabbitMoveRight(){
		if (changeflag == 1) {
			destin = new Vector3 (this.transform.position.x + 3, this.transform.position.y, 0);
			changeflag=0;
		}

		RabbitMove();

		if (this.transform.position.x == destin.x && this.transform.position.y == destin.y) {
			moveflag++;
			changeflag = 1;
			destin = new Vector3 (0, 0, 0);
		}
	}

	void RabbitMove(){
		transform.position = Vector3.MoveTowards(this.transform.position, destin, step);
	}

}
