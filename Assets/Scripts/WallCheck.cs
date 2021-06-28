using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{

    // Essa variável é usada pra chamar a função "Reflect" do JumpController uma única vez
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
        // Se o trigger não está ativado ainda, ativa e reflete o pulo
        if (!triggerOn)
        {
            jump.Reflect();
            triggerOn = true;
        }
    }

    // Só desativa o trigger quando o objeto sai
    // A fazer: Essa função não garante que tem 0 objetos dentro do trigger, só que um deles acabou de sair
    //          Então é necessário fazer um check se ainda existem objetos dentro do trigger, seja com a técnica
    //          que usei no GroundCheck ou com um contador que incrementa no OnTriggerEnter e decrementa aqui.
    void OnTriggerExit2D()
    {
        triggerOn = false;
    }
}
