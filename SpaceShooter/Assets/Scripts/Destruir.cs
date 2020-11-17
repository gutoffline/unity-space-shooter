using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    [Range(0f, 10f)]
    public float delayDestruir = 5f;

    private void Start()
    {
        Destroy(gameObject, delayDestruir);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
