using UnityEngine;
using System.Collections;

public class setActive: MonoBehaviour {
	
	public float timeLeft = 30.0f;					// tempo travado no cronometro
	public GameObject[] listaTelasEsconder;			// lista de telas que serao ocultas
	
	void Update()
	{
		timeLeft -= Time.deltaTime;					// contagem regressiva a partir do tempo do cronometro
		if(timeLeft < 0)							// se o tempo for menor que zero
		{
			foreach (GameObject s in listaTelasEsconder) {	// para cada objeto listado a ser escondido
				
				(s.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = -1;	// mandar os sprites para a posicao -1 da layer
				s.SetActive (false);														// e desativa os objetos
			}
		}
	}
}
