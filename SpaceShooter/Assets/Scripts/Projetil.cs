using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    [Range(0f, 20f)]
    public float velocidade = 2f;
    [Range(0f, 10f)]
    public float delayDestruir = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
    }
}
