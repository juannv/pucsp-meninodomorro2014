#pragma strict

var wayPointCorrente : Transform = null;
// 
//var tempoDeslocamento: float = 5.0f;
var velocidade: float = 0.5f;				// velocidade de movimento

function Update () {
	if(wayPointCorrente != null) {			// se o waypoint atual nao for vazio
	
	   transform.position = Vector3.MoveTowards(transform.position,wayPointCorrente.position,Time.deltaTime*velocidade);		// mover em direcao ao proximo waypoint na velocidade definida
 	   //var direcao : Vector3 = wayPointCorrente.position - transform.position;
	   // transform.Rotate(Vector3.Angle(transform.right,wayPointCorrente.right)*transform.right);
	   transform.LookAt(wayPointCorrente);										// olhar em direcao ao waypoint enquanto se move em direcao a ele
 	   
	}
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