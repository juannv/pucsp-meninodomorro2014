using UnityEngine;
using System.Collections;

public class morte : MonoBehaviour {
	
	// public string nomeDaCena = "final";			// nome da cena
	
	public GameObject[] exibirGUI;
	
	void Update ()
	{
		
	}
	
	
	void OnCollisionEnter2D(Collision2D outroColisor)
	{
		if(outroColisor.gameObject.tag == "Enemy")			// se o colisor2D deste objeto colidir com um colisor com a tag Player
		{
			foreach (GameObject tela in exibirGUI) {
				tela.SetActive(true);
				Component objAI = GetComponent("movimentacao");
				Component objAI2 = GetComponentInChildren<rotate>();
				Component objAI3 = GetComponent<CircleCollider2D>();
				Destroy(objAI);
				Destroy(objAI2);
				Destroy(objAI3);
				// Application.LoadLevel(nomeDaCena);				// carregar a cena definida
			}
		}
	}
}