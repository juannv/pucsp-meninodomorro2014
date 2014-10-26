using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {
	public float hSliderValue = 10.0F;
	static float volume;
	// Use this for initialization
	void OnGUI()
	{
		hSliderValue = GUI.HorizontalSlider(new Rect(815, 510, 100, 5), hSliderValue, 0.0F, 10.0F);
		AudioListener.volume = 0.1f * hSliderValue;
	}
}
