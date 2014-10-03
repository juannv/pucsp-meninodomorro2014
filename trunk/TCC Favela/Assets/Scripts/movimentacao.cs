using UnityEngine;
using System.Collections;

public class movimentacao : MonoBehaviour {
	public float velocidade = 3;

	void Start () {
	
	}
	
	void FixedUpdate () {
		rigidbody2D.velocity = new Vector2 (Input.GetAxis ("Horizontal") * velocidade, 
		                                    Input.GetAxis ("Vertical") * velocidade);

	}
}
