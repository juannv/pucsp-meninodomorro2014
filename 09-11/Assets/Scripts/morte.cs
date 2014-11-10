using UnityEngine;
using System.Collections;

public class morte : MonoBehaviour {
	
	private Animator animator;
	
	public GameObject[] exibirGUI;
	
	void Awake ()
	{
		
		animator = gameObject.GetComponentInChildren<Animator> ();
	}
	
	
	void OnCollisionEnter2D(Collision2D outroColisor)
	{
		if(outroColisor.gameObject.tag == "Enemy")			// se o colisor2D deste objeto colidir com um colisor com a tag Player
		{
			Component objAI = GetComponent("movimentacao");
			Component objAI2 = GetComponentInChildren<rotate>();
			Component objAI3 = GetComponent<CircleCollider2D>();
			Component objAI4 = GetComponentInChildren<Weapon>();
			Component objAI5 = GetComponentInChildren<ControleAnim>();
			Destroy(objAI);
			Destroy(objAI2);
			Destroy(objAI3);
			Destroy(objAI4);
			Destroy(objAI5);
			animator.Play ("Dead");
			outroColisor.gameObject.GetComponent("AIWaypoints").SendMessage("IgnorarPlayer");
			
			foreach (GameObject tela in exibirGUI) {
				tela.SetActive(true);
			}
		}
	}
}