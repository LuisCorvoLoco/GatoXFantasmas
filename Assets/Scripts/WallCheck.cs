using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{

    // Essa vari�vel � usada pra chamar a fun��o "Reflect" do JumpController uma �nica vez
    // Sem ela, caso o trigger encostasse em dois objetos de uma vez, o Reflect seria chamado duas vezes
    private bool triggerOn = false;

    private MovimentControler jump;

    void Start()
    {
        jump = GetComponentInParent<MovimentControler>();
    }

    // Algum objeto entrou no trigger
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Se o trigger n�o est� ativado ainda, ativa e reflete o pulo
        if (!triggerOn)
        {
            jump.Reflect();
            triggerOn = true;
        }
    }

    // S� desativa o trigger quando o objeto sai
    // A fazer: Essa fun��o n�o garante que tem 0 objetos dentro do trigger, s� que um deles acabou de sair
    //          Ent�o � necess�rio fazer um check se ainda existem objetos dentro do trigger, seja com a t�cnica
    //          que usei no GroundCheck ou com um contador que incrementa no OnTriggerEnter e decrementa aqui.
    void OnTriggerExit2D()
    {
        triggerOn = false;
    }
}
