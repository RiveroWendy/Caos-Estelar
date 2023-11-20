using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed = 5f;
    public float lifetime = 5f; // Tiempo de vida en segundos
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Destroy(gameObject, lifetime); // Destruye el asteroide después de 'lifetime' segundos

        if (player != null)
        {
            Vector3 directionToPlayer = (player.position - transform.position).normalized;
            CalcularAngulo(directionToPlayer);
        }
    }

    void Update()
    {
        if (player != null)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    void CalcularAngulo(Vector3 directionToPlayer)
    {
        // Calcular el ángulo en radianes
        float angle = Mathf.Atan2(directionToPlayer.y, directionToPlayer.x) * Mathf.Rad2Deg;

        // Rotar el asteroide hacia el ángulo sin afectar la inclinación
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
