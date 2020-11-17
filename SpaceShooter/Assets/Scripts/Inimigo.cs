using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Inimigo : MonoBehaviour
{
    [Range(0f, 20f)]
    public float velocidade = 2f;

    [Range(0f, 10f)]
    public float delayDestruir = 5f;

    public GameObject explosaoPrefab;

    private Jogador jogadorScript;

    private void Start()
    {
        jogadorScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Jogador>();

        Destroy(gameObject, delayDestruir);
    }

    private void Update()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.tag);
        if (other.CompareTag("Projetil"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(explosaoPrefab, transform.position, transform.rotation);
            jogadorScript.AdicionarPontos();
        }

        if (other.CompareTag("Player"))
        {
            //carrega a primeira cena
            SceneManager.LoadScene(0);

            //carrega a cena atual
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
