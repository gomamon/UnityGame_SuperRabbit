using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour {
	private Vector3 destin;
	//public Button start;
	private bool clickon;
	private Vector3 pos;
	public Transform rabbitTrans;

	void Start()
	{
		clickon = false;
		destin = this.transform.position;
	}
	void Update(){
		if (clickon == true)	
			RabbitMove ();
		
		if (rabbitTrans.position == destin) 
			SceneManager.LoadScene (1);
	}

	void OnMouseDown(){
		clickon = true;
	}

	void RabbitMove()
	{
		rabbitTrans.position = Vector3.MoveTowards(rabbitTrans.position, destin, 5 * Time.deltaTime);
	}
}