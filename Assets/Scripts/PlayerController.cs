using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20f;
    public float turnSpeed = 10f;
    [SerializeField] float horizontalIn;
    [SerializeField] float fowardIn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalIn = Input.GetAxis("Horizontal");
        fowardIn = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardIn);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalIn);
    }
}
