using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 2f;
    public BoxCollider2D areaJogo;
    void Start()
    {
        print(areaJogo.bounds.extents);
    }


    void Update()
    {


        //MOVIMENTAÇÃO DO JOGADOR


        // Input vertical
        // Recebe 0 quando nao esta apertado
        // 1 quando esta apertador para cima
        // -1 quando apertado para baixo

        var vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * vertical * velocidade * Time.deltaTime);
        var horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontal * velocidade * Time.deltaTime);



        // Garantir que o jogador ficará dentro da área do jogo
        var position = areaJogo.transform.position;
        var extents = areaJogo.bounds.extents;
        var offset = areaJogo.offset;

        var limiteXMin = -extents.x + position.x + offset.x * 2.5f;
        var limiteXMax = extents.x + position.x + offset.x * 2.5f;

        var limiteYMin = -extents.y + position.y + offset.y * 2.5f;
        var limiteYMax = extents.y + position.y + offset.y * 2.5f;

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, limiteXMin, limiteXMax),
            Mathf.Clamp(transform.position.y, limiteYMin, limiteYMax)
        );
    }
}
