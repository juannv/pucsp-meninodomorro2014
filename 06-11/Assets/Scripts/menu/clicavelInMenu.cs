using UnityEngine;
using System.Collections;

public class clicavelInMenu : MonoBehaviour {

	public int newsortingOrder = 1;					// nova posicao na layer
	public GameObject[] listaTelasEsconder;			// lista de telas a esconder
	public GameObject telaMostrar;					// tela que deve ser mostrada
		
	// Update is called once per frame
	void OnMouseDown ()
	{
	
			Time.timeScale=1;						// velocidade do tempo
			foreach (GameObject s in listaTelasEsconder) {		// para cada gameobject na lista a esconder
				
				(s.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = -1;		// mandar o sprite para a ordem -1 da layer
				s.SetActive (false);							// tornar objeto inativo
			}
			if (telaMostrar != null)							// se a lista a mostrar nao estiver vazia
				(telaMostrar.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = newsortingOrder;		// mandar o objeto a mostrar para a nova ordem
			telaMostrar.SetActive (true);						// tornar este objeto ativo
		
	}
}
