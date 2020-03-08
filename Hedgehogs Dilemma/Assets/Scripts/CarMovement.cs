using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarMovement : MonoBehaviour
{
	public Transform[] targetPoints;

	[HideInInspector]
	public NavMeshAgent agent;


	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		agent.SetDestination(targetPoints[Random.Range(0, targetPoints.Length - 1)].position);
	}

	private void Update()
	{
		if (Vector3.Distance(agent.destination, transform.position) <= 5)
		{
			agent.SetDestination(targetPoints[Random.Range(0, targetPoints.Length - 1)].position);
		}
	}

	private void OnTriggerEnter(Collider collision)
	{


		if (collision.CompareTag("Monstro"))
		{


		}

		else if (collision.CompareTag("Car"))
		{
			agent.SetDestination(targetPoints[Random.Range(0, targetPoints.Length - 1)].position);

		}
	}
}
