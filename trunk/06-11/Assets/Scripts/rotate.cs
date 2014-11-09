using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	
	private Vector3 mousePosOld = Vector3.zero;		// zera posicao atual do mouse
	
	
	void Update () {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);		// obtem a posicao do mouse
		
		if (mousePosOld.Equals (mousePos) == false) // So rotaciona quando a posiçao antiga do mouse for diferente
		{ 
			transform.rotation = Quaternion.LookRotation (Vector3.forward, mousePos - transform.position);  // rotaciona objeto em direcao ao mousePos
			mousePosOld = mousePos;	// altera a posicao atual do mouse
		}
		if (Mathf.Abs (Input.GetAxis ("HorizontalRotation")) > 0.1 || Mathf.Abs (Input.GetAxis ("VerticalRotation")) > 0.1)	// se o eixo horizontal e vertical forem maiores do que 0.1
		{
			transform.rotation = Quaternion.LookRotation (Vector3.forward,new Vector3 (Input.GetAxis ("HorizontalRotation"),
			                                                                           Input.GetAxis ("VerticalRotation"),
			                                                                           transform.position.z));
																									// rotaciona o objeto de acordo com o eixo
		}
	}
}
