#pragma strict

// Criar uma lista de Objetos do TIPO GameObject!
// Uma lista e' marcada pelos []
var listaProximos : GameObject[];

function ObterProximaPosicao () : Transform {     
    var indiceRandomicoDaListaObjetos : int = Random.Range(0,listaProximos.Length);			// lista aleatoria de waypoints
    var objetoObtido : GameObject = listaProximos[indiceRandomicoDaListaObjetos];			// inclui objeto na lista aleatoria
    var transformObjeto : Transform = objetoObtido.transform;								// objeto definido de forma aleatoria
    return transformObjeto;																	// retonar qual objeto sera o proximo waypoint
}


