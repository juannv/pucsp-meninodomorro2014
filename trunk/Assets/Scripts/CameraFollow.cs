using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public float velocidade = 20 ;
	public Transform siga;
	
	public void SetarAlvo(Transform t)
	{
		siga = t;
		//Para que a câmera sempre comece no personagem
		transform.position = new Vector3 (t.position.x, t.position.y, transform.position.z);
		
	}
	
	// Acontece depois do Update - Aconetecr assim que o jogador se moveu
	void LateUpdate()
	{
		if(siga)
		{
			float x = IncrementarDirecao(transform.position.x, siga.position.x, velocidade);
			float y = IncrementarDirecao(transform.position.y, siga.position.y, velocidade);
			transform.position = new Vector3(x, y, transform.position.z);
			
		}
	}
	
	// Aumenta Velocidade Atual avante ao alvo pela velocidade
	private float IncrementarDirecao (float VelocidadeAt, float VelocidadeAl, float aceler)
	{
		if(VelocidadeAt == VelocidadeAl)
		{
			return VelocidadeAt;
		}
		else
		{
			float direcao = Mathf.Sign(VelocidadeAl - VelocidadeAt); // VelocidadeAt deve ser aumentada ou diminuida para se aproximar do alvo
			VelocidadeAt += aceler * Time.smoothDeltaTime * direcao;
			return (direcao == Mathf.Sign(VelocidadeAl - VelocidadeAt))? VelocidadeAt: VelocidadeAl; // Se VelocidadeAt agora passou da VelocidadeAl então retornar VelocidadeAlv, senão retornar VelocidadeAt
		}
	}
}
