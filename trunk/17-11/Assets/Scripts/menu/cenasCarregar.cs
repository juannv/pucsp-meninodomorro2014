using UnityEngine;
using System.Collections;

public class cenasCarregar : MonoBehaviour {
	
	public string nomedacena = "nome da cena";	// nome da cena a ser carregada
	private string menu = "1 Menu";
	private string pont = "10 Pont";

	public bool novoMenu;
	public bool sairMenu;
	public bool novoInGame;
	public bool sairInGame;
	public bool novoPont;
	public bool sairPont;
	
	void OnMouseDown ()
	{
		if (novoMenu){
			PlayerPrefs.DeleteKey ("ChaveSalvarPontos");
			Application.LoadLevel(nomedacena);
		}
		if (sairMenu) {
			Application.Quit();
		}
		if (novoInGame) {
			Application.LoadLevel(nomedacena);
		}
		if (sairInGame) {			
			Application.LoadLevel (pont);
		}
		if (novoPont) {
			//		CARREGAR ULTIMO LEVEL JOGADO
			//		MUDAR SPRITE ON MOUSE DOWN
				}
		if (sairPont){
			Application.LoadLevel (menu);
			//		MUDAR SPRITE ON MOUSE DOWN	
		}
	}
}