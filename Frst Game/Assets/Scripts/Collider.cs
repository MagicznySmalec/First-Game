using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                    Debug.Log("You have been respawned");
                    break;
            case "Enemy":
                    Debug.Log("Enemy has killed you!");
                    break;
            case "Collectible":
                    Debug.Log("Congrats !");
                    break;
            default:
                    Debug.Log("You crashed into an obstacle");
                    break;
        }
    }   

}
