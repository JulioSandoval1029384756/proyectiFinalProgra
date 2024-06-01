using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour


{       // Velocidad de movimiento del personaje
    public float velocidad = 5f; 
    public Rigidbody2D rigidbody2D;
    public GameObject currentPushObject;
    
    

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation; 
        // Congelar la rotación en el eje Z
       
    }

    void Update()
    {
        // Obtener la entrada del teclado para movimiento horizontal y vertical
        float inputMovimientoHorizontal = Input.GetAxis("Horizontal");
        float inputMovimientoVertical = Input.GetAxis("Vertical");

        // Establecer la velocidad del Rigidbody2D en función de la entrada del teclado
        rigidbody2D.velocity = new Vector2(inputMovimientoHorizontal * velocidad, inputMovimientoVertical * velocidad);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MovableObject"))
        {
            if (currentPushObject == null)
            {
                currentPushObject = collision.gameObject;
                MovableObject movableObject = currentPushObject.GetComponent<MovableObject>();
                movableObject.SetBeingPushed(true);
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == currentPushObject)
        {
            MovableObject movableObject = currentPushObject.GetComponent<MovableObject>();
            movableObject.SetBeingPushed(false);
            currentPushObject = null;
        }
    }
}

