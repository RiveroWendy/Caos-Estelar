using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Transform[] puntos;
    [SerializeField] private LineaController line;


        public void setearLineas()
    {
        line.setUpLinea(puntos);
    }
}
