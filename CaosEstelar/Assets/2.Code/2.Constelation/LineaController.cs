using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineaController : MonoBehaviour
{
    private LineRenderer linea;
    private Transform[] puntos;

    private void Awake()
    {
        linea = GetComponent<LineRenderer>();
    }
  
    public void setUpLinea(Transform[] puntos)
    {
        linea.positionCount = puntos.Length;
        this.puntos = puntos;
        SetearPosicion();
    }

    public void SetearPosicion()
    {
        for (int i = 0; i < puntos.Length; i++)
        {
            linea.SetPosition(i, puntos[i].position);

        }
    }
}
