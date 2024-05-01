using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harnessAttach : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject group;
    [SerializeField] GameObject belt1;
    [SerializeField] GameObject belt2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            obj.GetComponent<Rigidbody>().useGravity = false;
            obj.GetComponent<Rigidbody>().isKinematic = true;
            group.transform.position = transform.position;
            group.transform.rotation = transform.rotation;
            belt1.SetActive(true);
            belt2.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.Equals(obj.GetComponent<Collider>()))
        {
            belt1.SetActive(false);
            belt2.SetActive(false);
            obj.GetComponent<Rigidbody>().useGravity = true;
            obj.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}

