#pragma strict

// Criar uma lista de Objetos do TIPO GameObject!
// Uma lista e' marcada pelos []
var listaProximos : GameObject[];

function ObterProximaPosicao () : Transform {     
    var indiceRandomicoDaListaObjetos : int = Random.Range(0,listaProximos.Length);
    var objetoObtido : GameObject = listaProximos[indiceRandomicoDaListaObjetos];
    var transformObjeto : Transform = objetoObtido.transform;
    return transformObjeto;
}


