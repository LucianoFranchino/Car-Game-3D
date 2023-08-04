using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraficScript : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    [SerializeField] float carSpeed;

    public void Initialize(Vector3 direction, float speed)
    {
        moveDirection = direction;
        carSpeed = speed;
    }

    void Update()
    {
        transform.Translate(moveDirection * carSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pared"))
        {
            Destroy(gameObject);
        }
    }
}
