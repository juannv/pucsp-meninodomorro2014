using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public string nomeDaCena = "nome da cena";	//cena a ser carregada
	public float timeLeft = 60.0f;				// tempo para carregar a cena
	
	void Update()
	{
		timeLeft -= Time.deltaTime;				//reduzir o tempo
		if(timeLeft < 0)						// se o tempo restante for menor que zero
		{
			Application.LoadLevel (nomeDaCena);	// mudar a cena
		}
	}
}
