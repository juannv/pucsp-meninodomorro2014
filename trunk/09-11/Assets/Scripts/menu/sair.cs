using UnityEngine;
using System.Collections;

public class sair : MonoBehaviour
{
	public string nomedacena = "1 Menu";	// nome da cena a ser carregada
		public bool fechar = true;		// fechar como verdadeiro
		// Use this for initialization
		void OnMouseDown ()
		{
				if (fechar) {			// se fechar for verdadeiro
						Application.LoadLevel (nomedacena);		// carregar a cena menu
				} else  	// senao
						Application.Quit ();		// sair do jogo
		}
}
