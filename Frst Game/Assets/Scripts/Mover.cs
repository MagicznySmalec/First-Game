using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour


{
    Rigidbody rb;

    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; 

        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);
    }
}
