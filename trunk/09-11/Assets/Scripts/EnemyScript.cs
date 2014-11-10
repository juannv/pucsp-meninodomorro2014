using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	public Animator animator = new Animator();		// inicia um animator
	//public int hp = 1;						// hp = 1
	public bool mateInimigo = false;
	
	// Update is called once per frame
	public void MatarInimigo()
	{
		mateInimigo = true;

	}
	public void Update() {
		if (mateInimigo) {
			animator.Play ("Inimigo1 - Dead");	// tocar a animacao Inimigo1 - Dead
			Component objAI = GetComponent("AIWaypoints");
			Component objAI2 = GetComponent<CircleCollider2D>();
			Destroy(objAI);
			Destroy(objAI2);
			Destroy(GetComponent<EnemyScript>());
		}
	}
}
