using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {
	

	public string nomeDaCena = "nome da cena";				// cena a ser carregada
	//public bool cenarioLimpo =  false;

	void OnCollisionEnter2D(Collision2D outroColisor)		// se outro colisor tocar este colisor
	{
		Application.LoadLevel(nomeDaCena);					// carregar a cena definida
	}
}
