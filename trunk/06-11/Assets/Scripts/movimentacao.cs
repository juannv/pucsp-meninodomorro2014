using UnityEngine;
using System.Collections;

public class movimentacao : MonoBehaviour {
	public float velocidade = 3;			// velocidade de movimento
	
	void FixedUpdate () {
		rigidbody2D.velocity = new Vector2 (Input.GetAxis ("Horizontal") * velocidade, Input.GetAxis ("Vertical") * velocidade);
															// move o rigidbody2D de acordo com a direcao e velocidade definidos

	}
}
