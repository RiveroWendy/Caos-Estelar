using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConstelationController : MonoBehaviour
{
    public List<int> ordenEstrellas; // Lista de prefabs de estrellas en el orden correcto
    private int indiceActual = 0;
    [SerializeField] private string nombreDeEscenaADescargar;
    private List<Vector3> posicionesEstrellasTocadas = new List<Vector3>();
    [SerializeField] private PlataformaEstrella plataformaEstrella;
    [SerializeField] private Test linea;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private float segundos;
    [SerializeField] private TimerController timerController;
    [SerializeField] private AudioManager audiomanager;
    private string error;

    private void Start()
    {
        string nombreEscenaActiva = SceneManager.GetActiveScene().name;
        
        if (nombreEscenaActiva == "Level 1")
        {
            error = "Error1";

        }
        else if (nombreEscenaActiva == "Level 2")
        {
            error = "Error2";

        }
    }
    public void TocarEstrella(int idEstrella)
    {
        if (indiceActual < ordenEstrellas.Count) // Verifica si aún hay estrellas en la secuencia
        {
            if (idEstrella == ordenEstrellas[indiceActual])
            {
                // La estrella tocada es la correcta en la secuencia
                posicionesEstrellasTocadas.Add(FindObjectOfType<PlataformaEstrella>().transform.position); // Guarda la posición de la estrella tocada
                // La estrella tocada es la correcta en la secuencia
                indiceActual++;

                if (indiceActual == ordenEstrellas.Count)
                {
                    // Todas las estrellas han sido tocadas en el orden correcto
                    CompletarNivel();
                }
            }
            else
            {
                // El jugador tocó una estrella incorrecta, reiniciar la secuencia si lo deseas
                audiomanager.PlaySFX(error);
                ReiniciarSecuencia();
                plataformaEstrella.DesactivarTodasLasLuces();

            }
        }
    }

    // Lógica para completar el nivel
    public bool CompletarNivel()
    {
        bool completado = true;
        audiomanager.PlaySFX("PasarNivel");
        Debug.Log("Nivel completado");
        linea.setearLineas();
        scoreManager.CalculateScore();
        timerController.PauseGame();
        Invoke("CambiarEscena", segundos);

        return completado;

    }
    private void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeEscenaADescargar);
    }
    private void ReiniciarSecuencia()
    {
        // Agrega aquí la lógica para reiniciar la secuencia
        Debug.Log("Secuencia incorrecta. Reiniciando...");
        indiceActual = 0; // Reinicia el índice
        posicionesEstrellasTocadas.Clear();
    }
    private bool PosicionYaTocada(Vector3 posicion)
    {
        return posicionesEstrellasTocadas.Contains(posicion);
    }
}
