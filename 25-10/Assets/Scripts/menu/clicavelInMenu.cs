using UnityEngine;
using System.Collections;

public class clicavelInMenu : MonoBehaviour {

	public int newsortingOrder = 1;
	public GameObject[] listaTelasEsconder;
	public GameObject telaMostrar;
		
	// Update is called once per frame
	void OnMouseDown ()
	{
	
			Time.timeScale=1;
			foreach (GameObject s in listaTelasEsconder) {
				
				(s.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = -1;
				s.SetActive (false);
			}
			if (telaMostrar != null)
				(telaMostrar.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = newsortingOrder;
			telaMostrar.SetActive (true);
		
	}
}
