using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MenuManager : MonoBehaviour
{
	public CinemachineVirtualCamera[] cam;

    // Start is called before the first frame update
    void Start()
    {
		Time.timeScale = 0.5f;
		StartCoroutine("TrocaCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private IEnumerator TrocaCamera()
	{

		yield return new WaitForSeconds(3);
		for (int i = 0; i < cam.Length; i++)
		{
			
				cam[i].Priority = 0;
			
		}
		cam[Random.Range(0, cam.Length)].Priority = 10;

		StartCoroutine("TrocaCamera");
	}
}
