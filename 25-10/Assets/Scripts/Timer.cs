using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public string nomeDaCena = "cenario3";
	float timeLeft = 60.0f;
	
	void Update()
	{
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			Application.LoadLevel (nomeDaCena);
		}
	}
}
