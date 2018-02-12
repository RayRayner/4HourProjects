using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    float realTime;
    public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
        pauseMenu.SetActive(false);
        realTime = Time.timeScale;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}

    public void Resume ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = realTime;
    }

    public void Pause ()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
