using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public float velocidade = 20 ;			// velocidade da camera
	public Transform siga;					// o que deve ser seguido
	
	public void SetarAlvo(Transform t)
	{
		siga = t;							// valor local do que deve ser seguido para que a câmera sempre comece no personagem
		transform.position = new Vector3 (t.position.x, t.position.y, transform.position.z);		// posicao do que deve ser seguido
		
	}

	void LateUpdate()
	{
		if(siga)			// se houver algo no siga
		{
			float x = IncrementarDirecao(transform.position.x, siga.position.x, velocidade);		
			float y = IncrementarDirecao(transform.position.y, siga.position.y, velocidade);		
			transform.position = new Vector3(x, y, transform.position.z);												
			// move a camera em direcao ao objeto definido como siga com a velocidade definida
		}
	}

	private float IncrementarDirecao (float VelocidadeAt, float VelocidadeAl, float aceler)
	{
		if(VelocidadeAt == VelocidadeAl)		// se velocidade atual for igual a velocidade do alvo
		{
			return VelocidadeAt;				// retornar a velocidade atual
		}
		else
		{
			float direcao = Mathf.Sign(VelocidadeAl - VelocidadeAt); // direcao na velocidade atual subtraida da velocidade do alvo - ao se aproximar desacelera
			VelocidadeAt += aceler * Time.smoothDeltaTime * direcao; // VelocidadeAt deve ser aumentada ou diminuida para se aproximar do alvo
			return (direcao == Mathf.Sign(VelocidadeAl - VelocidadeAt))? VelocidadeAt: VelocidadeAl; // Se VelocidadeAt agora passou da VelocidadeAl então retornar VelocidadeAlv, senão retornar VelocidadeAt
		}
	}
}
