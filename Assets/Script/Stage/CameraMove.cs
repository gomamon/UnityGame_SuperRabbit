using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public GameObject player;
	private Vector3 dist;

	void Start()
	{
		
		dist = transform.position - player.transform.position;
	}

	void LateUpdate()
	{
		transform.position = player.transform.position + dist;
	}
}
