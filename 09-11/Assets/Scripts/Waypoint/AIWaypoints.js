#pragma strict

var wayPointCorrente : Transform = null;
// 
//var tempoDeslocamento: float = 5.0f;
var velocidade: float = 1f;				// velocidade de movimento
var jogador : GameObject;
var distanciaCalculada : float;
var anguloCalculado : float;
var distanciaMinima : float = 2.0f;
var anguloMinimo : float = 15.0f;
var moveParaJogador : boolean = false;
var enxergaJogador : boolean = false;
var layerMaskEnemy : LayerMask;
var animator : Animator;
var ignorarJogador : boolean = false;

function Start() {

    jogador = GameObject.FindGameObjectWithTag("Player");
    animator = gameObject.GetComponentInChildren(Animator);
}



function Update () {
	distanciaCalculada = Vector3.Distance(jogador.transform.position,transform.position);
	anguloCalculado = Vector3.Angle(jogador.transform.position,transform.position);
	
	
	if(ignorarJogador == false) {
		if (distanciaCalculada <= distanciaMinima)
		{
			if (enxergaJogador)
			{
				if (anguloCalculado <= anguloMinimo)
				{
				  moveParaJogador = true;
			    transform.position = Vector3.MoveTowards(transform.position,jogador.transform.position,velocidade * Time.deltaTime);
			    transform.LookAt(jogador.transform.position);
				} else {
				  moveParaJogador = false;
				}
		
			} else {
				moveParaJogador = false;
			}
		} else {
			moveParaJogador = false;
		}
		if (moveParaJogador && distanciaCalculada < 0.4f)
		{
		animator.Play("Inimigo1 - Bare Shoot");
		}
		if(wayPointCorrente != null && moveParaJogador == false) {			// se o waypoint atual nao for vazio
		
		   transform.position = Vector3.MoveTowards(transform.position,wayPointCorrente.position,velocidade * Time.deltaTime);		// mover em direcao ao proximo waypoint na velocidade definida
		   transform.LookAt(wayPointCorrente);										// olhar em direcao ao waypoint enquanto se move em direcao a ele  
		}
	} else {
		if(wayPointCorrente != null) {			// se o waypoint atual nao for vazio
		   transform.position = Vector3.MoveTowards(transform.position,wayPointCorrente.position,velocidade * Time.deltaTime);		// mover em direcao ao proximo waypoint na velocidade definida
		   transform.LookAt(wayPointCorrente);										// olhar em direcao ao waypoint enquanto se move em direcao a ele  
		}
	}
	
}

function FixedUpdate () {
    var informaCaoColisao : RaycastHit2D = Physics2D.Linecast(transform.position,jogador.transform.position,layerMaskEnemy);
    //Debug.Log(informaCaoColisao.collider.tag);
    if(informaCaoColisao.collider != null) {
	    if(informaCaoColisao.collider.tag.Equals("Player")) {
	    	enxergaJogador = true;
	    } else {
	    	enxergaJogador = false;
	    }
	}
}

 function OnCollisionEnter2D(colisorPlayer: Collision2D) {
   		if (colisorPlayer.gameObject.tag == "Player")
   		{
   		moveParaJogador =  false;
   		enxergaJogador = false;
   		}
}

function IgnorarPlayer() {
	ignorarJogador = true;
}

function OnTriggerEnter2D(objeto: Collider2D) {
   if(objeto.tag.Equals("Waypoint")) {								// se a tag do objeto colidido for waypoint
       var proximosWaypoints : ProximosWaypoints = objeto.GetComponent("ProximosWaypoints") as ProximosWaypoints;		// define possiveis waypoints
       var proximoWayPoint : Transform = proximosWaypoints.ObterProximaPosicao();							// alterar o proximo waypoint
       // Calculo de tempo
       //velocidade = Vector3.Distance(proximoWayPoint.position,gameObject.transform.position)/tempoDeslocamento;
	   wayPointCorrente = proximoWayPoint;						// waypoint atual volta para a lista de proximos waypoints
   }
}
