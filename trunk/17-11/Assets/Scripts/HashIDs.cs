using UnityEngine;
using System.Collections;

public class HashIDs : MonoBehaviour {

	public int deadState;
	public int deadBool;
	public int walkState;
	public int walkBool;
	public int shootState;
//	public int shootBool;
	public int idleState;

	public int shootTrigger;
//	public int walkTrigger;


	void Awake ()
	{
		deadState = Animator.StringToHash ("Base Layer.Dead");
		deadBool = Animator.StringToHash ("deadBool");
		walkState = Animator.StringToHash ("Base Layer.PistolWalk");
		walkBool = Animator.StringToHash ("walkBool");
		shootState = Animator.StringToHash ("Base Layer.PistolShoot");
//		shootBool = Animator.StringToHash ("shootBool");
		idleState = Animator.StringToHash ("Base Layer.PistolIdle");

		shootTrigger = Animator.StringToHash ("shootTrigger");
//		walkTrigger = Animator.StringToHash ("walkTrigger");
	}
	
}
