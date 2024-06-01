using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLogger : MonoBehaviour
{
    public string PlayerTag = "Player"; // El tag del objeto que representa al jugador
    public string TargetTag = "Target"; // El tag del objeto con el que el jugador debe colisionar

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el objeto colisionado tiene el tag del jugador
        if (collision.gameObject.CompareTag(PlayerTag) && gameObject.CompareTag(TargetTag))
        {
            // Imprimir un mensaje en la consola
            Debug.Log("1");
        }
    }
}


