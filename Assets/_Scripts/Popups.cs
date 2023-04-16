using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popups : MonoBehaviour
{
    public GameObject modelObject;
    public GameObject canvasPopup;
    bool isActive = false;
    void Update()
    {
        if (modelObject == null)
        {
            modelObject = GameObject.FindGameObjectWithTag("modelObject");
        }
        if (modelObject != null)
        {
            canvasPopup = modelObject.transform.GetChild(0).gameObject;
        }
        if(canvasPopup)
        {
            for (int i = 0; i < canvasPopup.transform.childCount; i++)
            {
                canvasPopup.transform.GetChild(i).LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
            }
        }
    }

    public void ShowInfo()
    {
        if (modelObject == null)
            return;
        isActive = !isActive;
        canvasPopup.SetActive(isActive);
    }
}
