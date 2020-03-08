using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MonsterMovement : MonoBehaviour
{

	public Camera cam;
	public NavMeshAgent agent;

	public Material start;
	public Material pause;

	private void Update()
	{

		start.color = new Vector4(start.color.r, start.color.g, start.color.b, Mathf.Lerp(start.color.a, 0, 0.2f));

		//pra pausar o tempo enquanto ele não se move
		if (agent.remainingDistance == 0)
		{
			Time.timeScale = Mathf.Lerp(Time.timeScale, 0, 0.5f);
			pause.color = new Vector4(pause.color.r, pause.color.g, pause.color.b, Mathf.Lerp(pause.color.a, 1, 0.5f));
		}


		//pra mandar ele pra onde clicar com o mouse
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				agent.SetDestination(hit.point);

				
				Time.timeScale = Mathf.Lerp(Time.timeScale, 1, 0.5f);
				pause.color = new Vector4(pause.color.r, pause.color.g, pause.color.b, 0);
				Debug.Log(agent.destination);
				Time.timeScale = 1;

				if (agent.remainingDistance == 0)
				{
					start.color = new Vector4(start.color.r, start.color.g, start.color.b, 1);
				}
			}
		}		
	}


	public void Derrota()
	{
		SceneManager.LoadScene("Derrota");

	}

	public void Vitoria()
	{
		SceneManager.LoadScene("Vitoria");

	}


	public void Stop()
	{
		agent.SetDestination(transform.position);
	}
}
