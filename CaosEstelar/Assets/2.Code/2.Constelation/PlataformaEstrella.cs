using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaEstrella : MonoBehaviour
{
    public int idEstrella; // Asigna un n�mero �nico a cada estrella
    [SerializeField] private Transform[] posicionesEstrellas;
    [SerializeField] private GameObject Light;
    private void Start()
    {
        Light.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Llama a la funci�n TocarEstrella en el script del gestor
            FindObjectOfType<ConstelationController>().TocarEstrella(idEstrella);
            Debug.Log("Jugador paso por la estrella" + idEstrella);
            //DesactivarTodasLasLuces();

            // Activa la luz correspondiente a la estrella que toc� el jugador
            ActivarLuz();
        }
    }
    private void ActivarLuz()
    {
        Light.SetActive(true);
    }
    // M�todo para desactivar todas las luces
    public void DesactivarTodasLasLuces()
    {
        PlataformaEstrella[] estrellas = FindObjectsOfType<PlataformaEstrella>();

        foreach (PlataformaEstrella estrella in estrellas)
        {
            estrella.Light.SetActive(false);
        }
    }

}


