using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private bool beingPushed;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation; // Congelar la rotaci�n en el eje Z
        beingPushed = false;
    }

    void FixedUpdate()
    {
        if (!beingPushed)
        {
            rigidbody2D.velocity = Vector2.zero; // Detener el movimiento
        }
    }

    public void SetBeingPushed(bool state)
    {
        beingPushed = state;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
            if (playerMovement != null && playerMovement.currentPushObject == gameObject)
            {
                beingPushed = true; // El objeto est� siendo empujado por el jugador
            }
            else
            {
                beingPushed = false; // Si el jugador est� empujando otro objeto, este objeto no debe moverse
                rigidbody2D.velocity = Vector2.zero; // Detener el movimiento
            }
        }
    }
}
