using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionOnCollision : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        // Definir la posición inicial como el centro de la pantalla
        startPosition = new Vector3(0, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "puntoMorado" ||
            collision.gameObject.name == "puntoNaranja" ||
            collision.gameObject.name == "puntoVerde")
        {
            transform.position = startPosition;
            Debug.Log("Colisionado con " + collision.gameObject.name + ". Volviendo a la posición inicial.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "puntoMorado" ||
            other.gameObject.name == "puntoNaranja" ||
            other.gameObject.name == "puntoVerde")
        {
            transform.position = startPosition;
            Debug.Log("Colisionado con " + other.gameObject.name + ". Volviendo a la posición inicial.");
        }
    }
}
