using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		

		if (collision.gameObject.CompareTag("Monstro"))
		{


		}

		else if (collision.gameObject.CompareTag("Car"))
		{
			//por enquanto nada acontece feijoada, eles nem se batem na layer, se quiser que se batam, troca as propriedades da layer deles

		}
	}
}
