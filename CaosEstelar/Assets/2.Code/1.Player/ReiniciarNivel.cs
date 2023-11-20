using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarNivel : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){

            ResetPosicion();
        }
    }

    public void ResetPosicion()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
