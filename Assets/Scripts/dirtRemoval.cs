using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirtRemoval : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
    }
}
