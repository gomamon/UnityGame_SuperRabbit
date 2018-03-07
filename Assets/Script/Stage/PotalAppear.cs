using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotalAppear : MonoBehaviour {

    public int num;

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
        if (num == 0)
        {
            this.gameObject.GetComponent<SphereCollider>().enabled = true;
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        
	}
}
