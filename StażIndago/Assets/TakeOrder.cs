using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TakeOrder : MonoBehaviour
{
    public GameObject pressE;
    public GameObject mainCamera;
    public TextMeshPro orderStatus;
    private bool inRange = false;

    private void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        transform.LookAt(mainCamera.transform);
        if(inRange == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                pressE.SetActive(false);
                orderStatus.text = "Take order to bar";
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        inRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
    }
}
