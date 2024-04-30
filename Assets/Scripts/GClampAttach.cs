using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GClampAttach : MonoBehaviour
{
    [SerializeField] GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Test");
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            Debug.Log("Test1");
            obj.transform.parent.position = transform.position;
            obj.transform.parent.rotation = transform.rotation;
            obj.GetComponent<Rigidbody>().useGravity = false;
            obj.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            obj.GetComponent<Rigidbody>().useGravity = true;
            obj.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}