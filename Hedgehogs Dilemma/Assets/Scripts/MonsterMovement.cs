using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterMovement : MonoBehaviour
{

	public Camera cam;
	public NavMeshAgent agent;

	private void Update()
	{
		//pra mandar ele pra onde clicar com o mouse
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				agent.SetDestination(hit.point);
				Debug.Log(agent.destination);
				Time.timeScale = 1;
			}
		}


		//pra pausar o tempo enquanto ele não se move
		if (agent.remainingDistance == 0)
		{
			Time.timeScale = Mathf.Lerp(Time.timeScale, 0, 0.5f);
		}
		else
		{
			Time.timeScale = Mathf.Lerp(Time.timeScale, 1, 0.5f);
		}
		
	}
}
