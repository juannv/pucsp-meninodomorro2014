using UnityEngine;
using System.Collections;

public class showScore : MonoBehaviour {
	
	public Weapon score;
	
	void Awake ()
	{
		score = GameObject.FindObjectOfType <Weapon> ();
	}
	// Update is called once per frame
	void Update () {

			
		if (score.pontuacao != "000")
			guiText.text = "Pontuação: " + score.pontuacao;
		
	}
}
