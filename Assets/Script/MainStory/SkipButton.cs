using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SkipButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    void OnMouseDown()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
    }
}
