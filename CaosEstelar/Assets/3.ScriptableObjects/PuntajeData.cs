using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevoPuntaje", menuName = "Datos/Puntaje", order = 1)]
public class PuntajeData : ScriptableObject
{
    [SerializeField] private int puntaje;

    public int GetPuntaje()
    {
        return puntaje;
    }

    public int SetPuntaje(int value)
    {
        puntaje += value;
        return puntaje;
    }
}