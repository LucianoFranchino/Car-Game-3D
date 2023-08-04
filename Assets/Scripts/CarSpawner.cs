using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    public GameObject cars;
    public float interval, speed;
    public Vector3 direction;
    public float rotationValor;

    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= interval)
        {
            timer = 0f;
            SpawnObject();
        }
    }

    public void SpawnObject()
    {
        GameObject newCar = Instantiate(cars, transform.position, Quaternion.identity);
        newCar.transform.Rotate(Vector3.up, rotationValor);
        Rigidbody rb = newCar.GetComponent<Rigidbody>();
        if(rb != null)
        {
            rb.velocity = direction.normalized * speed;
        }
    }

}
