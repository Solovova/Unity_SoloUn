using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public GameObject  box;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Test from solo start");
        // if (this.box == null){
        //     Debug.Log("Box is null");
        // }
        //box.SetActive(false);
        Destroy(box.GetComponent<BoxCollider>());
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Я изучаю Unity!");
    }
}
