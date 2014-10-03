using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{
		public int newsortingOrder = 1;
		public GameObject[] listaTelasEsconder;
		public GameObject telaMostrar;
//		public bool sair = false;
//		public bool novo = false;
//		public string nomeDaCena = "cenario3";
		

		void OnMouseDown ()
		{
				foreach (GameObject s in listaTelasEsconder) {
  			    
						(s.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = -1;
						s.SetActive (false);
				}
				if (telaMostrar != null)
						(telaMostrar.GetComponent<SpriteRenderer> () as SpriteRenderer).sortingOrder = newsortingOrder;
				telaMostrar.SetActive (true);


		/*if (novo = true) {
						Application.LoadLevel (nomeDaCena);
				}
		else  if (sair = true && telaMostrar == null) {
			Application.Quit ();
		}*/
		
	}
}