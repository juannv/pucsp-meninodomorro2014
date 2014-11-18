using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	
	public float fireRate = 0;								// quando pode atirar
	public LayerMask whatToHit;								// layers que o raycast atingira
	public int pistolAmmo = 11;
	public float timerShooting = 0.3f;
	public int pontuacao = 000;
	private Animator animator;
	private HashIDs hash;	
	public bool isShooting = false;		
	float timeToFire = 0;									// delay entre disparos
	Transform firePoint;									// origem do raycast



/*NOVO*/		// Codigo para limpar o registro de uma pontuaçao
/*NOVO*/		// talvez seja interessante esse codigo estar quando começar um novo jogo
/*NOVO*/		void LimparPontuacao() {
/*NOVO*/			PlayerPrefs.DeleteKey ("ChaveSalvarPontos");
/*NOVO*/		}

	void Start() {
				pontuacao = PlayerPrefs.GetInt ("ChaveSalvarPontos", 0);
		}


	public void getWeapon()
	{
		pistolAmmo = 11;
		
	}

	void Awake () {
		firePoint = transform.FindChild ("FirePoint");		// encontrar a origem do raycast na hierarquia do objeto que possui este script
		animator = GetComponent<Animator> ();
		hash = gameObject.GetComponent<HashIDs> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (fireRate == 0) {								// se a taxa de tiro for igual a zero
			if (Input.GetButtonDown ("Fire1")) {			// e o botao de tiro for pressionado
				Shoot ();									// executar a funcao Shoot
			}
		} else {
			if (Input.GetButtonDown ("Fire1") && Time.time > timeToFire)		// caso contrario, onde o botao de tiro esteja pressionado e o tempo for maior que o tempo para disparo
			{
				timeToFire = Time.time + 1 / fireRate;							// aumentar o tempo para disparar
				Shoot();														// executar a funcao Shoot
				
			}
			if (pistolAmmo == 0)
			{
				
			}
		}
		
		if (isShooting == true) {
			timerShooting -= Time.deltaTime;
			if (timerShooting <= 0) {
				isShooting = false;
			}
			
		} else if (isShooting == false) 
		{
			timerShooting = 0.5f;
		}
		
	}
	void Shoot ()
	{
		if (isShooting == false && pistolAmmo > 0) {			// se o botao de tiro estiver pressionado e isShooting ele nao estiver atirando
			animator.SetTrigger (hash.shootTrigger);
			audio.Play();
			Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y);	// identifica posicao do mouse (destino)
			Vector2 firePointPosition = new Vector2 (firePoint.position.x, firePoint.position.y);																	// identifica a origem do disparo
			RaycastHit2D hit = Physics2D.Raycast (firePointPosition, mousePosition - firePointPosition, 100, whatToHit);											// cria raycast com as coordenadas acima
			pistolAmmo = pistolAmmo -1;	

			if (hit.collider.gameObject.tag == "Enemy")													// se o raycast atingir objeto com tag tiro
			{	
				EnemyScript enemyScript = hit.collider.gameObject.GetComponent<EnemyScript> ();
				enemyScript.MatarInimigo ();
				pontuacao = pontuacao + enemyScript.pontosDerrota;
			}
			Debug.Log ("muniçao da pistola = " + pistolAmmo);
			isShooting = true;				// e definir que o jogador estiver atirando
			
			
		}

	}
}