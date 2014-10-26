using UnityEngine;
using System.Collections;

public class sair : MonoBehaviour
{
		public bool fechar = true;
		// Use this for initialization
		void OnMouseDown ()
		{
				if (fechar) {
						Application.LoadLevel ("menu");
				} else
						Application.Quit ();
		}
		// Update is called once per frame
/*		void Update ()
		{
				if (Input.GetKey (KeyCode.Escape)) {
						Application.LoadLevel ("menu");
				}*/
		}