using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clipAttachElevated : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject obj1;
    [SerializeField] GameObject attachPoint;
    [SerializeField] GameObject startAttach1;


    private void Start()
    {
        obj.transform.parent.position = attachPoint.transform.position;
        obj.transform.parent.rotation = attachPoint.transform.rotation;
        obj.GetComponent<Rigidbody>().useGravity = false;
        obj.GetComponent<Rigidbody>().isKinematic = true;
        obj1.transform.parent.position = startAttach1.transform.position;
        obj1.transform.parent.rotation = startAttach1.transform.rotation;
        obj1.transform.parent.GetComponent<Rigidbody>().useGravity = false;
        obj1.transform.parent.GetComponent<Rigidbody>().isKinematic = true;
    }

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
            obj1.transform.parent.GetComponent<Rigidbody>().useGravity = false;
            obj1.transform.parent.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            obj.transform.parent.GetComponent<Rigidbody>().useGravity = true;
            obj.transform.parent.GetComponent<Rigidbody>().isKinematic = false;
        }
        if (other.Equals(obj1.GetComponent<Collider>()))
        {
            obj1.transform.parent.GetComponent<Rigidbody>().useGravity = true;
            obj1.transform.parent.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
