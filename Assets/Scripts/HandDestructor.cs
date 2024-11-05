using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDestructor : MonoBehaviour
{
    [SerializeField] GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            Object.Destroy(other);
        }
    }
}
