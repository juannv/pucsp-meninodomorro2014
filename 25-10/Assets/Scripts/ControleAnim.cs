using UnityEngine;
using System.Collections;

public class ControleAnim : MonoBehaviour {

	Animator animator = new Animator();
	//public Sprite idleSprite = null;
	void Start () {
		// Obtenho o componente Animator anexado a este GameObject.
		animator = GetComponent<Animator>();
	}
	

	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			animator.Play("Marcos - Pistol Shoot");
		}
		if (Mathf.Abs (Input.GetAxis("Horizontal")) > 0.1)
		    {
			animator.Play ("Marcos - Pistol Walk");
			}
		if (Mathf.Abs (Input.GetAxis("Vertical")) > 0.1)
		{
			animator.Play ("Marcos - Pistol Walk");
		}
			}
//		else {
//			animator.speed = 0;
//			//(GetComponent<SpriteRenderer>() as SpriteRenderer).sprite = idleSprite;
//			animator.Play ("Marcos - Pistol Idle");
//		}
	}

