using UnityEngine;
using System.Collections;

public class EnemyCounter : MonoBehaviour {
	
	public GameObject[] enemies;
	int enemiesLeft;
	ArrayList inimigos;
	public GameObject[] listaMostrar;
	
	void Start ()
	{
		inimigos = new ArrayList ();
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
		enemiesLeft = enemies.Length;
		foreach (GameObject s in enemies) {
			inimigos.Add(s.GetComponent<EnemyScript>())	;
		}
	}
		
	// Update is called once per frame
	void Update () {
		enemiesLeft = 0;
		foreach (EnemyScript s in inimigos)
			if (!s.mateInimigo)
				enemiesLeft++;		
		
		if (enemiesLeft == 0)
		{
			foreach (GameObject obj in listaMostrar) {	// para cada objeto listado a ser escondido
				obj.SetActive (true);
				
			}
		}
	}
}