using UnityEngine;
using System.Collections;

public class matheusAnim : MonoBehaviour {
	
	public float timeLeft = 3.0f;				// tempo para o objeto desaparecer
	public GameObject[] listaEsconder;			// lista a esconder
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;				//reduzir o tempo
		if (timeLeft < 0)						// se o tempo restante for menor que zero
		{	
			foreach (GameObject s in listaEsconder) {		// para cada gameobject na lista a esconder
				
				(s.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = -1;		// mandar o sprite para a ordem -1 da layer
				s.SetActive (false);							// tornar objeto inativo
			}
		}
	}
}