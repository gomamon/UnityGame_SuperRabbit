using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCnt : MonoBehaviour {
    public Text center;
    private string[] dieTxt = { "You can do better.", "You are stronger than you think you are.", "Don't give up!","Your skills are getting better.",
    "cheer up! you can do it again"};
    //GameObject.Find("Main Camera").GetComponent("Create").aaa()
    // Use this for initialization
    int n;

	void Start () {
        Invoke("DisText", 4.0f);
        n = Random.Range(0, dieTxt.Length);
	}
    void DisText(){
        center.enabled = false;
    }
    void IsDie(){
        //Debug.Log("DIE");
        center.text = dieTxt[n];
        center.enabled = true;

    }
}
