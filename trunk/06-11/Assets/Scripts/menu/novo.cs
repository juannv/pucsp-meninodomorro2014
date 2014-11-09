using UnityEngine;
using System.Collections;

public class novo : MonoBehaviour {
	public bool novoJ = true;				// novoJ verdadeiro
	public string nomeDaCena = "cenario0";	// nome da cena a ser carregada
	// Use this for initialization
	void OnMouseDown()
	{
		if (novoJ)						// se novoJ for verdadeiro
		{
			Application.LoadLevel (nomeDaCena);		// carregar a cena definida
		}
	}
}
