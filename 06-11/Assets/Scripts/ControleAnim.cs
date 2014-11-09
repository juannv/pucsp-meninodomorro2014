using UnityEngine;
using System.Collections;

public class ControleAnim : MonoBehaviour {
	
	Animator animator = new Animator();				// inicia um animator
	
	void Start ()
	{
		// Obtenho o componente Animator anexado a este GameObject.
		animator = GetComponent<Animator> ();
	}
	
	
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			animator.Play ("Marcos - Pistol Shoot");
		} 
		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0.1) {			// e se ele estiver se movendo na horizontal
			animator.Play ("Marcos - Pistol Walk");						// tocar a animacao Marcos - Pistol Walk
		}
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1) {				// ou se ele estiver se movendo na verticar
			animator.Play ("Marcos - Pistol Walk");						// tocar a animacao Marcos - Pistol Walk
		}
	}
}