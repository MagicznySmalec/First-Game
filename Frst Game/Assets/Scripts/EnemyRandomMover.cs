using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomMover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    Transform ts;

    // Start is called before the first frame update
    void Start()
    {
        ts = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

