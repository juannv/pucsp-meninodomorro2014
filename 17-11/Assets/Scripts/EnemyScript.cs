using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	public Animator animator = new Animator();		// inicia um animator
	//public int hp = 1;						// hp = 1
	public bool mateInimigo = false;
	public bool e2Pistol;
	public bool e1Hands;
	public int pontosDerrota = 100;
	
	// Update is called once per frame
	public void MatarInimigo()
	{
		mateInimigo = true;
		
	}
	public void Update() {


		if (e2Pistol)
		{
			if (mateInimigo) {
				animator.Play ("Inimigo2 - Dead");	// tocar a animacao Inimigo2 - Dead
				Component objAI = GetComponent("AIWaypoints");
				Component objAI2 = GetComponent<CircleCollider2D>();
				Destroy(objAI);
				Destroy(objAI2);
				Destroy(GetComponent<EnemyScript>());
			}
			
		}
		if (e1Hands)
		{
			if (mateInimigo) {
				animator.Play ("Inimigo1 - Dying");	// tocar a animacao Inimigo1 - Dead
				Component objAI = GetComponent ("AIWaypoints");
				Component objAI2 = GetComponent<CircleCollider2D> ();
				Destroy (objAI);
				Destroy (objAI2);
				Destroy (GetComponent<EnemyScript> ());
			}
		}
		
	}
}
