#pragma strict

var wayPointCorrente : Transform = null;
var velocidade: float = 5.0f;

function Update () {
	if(wayPointCorrente != null) {
	
	   transform.position = Vector3.Lerp(transform.position,wayPointCorrente.position,Time.deltaTime*velocidade);
	   
	}
}

function OnTriggerEnter2D(objeto: Collider2D) {
   if(objeto.tag.Equals("Waypoint")) {
       var proximosWaypoints : ProximosWaypoints = objeto.GetComponent("ProximosWaypoints") as ProximosWaypoints;
       wayPointCorrente = proximosWaypoints.ObterProximaPosicao();
   }
}