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

        // Obt�n el EventSystem actual
        EventSystem eventSystem = EventSystem.current;

        // Si hay un EventSystem y tiene un bot�n seleccionado, gu�rdalo en la variable botonSeleccionado
        if (eventSystem != null && eventSystem.currentSelectedGameObject != null)
        {
            botonSeleccionado = eventSystem.currentSelectedGameObject.GetComponent<Button>();
        }
    }

    void Update()
    {
        // Verifica si el bot�n seleccionado ha cambiado
        if (EventSystem.current.currentSelectedGameObject != null &&
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>() != botonSeleccionado)
        {
            audioManager.PlaySFX("MenuBotones");
            // Si ha cambiado, realiza las acciones que necesitas con el nuevo bot�n seleccionado
            botonSeleccionado = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
            Debug.Log("Nuevo bot�n seleccionado: " + botonSeleccionado.name);
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
