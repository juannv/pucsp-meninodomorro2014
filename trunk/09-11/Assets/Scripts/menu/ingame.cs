using UnityEngine;
using System.Collections;

public class ingame : MonoBehaviour {
	
	public int newsortingOrder = 1;					// nova posicao na layer
	public GameObject[] listaTelasEsconder;			// lista de telas a esconder
	public GameObject telaMostrar;					// tela que deve ser mostrada
	public GameObject mostrarPlayer;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {					// se a tecla ESC for pressionada
			//foreach (rotate in gameObject.
			Time.timeScale = 0.0f;								// velocidade do tempo
			mostrarPlayer.SetActive (false);
			foreach (GameObject s in listaTelasEsconder) {		// para cada gameobject na lista a esconder
				
				(s.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = -1;		// mandar o sprite para a ordem -1 da layer
				s.SetActive (false);							// tornar objeto inativo
			}
			if (telaMostrar != null)							// se a lista a mostrar nao estiver vazia
				(telaMostrar.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = newsortingOrder;		// mandar o objeto a mostrar para a nova ordem
			telaMostrar.SetActive (true);						// tornar este objeto ativo
		}
	}
}

