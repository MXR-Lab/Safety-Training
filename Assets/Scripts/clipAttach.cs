using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clipAttach : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject obj1;
    [SerializeField] GameObject attachPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            obj.transform.parent.position = attachPoint.transform.position;
            obj.transform.parent.rotation = attachPoint.transform.rotation;
            obj.GetComponent<Rigidbody>().useGravity = false;
            obj.GetComponent<Rigidbody>().isKinematic = true;
        }
        if (other.Equals(obj1.GetComponent<Collider>()))
        {
            obj1.transform.parent.position = attachPoint.transform.position;
            obj1.transform.parent.rotation = attachPoint.transform.rotation;
            obj1.GetComponent<Rigidbody>().useGravity = false;
            obj1.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            obj.GetComponent<Rigidbody>().useGravity = true;
            obj.GetComponent<Rigidbody>().isKinematic = false;
        }
        if (other.Equals(obj1.GetComponent<Collider>()))
        {
            obj1.GetComponent<Rigidbody>().useGravity = true;
            obj1.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
