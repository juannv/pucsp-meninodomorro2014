using UnityEngine;
using System.Collections;

public class novo : MonoBehaviour {
	public bool novoJ = true;
	public string nomeDaCena = "cenario3";
	// Use this for initialization
	void OnMouseDown()
	{
		if (novoJ)
		{
			Application.LoadLevel (nomeDaCena);
		}
	}
}
