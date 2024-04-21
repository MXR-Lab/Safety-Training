using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizePosition : MonoBehaviour
{
    public GameObject prefab;
    int xPos; int zPos;
    int index = 0;
    [SerializeField] int objectToAdd;

    void Start() {
        while (index < objectToAdd)
        {
            float x = 4999/1000;
            float xPos = Random.Range(-x,x);
            float zPos = Random.Range(-x,x);
            Instantiate(prefab, gameObject.transform.TransformPoint(new Vector3(xPos, 1/2, zPos)), gameObject.transform.rotation);
            index++;
        }
    }

}
