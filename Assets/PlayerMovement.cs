using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float boostModifier;
    Rigidbody2D rb;
    Vector2 inputDirection = Vector2.zero;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        Vector2 movementDir = value.Get<Vector2>();
        // rb.AddForce(movementDir * speed, ForceMode2D.Impulse);
        // rb.AddFroce(movementDir*boostModifier, ForceMode2D.Impluse);

        inputDirection = movementDir;
    }

    private void Update()
    {
        rb.AddForce(inputDirection*boostModifier);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
    

