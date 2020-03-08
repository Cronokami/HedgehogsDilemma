using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{

	public GameObject pauseButton;
	public GameObject pauseMenu;

	public GameObject monster;
    
	
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			MenuPause();
		}
    }

	public void MenuPause()
	{
		pauseButton.SetActive(false);
		pauseMenu.SetActive(true);
		monster.SendMessage("Stop");


	}
}
