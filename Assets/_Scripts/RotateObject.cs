using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject[] modelObjects;
    public bool isToggled = false;
    void Update()
    {
        if(modelObjects.Length <= 0)
        {
            modelObjects = GameObject.FindGameObjectsWithTag("modelObject");
        }
    }


    public void RotateLeft()
    {
        if (modelObjects.Length > 0)
        {
            foreach (GameObject obj in modelObjects)
            {
                obj.transform.Rotate(0, 15f, 0);
            }
        }
    }

    public void RotateRight() 
    {
        if (modelObjects.Length > 0)
        {
            foreach (GameObject obj in modelObjects)
            {
                obj.transform.Rotate(0, -15f, 0);
            }
        }
    }

    public void BringUp()
    {
        if (modelObjects.Length > 0)
        {
            foreach (GameObject obj in modelObjects)
            {
                obj.transform.position += new Vector3(0, 0.5f, 0);
            }
        }
    }
    
    public void BringDown()
    {
        if (modelObjects.Length > 0)
        {
            foreach (GameObject obj in modelObjects)
            {
                obj.transform.position += new Vector3(0, -0.5f, 0);
            }
        }
    }
}
