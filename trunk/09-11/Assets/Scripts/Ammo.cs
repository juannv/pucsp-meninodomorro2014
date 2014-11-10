using UnityEngine;
using System.Collections;

public class Ammo : MonoBehaviour {
	
	public GameObject pistola;
	public bool onTrigger = false;
	Collider2D outroColisor2;

	void Update ()
	{
		if (Input.GetButtonDown ("Interact") && onTrigger)
		{
			outroColisor2.gameObject.GetComponentInChildren<Weapon>().getWeapon();
			pistola.SetActive (false);
		}
		
	}
	
	void OnTriggerEnter2D (Collider2D outroColisor)
	{
		if (outroColisor.gameObject.tag == "Player")
		{
			onTrigger=true;
			outroColisor2 = outroColisor;
			
		}
		
	}
	
	void OnTriggerExit2D (Collider2D outroColisor)
	{
		if (outroColisor.gameObject.tag == "Player")
		{
			onTrigger=false;

		}
		
	}
	
}
