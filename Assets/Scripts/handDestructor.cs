using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handDestructor : MonoBehaviour
{
    [SerializeField] GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            Destroy(other);
            Debug.Log("Hi :)");
        }
    }
}
