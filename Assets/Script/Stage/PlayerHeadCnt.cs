using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeadCnt : MonoBehaviour {

    public GameObject playerhead;
    private Vector3 dist;

    // Use this for initialization
    void Start()
    {
        dist = transform.position - playerhead.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerhead.transform.position + dist;
    }
}
