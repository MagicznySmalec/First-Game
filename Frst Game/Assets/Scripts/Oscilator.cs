using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{

    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    float movementFactor;
    [SerializeField] float period = 2f;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycles = Time.time / period; // rosnie w czasie 

        const float tau = Mathf.PI * 2; // stala 6.28
        float sinWave = Mathf.Sin(cycles * tau); // zasieg od -1 do 1

        movementFactor = (sinWave + 1f) / 2f; // od 0 do 1
        

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
