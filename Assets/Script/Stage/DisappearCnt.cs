using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearCnt : MonoBehaviour {

    /*
     * enemy disappear
     */
    void OnTriggerEnter(Collider other)
    {   
        //Debug.Log(other.gameObject);
        if (other != null && other.gameObject != null)
          Destroy(other.gameObject);
    }

}
