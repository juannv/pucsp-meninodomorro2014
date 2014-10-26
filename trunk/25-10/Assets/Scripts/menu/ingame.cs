using UnityEngine;
using System.Collections;

public class ingame : MonoBehaviour {

	public int newsortingOrder = 1;
	public GameObject[] listaTelasEsconder;
	public GameObject telaMostrar;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) 
		{
			Time.timeScale=0.0f;
			foreach (GameObject s in listaTelasEsconder) {
				
				(s.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = -1;
				s.SetActive (false);
			}
			if (telaMostrar != null)
				(telaMostrar.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = newsortingOrder;
			telaMostrar.SetActive (true);
		}

	
	}
}
