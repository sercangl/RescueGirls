using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

    public void play()
    {
        SceneManager.LoadScene(0);
    }
     public void level1()
    {
        SceneManager.LoadScene(1);
    }

    public void exit()
    {
        Application.Quit();
        //SceneManager.LoadScene(3);
    }

    public void yourdone()
    {
        SceneManager.LoadScene(0);
    }
    

    // Update is called once per frame
    void Update () {
		
	}
}
