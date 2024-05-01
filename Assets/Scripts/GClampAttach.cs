using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GClampAttach : MonoBehaviour
{
    [SerializeField] GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            obj.transform.parent.position = transform.position;
            obj.transform.parent.rotation = transform.rotation;
            obj.transform.parent.GetComponent<Rigidbody>().useGravity = false;
            obj.transform.parent.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            obj.transform.parent.GetComponent<Rigidbody>().useGravity = true;
            obj.transform.parent.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}