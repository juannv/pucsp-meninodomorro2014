using UnityEngine;
using System.Collections;

public class ControleAnim : MonoBehaviour {
	
	private Animator animator;
	private HashIDs hash;
	private Weapon ammo1;

	
	void Awake ()
	{

		animator = GetComponent<Animator> ();
		hash = gameObject.GetComponent<HashIDs> ();
		ammo1 = gameObject.GetComponent<Weapon> ();	
	}
	
	void FixedUpdate ()
	{
		bool shoot = Input.GetButtonDown ("Fire1");

		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0.1 || Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1f)
			animator.SetBool (hash.walkBool, true);
		else if (Mathf.Abs (Input.GetAxis ("Horizontal")) < 0.1 || Mathf.Abs (Input.GetAxis ("Vertical")) < 0.1f)
			animator.SetBool (hash.walkBool, false);
		if (shoot && ammo1.pistolAmmo > 0)
			animator.SetTrigger (hash.shootTrigger);
	}
	



	//	void Update ()
	//	{
	//		if (Input.GetButtonDown ("Fire1")) {
	//			animator.Play ("Marcos - Pistol Shoot");
	//		} 
	//		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0.1) {			// e se ele estiver se movendo na horizontal
	//			animator.Play ("Marcos - Pistol Walk");						// tocar a animacao Marcos - Pistol Walk
	//		}
	//		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1) {				// ou se ele estiver se movendo na verticar
	//			animator.Play ("Marcos - Pistol Walk");						// tocar a animacao Marcos - Pistol Walk
	//		}
	//	}
	
	
}