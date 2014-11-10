using UnityEngine;
using System.Collections;

public class clicavelInMenu : MonoBehaviour {
	
	public int newsortingOrder = 1;					// nova posicao na layer
	public GameObject[] listaTelasEsconder;			// lista de telas a esconder
	public GameObject mostrarPlayer;
	public float tempoAtivar = 0.5f;
	
	
	// Update is called once per frame
	void OnMouseDown ()
	{
		Time.timeScale=1;						// velocidade do tempo
		mostrarPlayer.SetActive (true);

		foreach (GameObject s in listaTelasEsconder) {		// para cada gameobject na lista a esconder
			
			(s.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = -1;		// mandar o sprite para a ordem -1 da layer
			s.SetActive (false);							// tornar objeto inativo
		}
	}
}
