using UnityEngine;
using System.Collections;

public class EnemyCounter : MonoBehaviour {
	
	public GameObject[] enemies;
	int enemiesLeft;
	ArrayList inimigos;
	public GameObject[] listaMostrar;
	public bool cenarioFinal = false;
	private string nomeDaCena = "9-2 AnimFinal";				// cena a ser carregada
	
	void Start ()
	{
		inimigos = new ArrayList ();
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
		enemiesLeft = enemies.Length;
		foreach (GameObject obj in enemies) {
			inimigos.Add(obj.GetComponent<EnemyScript>());
		}
	}
		
	// Update is called once per frame
	void Update () {
		//Debug.Log (enemiesLeft);
				
		enemiesLeft = 0;
		foreach (EnemyScript s in inimigos)
						if (!s.mateInimigo)
								enemiesLeft++;


		if (enemiesLeft == 0 && cenarioFinal == false) {
						foreach (GameObject obj in listaMostrar) {	// para cada objeto listado a ser escondido
								obj.SetActive (true);
				
						}
				} else if (enemiesLeft == 0 && cenarioFinal == false)
						Application.LoadLevel (nomeDaCena);

	}
}

///////////////// IF CENARIO FINAL, MOSTRAR ANIMAÇAO FINAL /////////////////