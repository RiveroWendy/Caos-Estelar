using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class BotonController : MonoBehaviour
{
    private Button botonSeleccionado;
    [SerializeField] private AudioManager audioManager;
    [SerializeField] private Transform Pointer;
    [SerializeField] private Transform[] buttonPosition;
    void Start()
    {
        Pointer.position = buttonPosition[0].position;

        // Obtén el EventSystem actual
        EventSystem eventSystem = EventSystem.current;

        // Si hay un EventSystem y tiene un botón seleccionado, guárdalo en la variable botonSeleccionado
        if (eventSystem != null && eventSystem.currentSelectedGameObject != null)
        {
            botonSeleccionado = eventSystem.currentSelectedGameObject.GetComponent<Button>();
        }
    }

    void Update()
    {
        // Verifica si el botón seleccionado ha cambiado
        if (EventSystem.current.currentSelectedGameObject != null &&
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>() != botonSeleccionado)
        {
            audioManager.PlaySFX("MenuBotones");
            // Si ha cambiado, realiza las acciones que necesitas con el nuevo botón seleccionado
            botonSeleccionado = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
            Debug.Log("Nuevo botón seleccionado: " + botonSeleccionado.name);
        }

        if(botonSeleccionado.name == "Tutorial")
        {
            Pointer.position = buttonPosition[1].position;
        }
        else if(botonSeleccionado.name =="Salir")
        {
            Pointer.position = buttonPosition[2].position;
        }
        else
        {
            Pointer.position = buttonPosition[0].position;
        }
    }

}
