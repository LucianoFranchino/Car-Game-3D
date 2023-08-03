using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movimiento
    public float aceleration = 10f;
    public float maxSpeed = 20f;
    public float currentSpeed = 0f;
    //public float reverse = 5f;
    public float brakeFroce = 30f;

    //Giro
    public float turnSpeed = 80f; 
    public float maxTurnAngle = 30f;

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
        Giro();
    }

    void Movimiento()
    {
        if (Input.GetKey(KeyCode.W))
        {
            currentSpeed += aceleration * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentSpeed -= brakeFroce * Time.deltaTime;
        }
        else
        {
            currentSpeed *= 0.95f;
        }

        currentSpeed = Mathf.Clamp(currentSpeed, 0f, maxSpeed);
    }
    void Giro()
    {
        if (currentSpeed > 0f) 
        {
            float turnInput = Input.GetAxis("Horizontal");
            float turnAngle = turnInput * turnSpeed * Time.deltaTime * currentSpeed / maxSpeed;

            turnAngle = Mathf.Clamp(turnAngle, -maxTurnAngle, maxTurnAngle);
            transform.Rotate(Vector3.up, turnAngle);
        }
    }
}
