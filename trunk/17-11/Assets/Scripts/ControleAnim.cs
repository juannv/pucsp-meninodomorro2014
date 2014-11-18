using UnityEngine;
using System.Collections;

public class ControleAnim : MonoBehaviour {
	
	private Animator animator;
	private HashIDs hash;

	void Awake ()
	{
		animator = GetComponent<Animator> ();
		hash = gameObject.GetComponent<HashIDs> ();

	}
	
	void FixedUpdate ()
	{
		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0.1 || Mathf.Abs (Input.GetAxis ("Vertical")) > 0.1f)
			animator.SetBool (hash.walkBool, true);
		else if (Mathf.Abs (Input.GetAxis ("Horizontal")) < 0.1 || Mathf.Abs (Input.GetAxis ("Vertical")) < 0.1f)
			animator.SetBool (hash.walkBool, false);

	}

}