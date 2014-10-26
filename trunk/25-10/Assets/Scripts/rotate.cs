using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	private Vector3 mousePosOld = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		// So rotaciona quando a posiçao antiga do mouse for diferente
		if (mousePosOld.Equals (mousePos) == false) { 
						transform.rotation = Quaternion.LookRotation (Vector3.forward, mousePos - transform.position);
			mousePosOld = mousePos;
				}
		if (Mathf.Abs (Input.GetAxis ("HorizontalRotation")) > 0.1 || Mathf.Abs (Input.GetAxis ("VerticalRotation")) > 0.1) {
						transform.rotation = Quaternion.LookRotation (
				Vector3.forward,
				new Vector3 (Input.GetAxis ("HorizontalRotation"),
			            Input.GetAxis ("VerticalRotation"),
			            transform.position.z));
				}
	}
}
