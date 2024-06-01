using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private float moveX;
    private float moveY;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Obtener la entrada del usuario
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        // Actualizar los parámetros del Animator
        animator.SetFloat("MoveX", moveX);
        animator.SetFloat("MoveY", moveY);

        // Lógica para activar las animaciones
        if (moveX > 0)
        {
            animator.Play("derecha");
        }
        else if (moveX < 0)
        {
            animator.Play("izquierda");
        }
        else if (moveY > 0)
        {
            animator.Play("arriba");
        }
        else if (moveY < 0)
        {
            animator.Play("abajo");
        }
        else
        {
            animator.Play("quieto");
        }
    }
}
