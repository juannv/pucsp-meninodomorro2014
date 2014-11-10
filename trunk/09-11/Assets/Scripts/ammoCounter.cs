using UnityEngine;
using System.Collections;

public class ammoCounter : MonoBehaviour {
	public Weapon muni;
	
	// Use this for initialization
	void Awake ()
	{
		muni = GameObject.FindObjectOfType <Weapon> ();
	}
	
	void Update () {
		guiText.text = "" + muni.pistolAmmo;
	}
}