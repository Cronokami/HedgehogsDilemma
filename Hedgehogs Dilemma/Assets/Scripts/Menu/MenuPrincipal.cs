using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
	public void StartGame()
	{
		SceneManager.LoadScene(1);

	}

	public void Credits()
	{


	}

	public void ExitGame()
	{
		Application.Quit();

	}
}
