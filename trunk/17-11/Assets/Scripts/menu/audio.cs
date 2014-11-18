using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class audio : MonoBehaviour {
	public float volumeSlider = 10.0F;		// tamanho da barra de volume
	static float volume;					// variavel de volume
	// Use this for initialization

	public float brightSlider = 10.0F;		// tamanho da barra de brilho
	static float brightness;				// varivavel de brilho
	


	void OnGUI()
	{
		volumeSlider = GUI.HorizontalSlider(new Rect(Screen.width/2 + 355, Screen.height/2 - 75, 100, 5), volumeSlider, 0.0F, 1.0F);	// posicao da barra, tamanho da barra e valores de inicio/fim
		AudioListener.volume = volumeSlider;						//volume igual a 0.1 vezes a posicao da barra



		brightSlider = GUI.HorizontalSlider(new Rect(Screen.width/2 + 355, Screen.height/2 + 35, 100, 5), brightSlider, 0.0F, 10.0F);	// posicao da barra, tamanho da barra e valores de inicio/fim
		//Screen. = 0.1f * brightSlider;

	}
}
