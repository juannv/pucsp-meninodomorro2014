using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {
	
	
	public string nomeDaCena = "nome da cena";				// cena a ser carregada
	public Weapon pontosSalvos;
	
	void Start () {
		pontosSalvos = GameObject.FindObjectOfType<Weapon> ();
	}
	
	void OnCollisionEnter2D(Collision2D outroColisor)		// se outro colisor tocar este colisor
	{
		if (outroColisor.gameObject.tag == "Player") {
			PlayerPrefs.SetInt ("ChaveSalvarPontos", pontosSalvos.pontuacao);
			Application.LoadLevel (nomeDaCena);					// carregar a cena definida
		}
	}
}
