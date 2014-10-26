using UnityEngine;
using System.Collections;

public class morte : MonoBehaviour {

	public string nomeDaCena = "final";

	void OnCollisionEnter2D(Collision2D outroColisor)
	{
		if(outroColisor.gameObject.tag == "Player")
		{
			Application.LoadLevel(nomeDaCena);
		}
	}
}